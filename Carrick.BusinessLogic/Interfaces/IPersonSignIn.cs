using System;

namespace Scout.BusinessLogic.Interfaces
{

    public interface IPersonSignIn : IDataTable
    {

        long? PersonId { get; set; }

        DateTime? SignInTimeStamp { get; set; }

        string SignInStatus { get; set; }
    }
}
