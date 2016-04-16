
namespace Carrick.Web.Models
{
    using BusinessLogic.Interfaces;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Person")]
    public partial class Person :TableBase , IPerson
    {

        private string _PreferredName;
        [MaxLength(16)]
        [StringLength(16)]
        public string PreferredName { get { return _PreferredName; } set { _PreferredName = value; } }

        private string _ScoutName;
        [MaxLength(16)]
        [StringLength(16)]
        public string ScoutName { get { return _ScoutName; } set { _ScoutName = value; } }

        private string _Surname;
        [MaxLength(16)]
        [StringLength(16)]
        public string Surname { get { return _Surname; } set { _Surname = value; } }

        [MaxLength(50)]
        [StringLength(50)]
        public string MembershipId { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public DateTime? DateOfInvestiture { get; set; }

        [MaxLength(50)]
        [StringLength(50)]
        public string MedicareNumber { get; set; }

        public DateTime? LastTetanus { get; set; }

        public DateTime? DateLeftOrganisation { get; set; }

        public string NotesForMembership { get; set; }

        [MaxLength(50)]
        [StringLength(50)]
        public string FamilyCode { get; set; }

        [MaxLength(50)]
        [StringLength(50)]
        public string Email { get; set; }

        [MaxLength(20)]
        [StringLength(20)]
        public string Mobile { get; set; }

        [MaxLength(1)]
        [StringLength(1)]
        public string Gender { get; set; }

        public override string ToString()
        {
            return _PreferredName + " " + _Surname;
        }

        public string FullName()
        {
            return _PreferredName + " " + _Surname;
        }


    }
}
