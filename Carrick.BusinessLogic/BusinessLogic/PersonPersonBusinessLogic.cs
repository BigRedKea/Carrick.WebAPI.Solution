using System;
using Carrick.BusinessLogic.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Carrick.BusinessLogic
{
    public class PersonPersonBusinessLogic : BusinessLogicBase<IPersonPerson>
    {
        internal PersonPersonBusinessLogic(BusinessLogic BL) : base(BL)
        {
        }

        public void LinkScoutParent(IPerson _Scout, IPerson _ScoutParent)
        {
            throw new NotImplementedException();
        }

        public void BreakParentScoutLink(IPerson scout, IPerson _ScoutParent)
        {
            throw new NotImplementedException();
        }

        public IPerson[] GetRelatedAPersons(IPerson p, int PersonRelationshipTypeId)
        {
            List<IPerson> retval = new List<IPerson>();
            IPersonPerson[] itms = GetActiveItems().Where(x => (x.PersonBId == p.Id
                    && x.PersonRelationshipTypeId == PersonRelationshipTypeId)).ToArray<IPersonPerson>();

            foreach (IPersonPerson r in itms)
            {
                if (r.PersonAId.HasValue)
                {
                    retval.Add(_BL.PersonBL.GetItem(r.PersonAId.Value));
                }
            }

            return retval.ToArray();
        }

        public IPerson[] GetRelatedBPersons(IPerson p, int PersonRelationshipTypeId)
        {
            List<IPerson> retval = new List<IPerson>();
            IPersonPerson[] itms = GetActiveItems().Where(x => (x.PersonAId == p.Id
                    && x.PersonRelationshipTypeId == PersonRelationshipTypeId)).ToArray<IPersonPerson>();

            foreach (IPersonPerson r in itms)
            {
                if (r.PersonBId.HasValue)
                {
                    retval.Add(_BL.PersonBL.GetItem(r.PersonBId.Value));
                }
            }

            return retval.ToArray();
        }


        public IEnumerable<IPerson> GetChildren(IPerson p)
        {
            return GetRelatedAPersons(p, 1);
        }

        public IEnumerable<IPerson> GetParents(IPerson p)
        {
            return GetRelatedBPersons(p, 1);
        }
    }
}