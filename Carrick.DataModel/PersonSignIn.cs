namespace Carrick.DataModel
{
    using BusinessLogic.Interfaces;
    using SQLite.Net.Attributes;
    using System;

    [Table("PersonSignIn")]
    public partial class PersonSignIn :TableBase, IPersonSignIn
    {

        public int? PersonId { get; set; }
        public Guid PersonGuid { get; set; }

        public DateTime? SignInTimeStamp { get; set; }

        [MaxLength(50)]
        public string SignInStatus { get; set; }

        public DateTime? SignOutTimeStamp { get; set; }

        [MaxLength(50)]
        public string SignOutStatus { get; set; }
    }
}
