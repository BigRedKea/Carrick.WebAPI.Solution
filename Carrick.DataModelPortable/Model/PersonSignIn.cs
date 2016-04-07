namespace Carrick.DataModel
{
    using SQLite.Net.Attributes;
    using System;
    
    [Table("PersonSignIn")]
    public partial class PersonSignIn :TableBase
    {

        public long? PersonId { get; set; }

        public DateTime? SignInTimeStamp { get; set; }

        [MaxLength(50)]
        public string SignInStatus { get; set; }
    }
}
