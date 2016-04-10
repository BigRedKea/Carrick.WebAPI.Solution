namespace Carrick.ServerData.Controllers
{
    using Carrick.DataModel;
    public class ScoutingRoleDataController : GenericDataProvider <ScoutingRole>
    {

        internal ScoutingRoleDataController(Repository r) : base(r, r.DataModel.ScoutingRoles)
        {
        }

        protected internal override ScoutingRole TransferSpecificProperties(ScoutingRole original, ref ScoutingRole destination, Authorisation<ScoutingRole> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = new ScoutingRole(); }
            destination.Description = original.Description;
            destination.ShortText = original.ShortText;
            return destination;
        }


    }
}
