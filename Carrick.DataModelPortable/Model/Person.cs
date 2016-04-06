using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using Scout.BusinessLogic.Interfaces;

namespace ScoutDataModelPortable.Model
{
    public class Person :TableBase ,IPerson
    {


        private string _PreferredName;
        [MaxLength(16)]
        string IPerson.PreferredName { get { return _PreferredName; } set { _PreferredName = value; } }

        private string _ScoutName;
        [MaxLength(16)]
        string IPerson.ScoutName { get { return _ScoutName; } set { _ScoutName = value; } }

        private string _Surname;
        [MaxLength(16)]
        string IPerson.Surname { get { return _Surname; } set { _Surname = value; } }

        [MaxLength(50)]
        string IPerson.MembershipId { get; set; }

        DateTime? IPerson.DateOfBirth { get; set; }

        DateTime? IPerson.DateOfInvestiture { get; set; }

        [MaxLength(50)]
        string IPerson.MedicareNumber { get; set; }

        DateTime? IPerson.LastTetanus { get; set; }

        DateTime? IPerson.DateLeftOrganisation { get; set; }

        string IPerson.NotesForMembership { get; set; }

        [MaxLength(50)]
        string IPerson.FamilyCode { get; set; }

        [MaxLength(50)]
        string IPerson.Email { get; set; }

        [MaxLength(20)]
        string IPerson.Mobile { get; set; }

        [MaxLength(1)]
        string IPerson.Gender { get; set; }

        public override string ToString()
        {
            return _PreferredName + " " + _Surname;
        }

        string IPerson.FullName()
        {
            return _PreferredName + " " + _Surname;
        }


    }
}
