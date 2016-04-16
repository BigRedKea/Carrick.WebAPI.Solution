namespace Carrick.Web.Models
{
    using BusinessLogic.Interfaces;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

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
