using System;
using System.Collections.Generic;

using Carrick.BusinessLogic.CompositeObjects;
using Carrick.BusinessLogic.Interfaces;

namespace Carrick.BusinessLogic.BusinessLogic
{

    public class BadgeRequestBusinessLogic : BusinessLogicBase<IPersonBadge>
    {
        internal BadgeRequestBusinessLogic(BusinessLogic BL) :base (BL)
        {
        }

        public IEnumerable<PersonBadgeComposite> GetBadgeRequestsForActiveScouts()
        {
            throw new NotImplementedException();
        }

        private PersonBadgeComposite CreateBadgeRequestComposite(IPersonBadge br)
        {
            PersonBadgeComposite brc = new PersonBadgeComposite()
            {
                PersonBadge = br
                          ,
                Badge = _BL.BadgeBL.GetBadge(br)
                          ,
                Person = _BL.PersonBL.GetPerson(br)
            };
            return brc;
        }

        public IEnumerable<PersonBadgeComposite> GetBadgesToAuthorise()
        {
            List<PersonBadgeComposite> brs = new List<PersonBadgeComposite>();

            foreach (IPersonBadge br in GetAllItems())
            {
                if (br.PresentedDateTime == null && br.AuthorisedById == null)
                {
                    brs.Add(CreateBadgeRequestComposite(br));
                }
            }
            return brs;
        }

        public IEnumerable<PersonBadgeComposite> GetBadgesToPresent(IPerson p)
        {
            List<PersonBadgeComposite> brs = new List<PersonBadgeComposite>();

            foreach (IPersonBadge br in GetAllItems())
            {
                if (br.PresentedDateTime == null && !(br.AuthorisedById ==null))
                {
                    brs.Add(CreateBadgeRequestComposite(br));
                }
            }
            return brs;
        }

        public IEnumerable<PersonBadgeComposite> GetBadgesToPresentToPersonsPresent()
        {
            IEnumerable<IPerson> persons = _BL.PersonBL.GetAllItems();
            List<PersonBadgeComposite> brs = new List<PersonBadgeComposite>();

            foreach (IPerson s in persons)
            {
                if (_BL.PersonBL.IsSignedIn(s))
                {
                    brs.AddRange(brs);
                }
            }
            return brs;
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

        public IEnumerable<PersonBadgeComposite> GetBadgeRequestsforPerson(IPerson person)
        {
            {
                List<PersonBadgeComposite> brs = new List<PersonBadgeComposite>();

                foreach (IPersonBadge br in GetAllItems())
                {
                    if (br.PresentedDateTime == null && !(br.AuthorisedById == null))
                    {
                        brs.Add(CreateBadgeRequestComposite(br));
                    }
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
            br.PersonBadge.PresentedDateTime = DateTime.Now;

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
    }
}