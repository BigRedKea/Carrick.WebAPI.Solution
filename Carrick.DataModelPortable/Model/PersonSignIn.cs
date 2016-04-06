namespace ScoutDataModelPortable.Model
{
    using SQLite.Net.Attributes;
    using System;
    using Scout.BusinessLogic.Interfaces;
    [Table("PersonSignIn")]
    public partial class PersonSignIn :TableBase, IPersonSignIn
    {

        public long? PersonId { get; set; }

        public DateTime? SignInTimeStamp { get; set; }

        [MaxLength(50)]
        public string SignInStatus { get; set; }
    }
}
