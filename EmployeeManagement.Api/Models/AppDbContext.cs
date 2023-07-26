using System;
using EmployeeManagement.Shared;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Models
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}

		public DbSet<Employee> Employees { get; set; }
		public DbSet<Country> Countries { get; set; }
		public DbSet<JobCategory> JobCategories { get; set; }
		public DbSet<Office> Offices { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			//seed categories
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 1, Name = "Afghanistan" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 2, Name = "Albania" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 3, Name = "Algeria" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 4, Name = "Andorra" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 5, Name = "Angola" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 6, Name = "Antigua and Barbuda" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 7, Name = "Argentina" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 8, Name = "Armenia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 9, Name = "Australia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 10, Name = "Austria" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 11, Name = "Azerbaijan" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 12, Name = "Bahamas" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 13, Name = "Bahrain" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 14, Name = "Bangladesh" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 15, Name = "Barbados" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 16, Name = "Belarus" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 17, Name = "Belgium" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 18, Name = "Belize" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 19, Name = "Benin" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 20, Name = "Bhutan" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 21, Name = "Bolivia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 22, Name = "Bosnia and Herzegovina" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 23, Name = "Botswana" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 24, Name = "Brazil" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 25, Name = "Brunei" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 26, Name = "Bulgaria" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 27, Name = "Burkina Faso" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 28, Name = "Burundi" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 29, Name = "Cabo Verde" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 30, Name = "Cambodia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 31, Name = "Cameroon" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 32, Name = "Canada" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 33, Name = "Central African Republic" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 34, Name = "Chad" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 35, Name = "Chile" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 36, Name = "China" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 37, Name = "Colombia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 38, Name = "Comoros" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 39, Name = "Congo" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 40, Name = "Costa Rica" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 41, Name = "Croatia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 42, Name = "Cuba" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 43, Name = "Cyprus" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 44, Name = "Czechia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 45, Name = "Denmark" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 46, Name = "Djibouti" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 47, Name = "Dominica" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 48, Name = "Dominican Republic" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 49, Name = "Ecuador" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 50, Name = "Egypt" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 51, Name = "El Salvador" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 52, Name = "Equatorial Guinea" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 53, Name = "Eritrea" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 54, Name = "Estonia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 55, Name = "Eswatini" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 56, Name = "Ethiopia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 57, Name = "Fiji" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 58, Name = "Finland" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 59, Name = "France" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 60, Name = "Gabon" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 61, Name = "Gambia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 62, Name = "Georgia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 63, Name = "Germany" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 64, Name = "Ghana" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 65, Name = "Greece" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 66, Name = "Grenada" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 67, Name = "Guatemala" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 68, Name = "Guinea" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 69, Name = "Guinea-Bissau" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 70, Name = "Guyana" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 71, Name = "Haiti" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 72, Name = "Honduras" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 73, Name = "Hungary" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 74, Name = "Iceland" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 75, Name = "India" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 76, Name = "Indonesia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 77, Name = "Iran" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 78, Name = "Iraq" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 79, Name = "Ireland" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 80, Name = "Israel" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 81, Name = "Italy" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 82, Name = "Jamaica" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 83, Name = "Japan" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 84, Name = "Jordan" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 85, Name = "Kazakhstan" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 86, Name = "Kenya" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 87, Name = "Kiribati" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 88, Name = "Korea, North" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 89, Name = "Korea, South" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 90, Name = "Kosovo" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 91, Name = "Kuwait" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 92, Name = "Kyrgyzstan" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 93, Name = "Laos" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 94, Name = "Latvia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 95, Name = "Lebanon" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 96, Name = "Lesotho" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 97, Name = "Liberia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 98, Name = "Libya" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 99, Name = "Liechtenstein" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 100, Name = "Lithuania" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 101, Name = "Luxembourg" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 102, Name = "Madagascar" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 103, Name = "Malawi" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 104, Name = "Malaysia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 105, Name = "Maldives" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 106, Name = "Mali" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 107, Name = "Malta" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 108, Name = "Marshall Islands" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 109, Name = "Mauritania" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 110, Name = "Mauritius" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 111, Name = "Mexico" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 112, Name = "Micronesia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 113, Name = "Moldova" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 114, Name = "Monaco" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 115, Name = "Mongolia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 116, Name = "Montenegro" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 117, Name = "Morocco" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 118, Name = "Mozambique" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 119, Name = "Myanmar" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 120, Name = "Namibia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 121, Name = "Nauru" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 122, Name = "Nepal" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 123, Name = "Netherlands" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 124, Name = "New Zealand" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 125, Name = "Nicaragua" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 126, Name = "Niger" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 127, Name = "Nigeria" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 128, Name = "North Macedonia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 129, Name = "Norway" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 130, Name = "Oman" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 131, Name = "Pakistan" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 132, Name = "Palau" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 133, Name = "Panama" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 134, Name = "Papua New Guinea" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 135, Name = "Paraguay" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 136, Name = "Peru" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 137, Name = "Philippines" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 138, Name = "Poland" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 139, Name = "Portugal" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 140, Name = "Qatar" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 141, Name = "Romania" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 142, Name = "Russia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 143, Name = "Rwanda" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 144, Name = "Saint Kitts and Nevis" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 145, Name = "Saint Lucia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 146, Name = "Saint Vincent and the Grenadines" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 147, Name = "Samoa" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 148, Name = "San Marino" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 149, Name = "Sao Tome and Principe" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 150, Name = "Saudi Arabia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 151, Name = "Senegal" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 152, Name = "Serbia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 153, Name = "Seychelles" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 154, Name = "Sierra Leone" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 155, Name = "Singapore" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 156, Name = "Slovakia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 157, Name = "Slovenia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 158, Name = "Solomon Islands" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 159, Name = "Somalia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 160, Name = "South Africa" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 161, Name = "South Sudan" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 162, Name = "Spain" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 163, Name = "Sri Lanka" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 164, Name = "Sudan" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 165, Name = "Suriname" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 166, Name = "Sweden" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 167, Name = "Switzerland" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 168, Name = "Syria" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 169, Name = "Taiwan" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 170, Name = "Tajikistan" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 171, Name = "Tanzania" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 172, Name = "Thailand" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 173, Name = "Timor-Leste" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 174, Name = "Togo" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 175, Name = "Tonga" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 176, Name = "Trinidad and Tobago" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 177, Name = "Tunisia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 178, Name = "Turkey" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 179, Name = "Turkmenistan" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 180, Name = "Tuvalu" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 181, Name = "Uganda" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 182, Name = "Ukraine" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 183, Name = "United Arab Emirates" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 184, Name = "United Kingdom" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 185, Name = "United States of America" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 186, Name = "Uruguay" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 187, Name = "Uzbekistan" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 188, Name = "Vanuatu" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 189, Name = "Vatican City" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 190, Name = "Venezuela" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 191, Name = "Vietnam" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 192, Name = "Yemen" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 193, Name = "Zambia" });
			modelBuilder.Entity<Country>().HasData(new Country { CountryId = 194, Name = "Zimbabwe" });

			modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 1, JobCategoryName = "IT" });
			modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 2, JobCategoryName = "Administration" });
			modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 3, JobCategoryName = "Finance" });
			modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 4, JobCategoryName = "Human Resources" });
			modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 5, JobCategoryName = "Sales" });
			modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 6, JobCategoryName = "Marketing" });
			modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 7, JobCategoryName = "Quality Assurance" });
			modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 8, JobCategoryName = "Project Management" });
			modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 9, JobCategoryName = "Customer Support" });
			modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 10, JobCategoryName = "Facilities Management" });
			modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 11, JobCategoryName = "Security" });
			modelBuilder.Entity<JobCategory>().HasData(new JobCategory { JobCategoryId = 12, JobCategoryName = "Data Science" });

			modelBuilder.Entity<Office>().HasData(new Office { OfficeId = 1, OfficeName = "Company Headquarters - New York", OfficeLatitude = 40.74838914321791, OfficeLongitude = -73.98592191200781 });
			modelBuilder.Entity<Office>().HasData(new Office { OfficeId = 2, OfficeName = "Office 1 - Atlanta", OfficeLatitude = 33.73625266689321, OfficeLongitude = -84.40957768644884 });
			modelBuilder.Entity<Office>().HasData(new Office { OfficeId = 3, OfficeName = "Office 2 - London", OfficeLatitude = 51.508111031504846, OfficeLongitude = -0.12336713332934048 });
			modelBuilder.Entity<Office>().HasData(new Office { OfficeId = 4, OfficeName = "Office 4 - Lisbon", OfficeLatitude = 38.742361381016686, OfficeLongitude = -9.145258265913196 });
			modelBuilder.Entity<Office>().HasData(new Office { OfficeId = 5, OfficeName = "Remote Office", OfficeLatitude = 40.0000000000, OfficeLongitude = -40.0000000000,
			});

			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 1,
				CountryId = 185,
				MaritalStatus = MaritalStatus.Single,
				BirthDate = new DateTime(1984, 3, 18),
				City = "Atlanta",
				Email = "emily@gmail.com",
				FirstName = "Emily",
				LastName = "Davis",
				Gender = Gender.Female,
				PhoneNumber = "33669933221",
				Street = "Piedmont Avenue",
				Zip = "30305",
				JobCategoryId = 7,
				OfficeId = 2,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2020, 11, 5),
			});

			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 2,
				CountryId = 184,
				MaritalStatus = MaritalStatus.Married,
				BirthDate = new DateTime(1988, 7, 9),
				City = "London",
				Email = "michael@gmail.com",
				FirstName = "Michael",
				LastName = "Wilson",
				Gender = Gender.Male,
				PhoneNumber = "77665544331",
				Street = "Baker Street",
				Zip = "SW1X 7XL",
				JobCategoryId = 8,
				OfficeId = 3,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2019, 8, 20),
			});

			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 3,
				CountryId = 185,
				MaritalStatus = MaritalStatus.Single,
				BirthDate = new DateTime(1985, 4, 12),
				City = "New York",
				Email = "john@gmail.com",
				FirstName = "John",
				LastName = "Doe",
				Gender = Gender.Other,
				PhoneNumber = "33888809823",
				Street = "Broadway",
				Zip = "10001",
				JobCategoryId = 2,
				OfficeId = 1,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2020, 6, 15),
			});

			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 4,
				CountryId = 185,
				MaritalStatus = MaritalStatus.Married,
				BirthDate = new DateTime(1990, 8, 2),
				City = "Atlanta",
				Email = "jane@gmail.com",
				FirstName = "Jane",
				LastName = "Doe",
				Gender = Gender.Female,
				PhoneNumber = "33777709823",
				Street = "Peachtree Street",
				Zip = "30303",
				JobCategoryId = 3,
				OfficeId = 2,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2019, 4, 20),
			});

			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 5,
				CountryId = 184,
				MaritalStatus = MaritalStatus.Single,
				BirthDate = new DateTime(1982, 11, 5),
				City = "London",
				Email = "sarah@gmail.com",
				FirstName = "Sarah",
				LastName = "Johnson",
				Gender = Gender.Female,
				PhoneNumber = "44332210987",
				Street = "Oxford Street",
				Zip = "SW1A 1AA",
				JobCategoryId = 4,
				OfficeId = 3,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2018, 9, 1),
			});


			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 6,
				CountryId = 139,
				MaritalStatus = MaritalStatus.Single,
				BirthDate = new DateTime(1981, 6, 30),
				City = "Lisbon",
				Email = "peter@gmail.com",
				FirstName = "Peter",
				LastName = "Miller",
				Gender = Gender.Male,
				PhoneNumber = "55443322119",
				Street = "Rua Augusta",
				Zip = "1100",
				JobCategoryId = 5,
				OfficeId = 4,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2017, 3, 15),
			});

			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 7,
				CountryId = 185,
				MaritalStatus = MaritalStatus.Married,
				BirthDate = new DateTime(1992, 9, 22),
				City = "New York",
				Email = "david@gmail.com",
				FirstName = "David",
				LastName = "Brown",
				Gender = Gender.Other,
				PhoneNumber = "33221199008",
				Street = "5th Avenue",
				Zip = "10018",
				JobCategoryId = 6,
				OfficeId = 1,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2022, 2, 10),
			});

			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 8,
				CountryId = 185,
				MaritalStatus = MaritalStatus.Single,
				BirthDate = new DateTime(1989, 5, 21),
				City = "Los Angeles",
				Email = "alex@gmail.com",
				FirstName = "Alex",
				LastName = "Robinson",
				Gender = Gender.Male,
				PhoneNumber = "55443322119",
				Street = "Sunset Boulevard",
				Zip = "90028",
				JobCategoryId = 7,
				OfficeId = 5,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2021, 7, 1),
			});

			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 9,
				CountryId = 32,
				MaritalStatus = MaritalStatus.Single,
				BirthDate = new DateTime(1991, 2, 14),
				City = "Toronto",
				Email = "natalie@gmail.com",
				FirstName = "Natalie",
				LastName = "Lee",
				Gender = Gender.Female,
				PhoneNumber = "33445566778",
				Street = "Yonge Street",
				Zip = "M5E 1W7",
				JobCategoryId = 8,
				OfficeId = 5,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2021, 4, 10),
			});

			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 10,
				CountryId = 83,
				MaritalStatus = MaritalStatus.Single,
				BirthDate = new DateTime(1987, 9, 8),
				City = "Tokyo",
				Email = "hiroshi@gmail.com",
				FirstName = "Hiroshi",
				LastName = "Tanaka",
				Gender = Gender.Male,
				PhoneNumber = "33887766442",
				Street = "Ginza Street",
				Zip = "104-0061",
				JobCategoryId = 9,
				OfficeId = 5,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2021, 6, 20),
			});

			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 11,
				CountryId = 9,
				MaritalStatus = MaritalStatus.Married,
				BirthDate = new DateTime(1983, 11, 28),
				City = "Sydney",
				Email = "sophie@gmail.com",
				FirstName = "Sophie",
				LastName = "Williams",
				Gender = Gender.Female,
				PhoneNumber = "44665533442",
				Street = "George Street",
				Zip = "2000",
				JobCategoryId = 7,
				OfficeId = 5,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2021, 9, 15),
			});

			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 12,
				CountryId = 59,
				MaritalStatus = MaritalStatus.Single,
				BirthDate = new DateTime(1986, 7, 16),
				City = "Paris",
				Email = "luc@gmail.com",
				FirstName = "Luc",
				LastName = "Martin",
				Gender = Gender.Male,
				PhoneNumber = "33998877665",
				Street = "Champs-Élysées",
				Zip = "75008",
				JobCategoryId = 6,
				OfficeId = 5,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2021, 8, 10),
			});

			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 13,
				CountryId = 63,
				MaritalStatus = MaritalStatus.Married,
				BirthDate = new DateTime(1980, 4, 3),
				City = "Berlin",
				Email = "anna@gmail.com",
				FirstName = "Anna",
				LastName = "Schmidt",
				Gender = Gender.Female,
				PhoneNumber = "33557799001",
				Street = "Unter den Linden",
				Zip = "10117",
				JobCategoryId = 8,
				OfficeId = 5,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2021, 5, 5),
			});

			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 14,
				CountryId = 183,
				MaritalStatus = MaritalStatus.Single,
				BirthDate = new DateTime(1989, 1, 7),
				City = "Dubai",
				Email = "ali@gmail.com",
				FirstName = "Ali",
				LastName = "Khan",
				Gender = Gender.Male,
				PhoneNumber = "55443366221",
				Street = "Sheikh Zayed Road",
				Zip = "Dubai",
				JobCategoryId = 9,
				OfficeId = 5,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2021, 7, 20),
			});

			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 15,
				CountryId = 142,
				MaritalStatus = MaritalStatus.Married,
				BirthDate = new DateTime(1992, 6, 15),
				City = "Moscow",
				Email = "igor@gmail.com",
				FirstName = "Igor",
				LastName = "Sokolov",
				Gender = Gender.Male,
				PhoneNumber = "33221177888",
				Street = "Tverskaya Street",
				Zip = "125009",
				JobCategoryId = 7,
				OfficeId = 5,
				Comment = "Lorem Ipsum",
				ExitDate = null,
				JoinedDate = new DateTime(2021, 8, 25),
			});

		}
	}
}
