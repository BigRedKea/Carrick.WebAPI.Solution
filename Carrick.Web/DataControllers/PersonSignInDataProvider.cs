namespace Carrick.ServerData.Controllers
{
    using Carrick.BusinessLogic.Interfaces;
    using Carrick.Web.Models;

    public class PersonSignInDataProvider : GenericDataProvider<IPersonSignIn, PersonSignIn>
    {
        internal PersonSignInDataProvider(Repository r) : base(r, r.DataModel.PersonSignIn)
        {
        }

        protected internal override IPersonSignIn TransferSpecificProperties( IPersonSignIn original, ref PersonSignIn destination, Authorisation<IPersonSignIn> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = Convert(CreateItem()); }

            destination.PersonId = original.PersonId;
            destination.PersonGuid = original.PersonGuid;
            destination.SignInTimeStamp = original.SignInTimeStamp;
            destination.SignInStatus = original.SignInStatus;
            return destination;
        }


        public override PersonSignIn Convert(IPersonSignIn z)
        {
            return (PersonSignIn)z;
        }

        public override IPersonSignIn Convert(PersonSignIn z)
        {
            return z;
        }
    }
}
