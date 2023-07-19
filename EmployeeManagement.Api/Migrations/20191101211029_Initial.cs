using System;
using System.Reflection.Emit;
using EmployeeManagement.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
	public partial class Initial : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Countries",
				columns: table => new
				{
					CountryId = table.Column<int>(nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Countries", x => x.CountryId);
				});

			migrationBuilder.CreateTable(
				name: "JobCategories",
				columns: table => new
				{
					JobCategoryId = table.Column<int>(nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					JobCategoryName = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_JobCategories", x => x.JobCategoryId);
				});

			migrationBuilder.CreateTable(
				name: "Offices",
				columns: table => new
				{
					OfficeId = table.Column<int>(nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					OfficeName = table.Column<string>(nullable: true),
					OfficeLatitude = table.Column<double>(nullable: false),
					OfficeLongitude = table.Column<double>(nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Offices", x => x.OfficeId);
				});

			migrationBuilder.CreateTable(
				name: "Employees",
				columns: table => new
				{
					EmployeeId = table.Column<int>(nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					FirstName = table.Column<string>(nullable: true),
					LastName = table.Column<string>(nullable: true),
					BirthDate = table.Column<DateTime>(nullable: false),
					Email = table.Column<string>(nullable: true),
					Street = table.Column<string>(nullable: true),
					Zip = table.Column<string>(nullable: true),
					City = table.Column<string>(nullable: true),
					CountryId = table.Column<int>(nullable: false),
					PhoneNumber = table.Column<string>(nullable: true),
					MaritalStatus = table.Column<int>(nullable: false),
					Gender = table.Column<int>(nullable: false),
					Comment = table.Column<string>(nullable: true),
					JoinedDate = table.Column<DateTime>(nullable: true),
					ExitDate = table.Column<DateTime>(nullable: true),
					JobCategoryId = table.Column<int>(nullable: false),
					OfficeId = table.Column<int>(nullable: false),
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Employees", x => x.EmployeeId);
					table.ForeignKey(
						name: "FK_Employees_Countries_CountryId",
						column: x => x.CountryId,
						principalTable: "Countries",
						principalColumn: "CountryId",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Employees_JobCategories_JobCategoryId",
						column: x => x.JobCategoryId,
						principalTable: "JobCategories",
						principalColumn: "JobCategoryId",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Employees_Offices_OfficeId",
						column: x => x.OfficeId,
						principalTable: "Offices",
						principalColumn: "OfficeId",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.InsertData(
				table: "Countries",
				columns: new[] { "CountryId", "Name" },
				values: new object[,]
				{
					{ 1, "Afghanistan" },
					{ 2, "Albania" },
					{ 3, "Algeria" },
					{ 4, "Andorra" },
					{ 5, "Angola" },
					{ 6, "Antigua and Barbuda" },
					{ 7, "Argentina" },
					{ 8, "Armenia" },
					{ 9, "Australia" },
					{ 10, "Austria" },
					{ 11, "Azerbaijan" },
					{ 12, "Bahamas" },
					{ 13, "Bahrain" },
					{ 14, "Bangladesh" },
					{ 15, "Barbados" },
					{ 16, "Belarus" },
					{ 17, "Belgium" },
					{ 18, "Belize" },
					{ 19, "Benin" },
					{ 20, "Bhutan" },
					{ 21, "Bolivia" },
					{ 22, "Bosnia and Herzegovina" },
					{ 23, "Botswana" },
					{ 24, "Brazil" },
					{ 25, "Brunei" },
					{ 26, "Bulgaria" },
					{ 27, "Burkina Faso" },
					{ 28, "Burundi" },
					{ 29, "Cabo Verde" },
					{ 30, "Cambodia" },
					{ 31, "Cameroon" },
					{ 32, "Canada" },
					{ 33, "Central African Republic" },
					{ 34, "Chad" },
					{ 35, "Chile" },
					{ 36, "China" },
					{ 37, "Colombia" },
					{ 38, "Comoros" },
					{ 39, "Congo" },
					{ 40, "Costa Rica" },
					{ 41, "Croatia" },
					{ 42, "Cuba" },
					{ 43, "Cyprus" },
					{ 44, "Czechia" },
					{ 45, "Denmark" },
					{ 46, "Djibouti" },
					{ 47, "Dominica" },
					{ 48, "Dominican Republic" },
					{ 49, "Ecuador" },
					{ 50, "Egypt" },
					{ 51, "El Salvador" },
					{ 52, "Equatorial Guinea" },
					{ 53, "Eritrea" },
					{ 54, "Estonia" },
					{ 55, "Eswatini" },
					{ 56, "Ethiopia" },
					{ 57, "Fiji" },
					{ 58, "Finland" },
					{ 59, "France" },
					{ 60, "Gabon" },
					{ 61, "Gambia" },
					{ 62, "Georgia" },
					{ 63, "Germany" },
					{ 64, "Ghana" },
					{ 65, "Greece" },
					{ 66, "Grenada" },
					{ 67, "Guatemala" },
					{ 68, "Guinea" },
					{ 69, "Guinea-Bissau" },
					{ 70, "Guyana" },
					{ 71, "Haiti" },
					{ 72, "Honduras" },
					{ 73, "Hungary" },
					{ 74, "Iceland" },
					{ 75, "India" },
					{ 76, "Indonesia" },
					{ 77, "Iran" },
					{ 78, "Iraq" },
					{ 79, "Ireland" },
					{ 80, "Israel" },
					{ 81, "Italy" },
					{ 82, "Jamaica" },
					{ 83, "Japan" },
					{ 84, "Jordan" },
					{ 85, "Kazakhstan" },
					{ 86, "Kenya" },
					{ 87, "Kiribati" },
					{ 88, "Korea, North" },
					{ 89, "Korea, South" },
					{ 90, "Kosovo" },
					{ 91, "Kuwait" },
					{ 92, "Kyrgyzstan" },
					{ 93, "Laos" },
					{ 94, "Latvia" },
					{ 95, "Lebanon" },
					{ 96, "Lesotho" },
					{ 97, "Liberia" },
					{ 98, "Libya" },
					{ 99, "Liechtenstein" },
					{ 100, "Lithuania" },
					{ 101, "Luxembourg" },
					{ 102, "Madagascar" },
					{ 103, "Malawi" },
					{ 104, "Malaysia" },
					{ 105, "Maldives" },
					{ 106, "Mali" },
					{ 107, "Malta" },
					{ 108, "Marshall Islands" },
					{ 109, "Mauritania" },
					{ 110, "Mauritius" },
					{ 111, "Mexico" },
					{ 112, "Micronesia" },
					{ 113, "Moldova" },
					{ 114, "Monaco" },
					{ 115, "Mongolia" },
					{ 116, "Montenegro" },
					{ 117, "Morocco" },
					{ 118, "Mozambique" },
					{ 119, "Myanmar" },
					{ 120, "Namibia" },
					{ 121, "Nauru" },
					{ 122, "Nepal" },
					{ 123, "Netherlands" },
					{ 124, "New Zealand" },
					{ 125, "Nicaragua" },
					{ 126, "Niger" },
					{ 127, "Nigeria" },
					{ 128, "North Macedonia" },
					{ 129, "Norway" },
					{ 130, "Oman" },
					{ 131, "Pakistan" },
					{ 132, "Palau" },
					{ 133, "Panama" },
					{ 134, "Papua New Guinea" },
					{ 135, "Paraguay" },
					{ 136, "Peru" },
					{ 137, "Philippines" },
					{ 138, "Poland" },
					{ 139, "Portugal" },
					{ 140, "Qatar" },
					{ 141, "Romania" },
					{ 142, "Russia" },
					{ 143, "Rwanda" },
					{ 144, "Saint Kitts and Nevis" },
					{ 145, "Saint Lucia" },
					{ 146, "Saint Vincent and the Grenadines" },
					{ 147, "Samoa" },
					{ 148, "San Marino" },
					{ 149, "Sao Tome and Principe" },
					{ 150, "Saudi Arabia" },
					{ 151, "Senegal" },
					{ 152, "Serbia" },
					{ 153, "Seychelles" },
					{ 154, "Sierra Leone" },
					{ 155, "Singapore" },
					{ 156, "Slovakia" },
					{ 157, "Slovenia" },
					{ 158, "Solomon Islands" },
					{ 159, "Somalia" },
					{ 160, "South Africa" },
					{ 161, "South Sudan" },
					{ 162, "Spain" },
					{ 163, "Sri Lanka" },
					{ 164, "Sudan" },
					{ 165, "Suriname" },
					{ 166, "Sweden" },
					{ 167, "Switzerland" },
					{ 168, "Syria" },
					{ 169, "Taiwan" },
					{ 170, "Tajikistan" },
					{ 171, "Tanzania" },
					{ 172, "Thailand" },
					{ 173, "Timor-Leste" },
					{ 174, "Togo" },
					{ 175, "Tonga" },
					{ 176, "Trinidad and Tobago" },
					{ 177, "Tunisia" },
					{ 178, "Turkey" },
					{ 179, "Turkmenistan" },
					{ 180, "Tuvalu" },
					{ 181, "Uganda" },
					{ 182, "Ukraine" },
					{ 183, "United Arab Emirates" },
					{ 184, "United Kingdom" },
					{ 185, "United States of America" },
					{ 186, "Uruguay" },
					{ 187, "Uzbekistan" },
					{ 188, "Vanuatu" },
					{ 189, "Vatican City" },
					{ 190, "Venezuela" },
					{ 191, "Vietnam" },
					{ 192, "Yemen" },
					{ 193, "Zambia" },
					{ 194, "Zimbabwe" }
				});


			migrationBuilder.InsertData(
				table: "JobCategories",
				columns: new[] { "JobCategoryId", "JobCategoryName" },
				values: new object[,]
				{
					{ 1, "IT" },
					{ 2, "Administration" },
					{ 3, "Finance" },
					{ 4, "Human Resources" },
					{ 5, "Sales" },
					{ 6, "Marketing" },
					{ 7, "Quality Assurance" },
					{ 8, "Project Management" },
					{ 9, "Customer Support" },
					{ 10, "Facilities Management" },
					{ 11, "Security" },
					{ 12, "Data Science" }
				});

			migrationBuilder.InsertData(
				table: "Offices",
				columns: new[] { "OfficeId", "OfficeName", "OfficeLatitude", "OfficeLongitude" },
				values: new object[,]
				{
					{ 1, "Company Headquarters - New York", 40.74838914321791, -73.98592191200781 },
					{ 2, "Office 1 - Atlanta", 33.73625266689321, -84.40957768644884 },
					{ 3, "Office 2 - London", 51.508111031504846, -0.12336713332934048 },
					{ 4, "Office 4 - Lisbon", 38.742361381016686, -9.145258265913196 },
					{ 5, "Remote Office", 40.0000000000, -40.0000000000 }
				});

			migrationBuilder.InsertData(
				table: "Employees",
				columns: new[] { "EmployeeId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "JobCategoryId", "OfficeId", "JoinedDate", "LastName", "MaritalStatus", "PhoneNumber", "Street", "Zip" },
				values: new object[] { 1, new DateTime(1984, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlanta", "Lorem Ipsum", 185, "emily@gmail.com", null, "Emily", 1, 7, 2, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Davis", 0, "33669933221", "Piedmont Avenue", "30305" });
			
			migrationBuilder.InsertData(
				table: "Employees",
				columns: new[] { "EmployeeId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "JobCategoryId", "OfficeId", "JoinedDate", "LastName", "MaritalStatus", "PhoneNumber", "Street", "Zip" },
				values: new object[] { 2, new DateTime(1988, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "London", "Lorem Ipsum", 184, "michael@gmail.com", null, "Michael", 0, 8, 3, new DateTime(2019, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilson", 1, "77665544331", "Baker Street", "SW1X 7XL" });

			migrationBuilder.InsertData(
				table: "Employees",
				columns: new[] { "EmployeeId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "JobCategoryId", "OfficeId", "JoinedDate", "LastName", "MaritalStatus", "PhoneNumber", "Street", "Zip" },
				values: new object[] { 3, new DateTime(1985, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York", "Lorem Ipsum", 185, "john@gmail.com", null, "John", 2, 2, 1, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doe", 0, "33888809823", "Broadway", "10001" });

			migrationBuilder.InsertData(
				table: "Employees",
				columns: new[] { "EmployeeId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "JobCategoryId", "OfficeId", "JoinedDate", "LastName", "MaritalStatus", "PhoneNumber", "Street", "Zip" },
				values: new object[] { 4, new DateTime(1990, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlanta", "Lorem Ipsum", 185, "jane@gmail.com", null, "Jane", 1, 3, 2, new DateTime(2019, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doe", 1, "33777709823", "Peachtree Street", "30303" });

			migrationBuilder.InsertData(
				table: "Employees",
				columns: new[] { "EmployeeId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "JobCategoryId", "OfficeId", "JoinedDate", "LastName", "MaritalStatus", "PhoneNumber", "Street", "Zip" },
				values: new object[] { 5, new DateTime(1982, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "London", "Lorem Ipsum", 184, "sarah@gmail.com", null, "Sarah", 1, 4, 3, new DateTime(2018, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnson", 0, "44332210987", "Oxford Street", "SW1A 1AA" });

			migrationBuilder.InsertData(
				table: "Employees",
				columns: new[] { "EmployeeId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "JobCategoryId", "OfficeId", "JoinedDate", "LastName", "MaritalStatus", "PhoneNumber", "Street", "Zip" },
				values: new object[] { 6, new DateTime(1981, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lisbon", "Lorem Ipsum", 139, "peter@gmail.com", null, "Peter", 0, 5, 4, new DateTime(2017, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miller", 0, "55443322119", "Rua Augusta", "1100" });
			
			migrationBuilder.InsertData(
				table: "Employees",
				columns: new[] { "EmployeeId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "JobCategoryId", "OfficeId", "JoinedDate", "LastName", "MaritalStatus", "PhoneNumber", "Street", "Zip" },
				values: new object[] { 7, new DateTime(1992, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York", "Lorem Ipsum", 185, "david@gmail.com", null, "David", 2, 6, 1, new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brown", 1, "33221199008", "5th Avenue", "10018" });

			migrationBuilder.InsertData(
				table: "Employees",
				columns: new[] { "EmployeeId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "JobCategoryId", "OfficeId", "JoinedDate", "LastName", "MaritalStatus", "PhoneNumber", "Street", "Zip" },
				values: new object[] { 8, new DateTime(1989, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los Angeles", "Lorem Ipsum", 185, "alex@gmail.com", null, "Alex", 0, 7, 5, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robinson", 0, "55443322119", "Sunset Boulevard", "90028" });

			migrationBuilder.InsertData(
				table: "Employees",
				columns: new[] { "EmployeeId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "JobCategoryId", "OfficeId", "JoinedDate", "LastName", "MaritalStatus", "PhoneNumber", "Street", "Zip" },
				values: new object[] { 9, new DateTime(1991, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toronto", "Lorem Ipsum", 32, "natalie@gmail.com", null, "Natalie", 1, 8, 5, new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", 0, "33445566778", "Yonge Street", "M5E 1W7" });

			migrationBuilder.InsertData(
				table: "Employees",
				columns: new[] { "EmployeeId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "JobCategoryId", "OfficeId", "JoinedDate", "LastName", "MaritalStatus", "PhoneNumber", "Street", "Zip" },
				values: new object[] { 10, new DateTime(1987, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tokyo", "Lorem Ipsum", 83, "hiroshi@gmail.com", null, "Hiroshi", 0, 9, 5, new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanaka", 0, "33887766442", "Ginza Street", "104-0061" });

			migrationBuilder.InsertData(
				table: "Employees",
				columns: new[] { "EmployeeId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "JobCategoryId", "OfficeId", "JoinedDate", "LastName", "MaritalStatus", "PhoneNumber", "Street", "Zip" },
				values: new object[] { 11, new DateTime(1983, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sydney", "Lorem Ipsum", 9, "sophie@gmail.com", null, "Sophie", 1, 7, 5, new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Williams", 1, "44665533442", "George Street", "2000" });
			
			migrationBuilder.InsertData(
				table: "Employees",
				columns: new[] { "EmployeeId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "JobCategoryId", "OfficeId", "JoinedDate", "LastName", "MaritalStatus", "PhoneNumber", "Street", "Zip" },
				values: new object[] { 12, new DateTime(1986, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paris", "Lorem Ipsum", 59, "luc@gmail.com", null, "Luc", 0, 6, 5, new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin", 0, "33998877665", "Champs-Élysées", "75008" });
			
			migrationBuilder.InsertData(
				table: "Employees",
				columns: new[] { "EmployeeId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "JobCategoryId", "OfficeId", "JoinedDate", "LastName", "MaritalStatus", "PhoneNumber", "Street", "Zip" },
				values: new object[] { 13, new DateTime(1980, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Berlin", "Lorem Ipsum", 63, "anna@gmail.com", null, "Anna", 1, 8, 5, new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schmidt", 1, "33557799001", "Unter den Linden", "10117" });

			migrationBuilder.InsertData(
				table: "Employees",
				columns: new[] { "EmployeeId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "JobCategoryId", "OfficeId", "JoinedDate", "LastName", "MaritalStatus", "PhoneNumber", "Street", "Zip" },
				values: new object[] { 14, new DateTime(1989, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dubai", "Lorem Ipsum", 183, "ali@gmail.com", null, "Ali", 0, 9, 5, new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khan", 1, "55443366221", "Sheikh Zayed Road", "Dubai" });

			migrationBuilder.InsertData(
				table: "Employees",
				columns: new[] { "EmployeeId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "JobCategoryId", "OfficeId", "JoinedDate", "LastName", "MaritalStatus", "PhoneNumber", "Street", "Zip" },
				values: new object[] { 15, new DateTime(1992, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moscow", "Lorem Ipsum", 142, "igor@gmail.com", null, "Igor", 0, 7, 5, new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sokolov", 1, "33221177888", "Tverskaya Street", "125009" });

			migrationBuilder.CreateIndex(
				name: "IX_Employees_CountryId",
				table: "Employees",
				column: "CountryId");

			migrationBuilder.CreateIndex(
				name: "IX_Employees_JobCategoryId",
				table: "Employees",
				column: "JobCategoryId");

			migrationBuilder.CreateIndex(
				name: "IX_Employees_OfficeId",
				table: "Employees",
				column: "OfficeId");
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Employees");

			migrationBuilder.DropTable(
				name: "Countries");

			migrationBuilder.DropTable(
				name: "JobCategories");

			migrationBuilder.DropTable(
				name: "Offices");
		}
	}
}
