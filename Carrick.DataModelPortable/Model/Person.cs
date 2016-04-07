using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;


namespace Carrick.DataModel
{
    public partial class Person :TableBase
    {


        private string _PreferredName;
        [MaxLength(16)]
        public string PreferredName { get { return _PreferredName; } set { _PreferredName = value; } }

        private string _ScoutName;
        [MaxLength(16)]
        public string ScoutName { get { return _ScoutName; } set { _ScoutName = value; } }

        private string _Surname;
        [MaxLength(16)]
        public string Surname { get { return _Surname; } set { _Surname = value; } }

        [MaxLength(50)]
        public string MembershipId { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public DateTime? DateOfInvestiture { get; set; }

        [MaxLength(50)]
        public string MedicareNumber { get; set; }

        public DateTime? LastTetanus { get; set; }

        public DateTime? DateLeftOrganisation { get; set; }

        public string NotesForMembership { get; set; }

        [MaxLength(50)]
        public string FamilyCode { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Mobile { get; set; }

        [MaxLength(1)]
        public string Gender { get; set; }

        public override string ToString()
        {
            return _PreferredName + " " + _Surname;
        }

        string FullName()
        {
            return _PreferredName + " " + _Surname;
        }


    }
}
