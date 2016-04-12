namespace Carrick.ServerData.Controllers
{
    using System;
    using Carrick.Server.DataModel;
    using BusinessLogic.Interfaces;
    public class Authorisation<T>
    {
        protected bool WriteRequested = false;
        protected bool ReadRequested = false;
        protected bool DeleteRequested = false;

        protected Guid? PersonRequestingAccessKey;


        public Authorisation(Guid? PersonRequestingAccessKey, bool ReadRequested = false, bool WriteRequested = false, bool DeleteRequested = false)
        {
            this.PersonRequestingAccessKey= PersonRequestingAccessKey;
            this.ReadRequested = ReadRequested;
            this.WriteRequested = WriteRequested;
            this.DeleteRequested = DeleteRequested;
        }


        protected bool IsMe(IPerson p)
        {
            if (PersonRequestingAccessKey.HasValue)
                if (PersonRequestingAccessKey.Value.ToString() == p.RowGuid.Value.ToString())
                {
                    return true;
                }
            return false;
        }

        protected bool IsParentOf(IPerson p)
        {
            return false;
        }

        protected bool IsAdultLeaderOf(IPerson p)
        {
            return false;
        }
    }
}
