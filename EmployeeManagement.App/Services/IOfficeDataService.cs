using EmployeeManagement.Shared;

namespace EmployeeManagement.App.Services
{
	public interface IOfficeDataService
	{
		Task<IEnumerable<Office>> GetAllOffices();

		Task<Office> GetOfficeById(int officeId);
	}
}
