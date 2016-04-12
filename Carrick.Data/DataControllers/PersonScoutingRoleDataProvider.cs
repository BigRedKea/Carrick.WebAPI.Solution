namespace Carrick.ServerData.Controllers
{
    using BusinessLogic.Interfaces;
    using Carrick.Server.DataModel;

    public class PersonScoutingRoleDataProvider : GenericDataProvider<IPersonScoutingRole, PersonScoutingRole>
    {
        internal PersonScoutingRoleDataProvider(Repository r) : base(r, r.DataModel.PersonScoutingRoles)
        {         
        }

        protected internal override IPersonScoutingRole TransferSpecificProperties(IPersonScoutingRole original, ref IPersonScoutingRole destination, Authorisation<IPersonScoutingRole> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = CreateItem(); }

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
