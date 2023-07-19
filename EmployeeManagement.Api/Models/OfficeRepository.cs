using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Shared;

namespace EmployeeManagement.Api.Models
{
	public class OfficeRepository: IOfficeRepository
	{
		private readonly AppDbContext _appDbContext;

		public OfficeRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public IEnumerable<Office> GetAllOffices()
		{
			return _appDbContext.Offices;
		}

		public Office GetOfficeById(int officeId)
		{
			return _appDbContext.Offices.FirstOrDefault(c => c.OfficeId == officeId);
		}
	}
}
