using System.Collections.Generic;
using EmployeeManagement.Shared;

namespace EmployeeManagement.Api.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
