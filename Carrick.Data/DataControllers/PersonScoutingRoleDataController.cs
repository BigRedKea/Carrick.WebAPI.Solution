namespace Carrick.Data.Controllers
{
    using Carrick.Data.Model;

    public class PersonScoutingRoleDataController : GenericDataController<PersonScoutingRole>
    {
        internal PersonScoutingRoleDataController(Repository r) : base(r, r.DataModel.PersonScoutingRoles)
        {         
        }

        protected internal override PersonScoutingRole TransferSpecificProperties(PersonScoutingRole original, ref PersonScoutingRole destination, Authorisation<PersonScoutingRole> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = new PersonScoutingRole(); }

            destination.PersonId = original.PersonId;
            destination.PersonGuid = original.PersonGuid;
            destination.ScoutingRoleId = original.ScoutingRoleId;
            destination.ScoutingRoleGuid = original.ScoutingRoleGuid;

            return destination;
        }
    }
}
