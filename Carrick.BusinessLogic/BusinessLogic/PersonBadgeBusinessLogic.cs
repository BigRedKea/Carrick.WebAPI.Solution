using System;
using System.Collections.Generic;

using Carrick.BusinessLogic.CompositeObjects;
using Carrick.BusinessLogic.Interfaces;
using System.Linq;

namespace Carrick.BusinessLogic
{

    public class PersonBadgeBusinessLogic : BusinessLogicBase<IPersonBadge>
    {
        internal PersonBadgeBusinessLogic(BusinessLogic BL) :base (BL)
        {
        }

        public IEnumerable<PersonBadgeComposite> GetBadgeRequestsForActiveScouts()
        {
            throw new NotImplementedException();
        }


        public IEnumerable<PersonBadgeComposite> GetBadgesToAuthorise()
        {
            List<PersonBadgeComposite> brs = new List<PersonBadgeComposite>();

            foreach (IPersonBadge br in GetAllItems())
            {
                if (!br.PresentedTimeStamp.HasValue && !br.AuthorisedById.HasValue)
                {
                    brs.Add(GetComposite(br));
                }
            }
            return brs;
        }



        public IEnumerable<PersonBadgeComposite> GetBadgesToPresent(IPerson p)
        {
            List<PersonBadgeComposite> brs = new List<PersonBadgeComposite>();

            foreach (IPersonBadge br in GetAllItems())
            {
                if (!br.PresentedTimeStamp.HasValue && br.AuthorisedById.HasValue)
                {
                    brs.Add(GetComposite(br));
                }
            }
            return brs;
        }

        public IEnumerable<PersonBadgeComposite> GetCompositeItems(IEnumerable<IPersonBadge> items)
        {
            IList<PersonBadgeComposite> retval = new List<PersonBadgeComposite>();

            foreach (IPersonBadge s in items)
            {
                PersonBadgeComposite r = GetComposite(s);
                retval.Add(r);
            }
            return retval;
        }

        public PersonBadgeComposite GetComposite(IPersonBadge s)
        {
            PersonBadgeComposite r = new PersonBadgeComposite();
            r.Id = s.Id;
            r.PersonBadge = s;
            r.Badge = _BL.BadgeBL.GetItem(s.BadgeKey());
            r.Person = _BL.PersonBL.GetItem(s.PersonKey());
            return r;
        }


        public void AddServiceBadges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonBadgeComposite> GetBadgesToOrder()
        {
            throw new NotImplementedException();
        }

        public void CreateOrder()
        {
            throw new NotImplementedException();
        }


        public IEnumerable<PersonBadgeComposite> GetBadgeRequestsforPerson(int id)
        {
            return GetBadgeRequestsforPerson(_BL.PersonBL.GetPerson(id));
        }

        public IEnumerable<PersonBadgeComposite> GetBadgeRequestsforPerson(IPerson person)
        {
            {
                List<PersonBadgeComposite> brs = new List<PersonBadgeComposite>();

                foreach (IPersonBadge br in DataProvider.GetActiveItems()
                    .Where(x => x.PersonId==person.Id))
                {
                    brs.Add(GetComposite(br));
                }
                return brs;
            }
        }

        public object GetLastBadgeOrder()
        {
            throw new NotImplementedException();
        }

        public PersonBadgeComposite RequestBadge(IPerson Person, IBadge Badge)
        {
            PersonBadgeComposite br = new PersonBadgeComposite();
            br.Badge = Badge;
            br.Person = Person;
            br.PersonBadge = CreateItem();
            return br;
        }

        public void SetBadgePresented(PersonBadgeComposite br)
        {
            br.PersonBadge.PresentedTimeStamp= DateTime.Now;

            if (br.Badge.Stock > 0)
            {
                br.Badge.Stock = br.Badge.Stock - 1;
            }
            else
            {
                br.Badge.Stock = 0;
            }
        }

        public void DeleteItem(PersonBadgeComposite item)
        {
            base.DeleteItem(item.PersonBadge);
        }


        public IPerson GetPerson(IPersonBadge PersonBadge)
        {
            if (PersonBadge.PersonId.HasValue)
            {
                return _BL.PersonBL.GetItem(PersonBadge.PersonId.Value);
            }
            return null;
        }

        public IBadge GetBadge(IPersonBadge PersonBadge)
        {
            if (PersonBadge.BadgeId.HasValue)
            {
                return _BL.BadgeBL.GetItem(PersonBadge.BadgeId.Value);
            }
            return null;
        }

        public IPerson GetLeaderAssigned(IPersonBadge PersonBadge)
        {
            if (PersonBadge.LeaderAssignedId.HasValue)
            {
                return _BL.PersonBL.GetItem(PersonBadge.LeaderAssignedId.Value);
            }
            return null;
        }

        public IPerson GetAuthorisedBy(IPersonBadge PersonBadge)
        {
            if (PersonBadge.AuthorisedById.HasValue)
            {
                return _BL.PersonBL.GetItem(PersonBadge.AuthorisedById.Value);
            }
            return null;
        }
    }
}