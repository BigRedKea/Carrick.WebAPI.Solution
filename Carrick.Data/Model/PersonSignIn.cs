namespace Carrick.Data.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Scout.BusinessLogic.Interfaces;

    [Table("PersonSignIn")]
    public partial class PersonSignIn :TableBase, IPersonSignIn
    {

        public long? PersonId { get; set; }

        public Guid? PersonGuid { get; set; }

        public DateTime? SignInTimeStamp { get; set; }

        [StringLength(50)]
        public string SignInStatus { get; set; }
    }
}
