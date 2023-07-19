using EmployeeManagement.Shared;
using System.Text.Json;



namespace EmployeeManagement.App.Services
{
	public class OfficeDataService : IOfficeDataService
	{
		private readonly HttpClient _httpClient;

		public OfficeDataService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<IEnumerable<Office>> GetAllOffices()
		{
			return await JsonSerializer.DeserializeAsync<IEnumerable<Office>>
				(await _httpClient.GetStreamAsync($"api/office"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
		}

		public async Task<Office> GetOfficeById(int officeId)
		{
			return await JsonSerializer.DeserializeAsync<Office>
				(await _httpClient.GetStreamAsync($"api/office/{officeId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
		}
	}
}
