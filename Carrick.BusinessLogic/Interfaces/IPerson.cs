using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scout.BusinessLogic.Interfaces
{
    public interface IPerson : IDataTable

    {

        string PreferredName { get; set; }

        string ScoutName { get; set; }

        string Surname { get; set; }

        string MembershipId { get; set; }

        DateTime? DateOfBirth { get; set; }

        DateTime? DateOfInvestiture { get; set; }

        string MedicareNumber { get; set; }

        DateTime? LastTetanus { get; set; }

        DateTime? DateLeftOrganisation { get; set; }

        string NotesForMembership { get; set; }

        string FamilyCode { get; set; }

        string Email { get; set; }

        string Mobile { get; set; }

        string Gender { get; set; }

        string FullName();
    }
}
