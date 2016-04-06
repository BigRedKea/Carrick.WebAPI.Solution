namespace Scout.BusinessLogic.Interfaces
{

    public interface IPersonOrganisationUnit : IDataTable
    {
        int? OrganisationUnitId { get; set; }

        int? PersonId { get; set; }
    }
}
