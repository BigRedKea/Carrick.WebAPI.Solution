namespace Carrick.Data.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Scout.BusinessLogic.Interfaces;

    [Table("Person")]
    public partial class Person : TableBase, IPerson
    {

        [StringLength(50)]
        public string PreferredName { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string ScoutName { get; set; }

        [StringLength(50)]
        public string MembershipId { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public DateTime? DateOfInvestiture { get; set; }

        [StringLength(50)]
        public string MedicareNumber { get; set; }

        public DateTime? LastTetanus { get; set; }

        public DateTime? DateLeftOrganisation { get; set; }

        public string NotesForMembership { get; set; }

        [StringLength(50)]
        public string FamilyCode { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        [StringLength(1)]
        public string Gender { get; set; }

        public override string ToString()
        {
            return PreferredName + " " + Surname;
        }

        string IPerson.FullName()
        {
            return PreferredName + " " + Surname;
        }

    }
}