using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CitasClinica.Migrations
{
    /// <inheritdoc />
    public partial class SeederForAdmin_avail_doctor_patient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Administrators",
                columns: new[] { "id", "email", "password" },
                values: new object[] { 1, "admin@myapp.com", "Admin123" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "id", "email", "name", "phone", "specialty" },
                values: new object[,]
                {
                    { 1, "Corene_Hettinger80@hotmail.com", "Caesar Hilll", "879.263.2834 x00431", "National Marketing Director" },
                    { 2, "Nedra.Schowalter62@gmail.com", "Ella Hahn", "1-290-448-2415 x5700", "Corporate Identity Orchestrator" },
                    { 3, "Norval.Smitham@gmail.com", "Buster Pfeffer", "1-542-680-4179", "Legacy Program Supervisor" },
                    { 4, "Gaston_Raynor@gmail.com", "Wayne Balistreri", "1-761-226-8404", "Principal Implementation Planner" },
                    { 5, "Maryse.Walsh@hotmail.com", "Carter O'Kon", "(353) 463-6386 x34451", "Regional Intranet Specialist" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "id", "date_born", "email", "last_name", "name", "phone" },
                values: new object[,]
                {
                    { 1, new DateTime(1996, 7, 22, 19, 50, 42, 583, DateTimeKind.Local).AddTicks(6007), "Rodolfo46@hotmail.com", "Reichert", "Elise", "1-775-566-2438 x9641" },
                    { 2, new DateTime(1977, 3, 27, 0, 40, 46, 962, DateTimeKind.Local).AddTicks(4045), "Emelia22@hotmail.com", "Torphy", "Lyric", "1-901-377-7401 x23218" },
                    { 3, new DateTime(1977, 9, 15, 18, 11, 50, 347, DateTimeKind.Local).AddTicks(1792), "Janis_West94@gmail.com", "DuBuque", "Deontae", "480.838.1696 x6185" },
                    { 4, new DateTime(1985, 2, 13, 21, 32, 23, 634, DateTimeKind.Local).AddTicks(6414), "Kenyatta10@yahoo.com", "Waelchi", "Mackenzie", "603.512.1464 x33156" },
                    { 5, new DateTime(2001, 1, 6, 18, 9, 47, 350, DateTimeKind.Local).AddTicks(7576), "Savannah37@hotmail.com", "Sawayn", "Mckayla", "(515) 624-1939" }
                });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "id", "available", "date_time", "doctor_id" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2047, 10, 31, 5, 26, 7, 401, DateTimeKind.Local).AddTicks(9451), 3 },
                    { 2, false, new DateTime(2041, 12, 2, 18, 2, 59, 473, DateTimeKind.Local).AddTicks(8450), 5 },
                    { 3, true, new DateTime(2046, 6, 29, 3, 0, 26, 643, DateTimeKind.Local).AddTicks(2837), 2 },
                    { 4, true, new DateTime(2033, 11, 25, 6, 19, 42, 239, DateTimeKind.Local).AddTicks(2396), 5 },
                    { 5, false, new DateTime(2054, 4, 23, 19, 58, 39, 834, DateTimeKind.Local).AddTicks(2384), 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Administrators",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
