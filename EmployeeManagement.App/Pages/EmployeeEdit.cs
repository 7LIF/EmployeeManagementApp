using EmployeeManagement.App.Services;
using EmployeeManagement.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.JSInterop;



namespace EmployeeManagement.App.Pages
{
	public partial class EmployeeEdit
	{
		[Inject]
		public IEmployeeDataService EmployeeDataService { get; set; }


		[Inject]
		public ICountryDataService CountryDataService { get; set; }


		[Inject]
		public IJobCategoryDataService JobCategoryDataService { get; set; }

		[Inject]
		public IOfficeDataService OfficeDataService { get; set; }


		[Inject]
		public NavigationManager NavigationManager { get; set; }


		[Parameter]
		public string EmployeeId { get; set; }


		public Employee Employee { get; set; } = new Employee();


		public List<Country> Countries { get; set; } = new List<Country>();


		public List<JobCategory> JobCategories { get; set; } = new List<JobCategory>();


		public List<Office> Offices { get; set; } = new List<Office>();


		protected string CountryId = string.Empty;
		protected string JobCategoryId = string.Empty;
		protected string OfficeId = string.Empty;


		//used to store state of scream
		protected string Message = string.Empty;
		protected string StatusClass = string.Empty;
		protected bool Saved;
		protected bool ClickSavedBtn;
		

		protected override async Task OnInitializedAsync()
		{
			Saved = false;
			ClickSavedBtn = false;

			//Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
			Countries = (await CountryDataService.GetAllCountries()).ToList();
			JobCategories = (await JobCategoryDataService.GetAllJobCategories()).ToList();
			Offices = (await OfficeDataService.GetAllOffices()).ToList();

			int.TryParse(EmployeeId, out var employeeId);

			if (employeeId == 0) //new employee is being created
			{
				//add some defaults
				Employee = new Employee { CountryId = 1, JobCategoryId = 1, OfficeId = 1, BirthDate = DateTime.Now, JoinedDate = DateTime.Now };
			}
			else 
			{
				Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
			}

			CountryId = Employee.CountryId.ToString();
			JobCategoryId = Employee.JobCategoryId.ToString();
			OfficeId = Employee.OfficeId.ToString();
		}


		protected async Task HandleValidSubmit()
		{
			Saved = false;
			ClickSavedBtn = true;


			Employee.CountryId = int.Parse(CountryId);
			Employee.JobCategoryId = int.Parse(JobCategoryId);
			Employee.OfficeId = int.Parse(OfficeId);

			if (Employee.EmployeeId == 0) //new
			{
				var addedEmployee = await EmployeeDataService.AddEmployee(Employee);
				if (addedEmployee != null)
				{
					StatusClass = "alert-success";
					Message = "New employee added successfully.";
					Saved = true;
				}
				else
				{
					StatusClass = "alert-danger";
					Message = "Something went wrong adding the new employee. Please try again.";
					Saved = false;
				}
			}
			else
			{
				await EmployeeDataService.UpdateEmployee(Employee);
				StatusClass = "alert-success";
				Message = "Employee updated successfully.";
				Saved = true;
			}
		}


		protected void HandleInvalidSubmit()
		{
			StatusClass = "alert-danger";
			Message = "There are some validation errors. Please try again.";
			ClickSavedBtn = true;

		}


		protected async Task DeleteEmployee()
		{
			await EmployeeDataService.DeleteEmployee(Employee.EmployeeId);

			StatusClass = "alert-sucess";
			Message = "Deleted successfully";

			Saved = true;

			await Task.Delay(3000); // 3 seconds of delay
			ForceNavigateToOverview();
		}

		protected void ForceNavigateToOverview()
		{
			NavigationManager.NavigateTo("/employeeoverview", forceLoad: true);
		}

		protected void NavigateToOverview () 
		{
			NavigationManager.NavigateTo("/employeeoverview");
		}

		private async Task ScrollToTop()
		{
			await JSRuntime.InvokeVoidAsync("scrollToTop");
		}

	}
}