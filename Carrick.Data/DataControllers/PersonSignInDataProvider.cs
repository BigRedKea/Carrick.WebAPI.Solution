namespace Carrick.ServerData.Controllers
{
    using BusinessLogic.Interfaces;
    using Carrick.Server.DataModel;

    public class PersonSignInDataProvider : GenericDataProvider<IPersonSignIn, PersonSignIn>
    {
        internal PersonSignInDataProvider(Repository r) : base(r, r.DataModel.PersonSignIn)
        {
        }

        protected internal override IPersonSignIn TransferSpecificProperties( IPersonSignIn original, ref IPersonSignIn destination, Authorisation<IPersonSignIn> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = CreateItem(); }

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
