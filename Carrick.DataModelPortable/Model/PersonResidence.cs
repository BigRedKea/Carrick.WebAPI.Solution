
namespace ScoutDataModelPortable.Model
{
    using SQLite.Net.Attributes;
    using Scout.BusinessLogic.Interfaces;
    [Table("PersonResidence")]
    public partial class PersonResidence : TableBase, IPersonResidence
    {

        public int? PersonId { get; set; }

        public int? ResidenceId { get; set; }
    }
}
