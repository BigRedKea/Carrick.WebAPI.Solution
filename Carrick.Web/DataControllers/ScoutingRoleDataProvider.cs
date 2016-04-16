namespace Carrick.ServerData.Controllers
{
    using Carrick.BusinessLogic.Interfaces;
    using Carrick.Web.Models;

    public class ScoutingRoleDataProvider : GenericDataProvider <IScoutingRole, ScoutingRole>
    {

        internal ScoutingRoleDataProvider(Repository r) : base(r, r.DataModel.ScoutingRoles)
        {
        }

        protected internal override IScoutingRole TransferSpecificProperties(IScoutingRole original, ref ScoutingRole destination, Authorisation<IScoutingRole> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = Convert(CreateItem()); }
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
