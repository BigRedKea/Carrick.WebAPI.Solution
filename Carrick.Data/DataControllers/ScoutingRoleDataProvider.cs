namespace Carrick.ServerData.Controllers
{
    using BusinessLogic.Interfaces;
    using Carrick.Server.DataModel;

    public class ScoutingRoleDataController : GenericDataProvider <IScoutingRole, ScoutingRole>
    {

        internal ScoutingRoleDataController(Repository r) : base(r, r.DataModel.ScoutingRoles)
        {
        }

        protected internal override IScoutingRole TransferSpecificProperties(IScoutingRole original, ref IScoutingRole destination, Authorisation<IScoutingRole> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = CreateItem(); }
            destination.Description = original.Description;
            destination.ShortText = original.ShortText;
            return destination;
        }


        public override ScoutingRole Convert(IScoutingRole z)
        {
            return (ScoutingRole)z;
        }

        public override IScoutingRole Convert(ScoutingRole z)
        {
            return z;
        }
    }
}
