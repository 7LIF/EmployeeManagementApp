using EmployeeManagement.Shared;

namespace EmployeeManagement.App.Services
{
	public interface IJobCategoryDataService
	{
		Task<IEnumerable<JobCategory>> GetAllJobCategories();

		Task<JobCategory> GetJobCategoryById(int jobCategoryId);
	}
}
