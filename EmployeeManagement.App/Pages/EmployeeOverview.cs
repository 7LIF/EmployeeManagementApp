using EmployeeManagement.App.Services;
using EmployeeManagement.Shared;
using System;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using EmployeeManagement.App.Components;



namespace EmployeeManagement.App.Pages
{
    public partial class EmployeeOverview
    {
        public IEnumerable<Employee> Employees { get; set; }


        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }


        [Inject]
        public NavigationManager NavigationManager { get; set; }


        protected AddEmployeeDialog AddEmployeeDialog { get; set; }


        [Parameter]
        public EventCallback<bool> OnClickEventCallback { get; set; }


        protected async override Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }


        protected void QuickAddEmployee()
        {
            AddEmployeeDialog.Show();
        }


        public async void AddEmployeeDialog_OnDialogClose()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
            StateHasChanged();
        }


        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/employeeoverview", forceLoad: true);
        }


        protected async Task DeleteEmployee(int employeeId)
        {
            await EmployeeDataService.DeleteEmployee(employeeId);
            NavigateToOverview();
        }


    }
}
