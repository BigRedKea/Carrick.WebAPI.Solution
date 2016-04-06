
namespace Scout.BusinessLogic.Interfaces
{

    public interface IOrganisationUnit :IDataTable
    {
        int? ParentOrganisationUnitId { get; set; }

        string Description { get; set; }

        string FileStorageURL { get; set; }
    }
}
