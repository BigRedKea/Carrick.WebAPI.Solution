namespace Carrick.BusinessLogic.Interfaces
{
    using System;
    public interface IPersonSignIn :ITableBase
    {

        int? PersonId { get; set; }
        Guid PersonGuid { get; set; }

        DateTime? SignInTimeStamp { get; set; }

        string SignInStatus { get; set; }

        DateTime? SignOutTimeStamp { get; set; }

        string SignOutStatus { get; set; }
    }
}
