namespace Carrick.ServerData.Controllers
{
    using Carrick.BusinessLogic.Interfaces;
    using Carrick.Web.Models;

    public class PersonScoutingRoleDataProvider : GenericDataProvider<IPersonScoutingRole, PersonScoutingRole>
    {
        internal PersonScoutingRoleDataProvider(Repository r) : base(r, r.DataModel.PersonScoutingRoles)
        {         
        }

        protected internal override IPersonScoutingRole TransferSpecificProperties(IPersonScoutingRole original, ref PersonScoutingRole destination, Authorisation<IPersonScoutingRole> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = Convert(CreateItem()); }

            destination.PersonId = original.PersonId;
            destination.PersonGuid = original.PersonGuid;
            destination.ScoutingRoleId = original.ScoutingRoleId;
            destination.ScoutingRoleGuid = original.ScoutingRoleGuid;

            return destination;
        }

        public override PersonScoutingRole Convert(IPersonScoutingRole z)
        {
            return (PersonScoutingRole)z;
        }

        public override IPersonScoutingRole Convert(PersonScoutingRole z)
        {
            return z;
        }
    }
}
