namespace Carrick.Data.Model
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PersonResidence")]
    public partial class PersonResidence : TableBase
    {

        public int? PersonId { get; set; }

        public Guid? PersonGuid { get; set; }

        public int? ResidenceId { get; set; }

        public Guid? ResidenceGuid { get; set; }
    }
}
