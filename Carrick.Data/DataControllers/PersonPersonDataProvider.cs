
namespace Carrick.Data.Controllers
{
    using Carrick.DataModel;
    using System.Collections.Generic;
    using System.Linq;
    public class PersonPersonDataProvider : GenericDataProvider<PersonPerson>
    {

        internal PersonPersonDataProvider(Repository r) : base(r, r.DataModel.PersonPersons)
        {
        }

        protected internal override PersonPerson TransferSpecificProperties(PersonPerson original,ref PersonPerson destination, Authorisation<PersonPerson> Authorisation = null)
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

        public Person[] GetRelatedAPersons(Person p, int PersonRelationshipTypeId)
        {
            List<Person> retval = new List<Person>();
            PersonPerson[] itms = GetActiveItems().Where(x => (x.PersonBId == p.Id
                    && x.PersonRelationshipTypeId == PersonRelationshipTypeId)).ToArray<PersonPerson>();

            foreach (PersonPerson r in itms)
            {
                if (r.PersonAId.HasValue)
                {
                    retval.Add(Repository.PersonDataController.GetItem(r.PersonAId.Value));
                }
            }

            return retval.ToArray();
        }

        public Person[] GetRelatedBPersons(Person p, int PersonRelationshipTypeId)
        {
            List<Person> retval = new List<Person>();
            PersonPerson[] itms = GetActiveItems().Where(x => (x.PersonAId == p.Id
                    && x.PersonRelationshipTypeId == PersonRelationshipTypeId)).ToArray<PersonPerson>();

            foreach (PersonPerson r in itms)
            {
                if (r.PersonBId.HasValue)
                {
                    retval.Add(Repository.PersonDataController.GetItem(r.PersonBId.Value));
                }
            }
    
            return retval.ToArray();
        }


    }
}
