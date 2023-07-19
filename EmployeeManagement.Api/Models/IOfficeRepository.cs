using System.Collections.Generic;
using EmployeeManagement.Shared;

namespace EmployeeManagement.Api.Models
{
	public interface IOfficeRepository
	{
		IEnumerable<Office> GetAllOffices();
		Office GetOfficeById(int officeId);
	}
}
