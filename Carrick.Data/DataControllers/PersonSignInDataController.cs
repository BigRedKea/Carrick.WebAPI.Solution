namespace Carrick.Data.Controllers
{
    using Carrick.Data.Model;

    public class PersonSignInDataController : GenericDataController<PersonSignIn>
    {
        internal PersonSignInDataController(Repository r) : base(r, r.DataModel.PersonSignIn)
        {
        }

        protected internal override PersonSignIn TransferSpecificProperties( PersonSignIn original, ref PersonSignIn destination, Authorisation<PersonSignIn> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = new PersonSignIn(); }

            destination.PersonId = original.PersonId;
            destination.PersonGuid = original.PersonGuid;
            destination.SignInTimeStamp = original.SignInTimeStamp;
            destination.SignInStatus = original.SignInStatus;
            return destination;
        }
    }
}
