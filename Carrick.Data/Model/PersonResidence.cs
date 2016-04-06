namespace Carrick.Data.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Scout.BusinessLogic.Interfaces;

    [Table("PersonResidence")]
    public partial class PersonResidence : TableBase, IPersonResidence
    {

        public int? PersonId { get; set; }

        public Guid? PersonGuid { get; set; }

        public int? ResidenceId { get; set; }

        public Guid? ResidenceGuid { get; set; }
    }
}
