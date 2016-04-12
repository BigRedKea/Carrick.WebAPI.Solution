
namespace Carrick.ServerData.Controllers
{
    using System.Collections.Generic;
    using System.Linq;

    using Carrick.Server.DataModel;
    using BusinessLogic.Interfaces;
    public class PersonPersonDataProvider : GenericDataProvider<IPersonPerson, PersonPerson>
    {

        internal PersonPersonDataProvider(Repository r) : base(r, r.DataModel.PersonPersons)
        {
        }

        protected internal override IPersonPerson TransferSpecificProperties(IPersonPerson original,ref IPersonPerson destination, Authorisation<IPersonPerson> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { new PersonPerson();  }

            destination.PersonAId = original.PersonAId;
            destination.PersonAGuid = original.PersonAGuid;
            destination.PersonBId = original.PersonBId;
            destination.PersonBGuid = original.PersonBGuid;
            destination.RelationshipCanShareData = original.RelationshipCanShareData;
            destination.PersonRelationshipTypeId = original.PersonRelationshipTypeId;
            return destination;
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
                    retval.Add(Repository.PersonDataController.GetItem(r.PersonAId.Value));
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
                    retval.Add(Repository.PersonDataController.GetItem(r.PersonBId.Value));
                }
            }
    
            return retval.ToArray();
        }

        public override PersonPerson Convert(IPersonPerson z)
        {
            return (PersonPerson)z;
        }

        public override IPersonPerson Convert(PersonPerson z)
        {
            return z;
        }
    }
}
