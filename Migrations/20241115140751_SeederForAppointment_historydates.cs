using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CitasClinica.Migrations
{
    /// <inheritdoc />
    public partial class SeederForAppointment_historydates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "id", "date_time", "doctor_id", "patient_id", "status" },
                values: new object[,]
                {
                    { 1, new DateTime(2033, 1, 14, 4, 32, 37, 792, DateTimeKind.Local).AddTicks(1053), 2, 1, "Scheduled" },
                    { 2, new DateTime(2053, 1, 22, 17, 59, 32, 719, DateTimeKind.Local).AddTicks(6989), 4, 4, "Cancelled" },
                    { 3, new DateTime(2032, 6, 7, 19, 22, 47, 415, DateTimeKind.Local).AddTicks(1033), 1, 3, "Cancelled" },
                    { 4, new DateTime(2051, 1, 10, 8, 21, 26, 892, DateTimeKind.Local).AddTicks(5002), 5, 5, "Cancelled" },
                    { 5, new DateTime(2031, 6, 22, 12, 24, 38, 431, DateTimeKind.Local).AddTicks(5896), 4, 3, "Completed" }
                });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date_time", "doctor_id" },
                values: new object[] { new DateTime(2026, 4, 18, 17, 34, 26, 636, DateTimeKind.Local).AddTicks(5371), 4 });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date_time", "doctor_id" },
                values: new object[] { new DateTime(2048, 2, 14, 14, 56, 44, 999, DateTimeKind.Local).AddTicks(1530), 4 });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "date_time", "doctor_id" },
                values: new object[] { new DateTime(2048, 10, 3, 19, 26, 17, 540, DateTimeKind.Local).AddTicks(2732), 3 });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "available", "date_time" },
                values: new object[] { false, new DateTime(2052, 12, 2, 11, 39, 16, 204, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "id",
                keyValue: 5,
                column: "date_time",
                value: new DateTime(2042, 3, 14, 16, 0, 58, 396, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email", "name", "phone", "specialty" },
                values: new object[] { "Orpha54@yahoo.com", "Xzavier Bruen", "293-650-1169 x49506", "District Applications Planner" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "email", "name", "phone", "specialty" },
                values: new object[] { "Myrtle.Dooley26@hotmail.com", "Marcellus Kozey", "373-257-5601", "International Applications Engineer" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "email", "name", "phone", "specialty" },
                values: new object[] { "Kellie.VonRueden@yahoo.com", "Wilma Morissette", "1-268-776-6463", "Investor Integration Analyst" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "email", "name", "phone", "specialty" },
                values: new object[] { "Mekhi20@gmail.com", "Isadore Kirlin", "399-462-5566", "Central Web Orchestrator" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "email", "name", "phone", "specialty" },
                values: new object[] { "Miguel95@gmail.com", "Harmony Gleason", "314.685.9171 x17203", "Principal Web Architect" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date_born", "email", "last_name", "name", "phone" },
                values: new object[] { new DateTime(1987, 6, 4, 19, 2, 14, 892, DateTimeKind.Local).AddTicks(9939), "Serena62@hotmail.com", "Upton", "Johnathon", "891.941.2410" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date_born", "email", "last_name", "name", "phone" },
                values: new object[] { new DateTime(2002, 4, 20, 23, 23, 1, 647, DateTimeKind.Local).AddTicks(8962), "Frieda.Trantow9@gmail.com", "Hansen", "Rickey", "869-736-9291 x766" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "date_born", "email", "last_name", "name", "phone" },
                values: new object[] { new DateTime(1979, 3, 11, 19, 23, 36, 625, DateTimeKind.Local).AddTicks(7097), "Trevor_Purdy@hotmail.com", "Breitenberg", "Eloy", "724.631.6191" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "date_born", "email", "last_name", "name", "phone" },
                values: new object[] { new DateTime(2003, 4, 19, 16, 14, 59, 450, DateTimeKind.Local).AddTicks(3063), "Marlee25@yahoo.com", "Nicolas", "Isaias", "1-232-361-8624 x2355" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "date_born", "email", "last_name", "name", "phone" },
                values: new object[] { new DateTime(2000, 1, 27, 21, 51, 54, 722, DateTimeKind.Local).AddTicks(9749), "Astrid_Herman@gmail.com", "Weissnat", "Brian", "1-244-945-2788 x171" });

            migrationBuilder.InsertData(
                table: "HistoryDates",
                columns: new[] { "id", "appointment_id", "date_time", "reason" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 15, 0, 18, 31, 34, DateTimeKind.Local).AddTicks(944), "Praesentium et qui architecto corporis amet nobis repellat ducimus." },
                    { 2, 1, new DateTime(2024, 10, 12, 17, 49, 48, 294, DateTimeKind.Local).AddTicks(6921), "Non ut fuga est." },
                    { 3, 2, new DateTime(2024, 1, 2, 19, 37, 48, 214, DateTimeKind.Local).AddTicks(4830), "Nemo omnis harum eum aut esse." },
                    { 4, 1, new DateTime(2024, 6, 25, 23, 53, 51, 276, DateTimeKind.Local).AddTicks(7018), "Qui dolores accusantium et voluptatem repudiandae blanditiis." },
                    { 5, 2, new DateTime(2024, 4, 28, 11, 25, 52, 867, DateTimeKind.Local).AddTicks(2738), "Suscipit suscipit quia ad numquam delectus facilis numquam expedita rerum." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HistoryDates",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HistoryDates",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HistoryDates",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HistoryDates",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HistoryDates",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date_time", "doctor_id" },
                values: new object[] { new DateTime(2047, 10, 31, 5, 26, 7, 401, DateTimeKind.Local).AddTicks(9451), 3 });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date_time", "doctor_id" },
                values: new object[] { new DateTime(2041, 12, 2, 18, 2, 59, 473, DateTimeKind.Local).AddTicks(8450), 5 });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "date_time", "doctor_id" },
                values: new object[] { new DateTime(2046, 6, 29, 3, 0, 26, 643, DateTimeKind.Local).AddTicks(2837), 2 });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "available", "date_time" },
                values: new object[] { true, new DateTime(2033, 11, 25, 6, 19, 42, 239, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "id",
                keyValue: 5,
                column: "date_time",
                value: new DateTime(2054, 4, 23, 19, 58, 39, 834, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email", "name", "phone", "specialty" },
                values: new object[] { "Corene_Hettinger80@hotmail.com", "Caesar Hilll", "879.263.2834 x00431", "National Marketing Director" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "email", "name", "phone", "specialty" },
                values: new object[] { "Nedra.Schowalter62@gmail.com", "Ella Hahn", "1-290-448-2415 x5700", "Corporate Identity Orchestrator" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "email", "name", "phone", "specialty" },
                values: new object[] { "Norval.Smitham@gmail.com", "Buster Pfeffer", "1-542-680-4179", "Legacy Program Supervisor" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "email", "name", "phone", "specialty" },
                values: new object[] { "Gaston_Raynor@gmail.com", "Wayne Balistreri", "1-761-226-8404", "Principal Implementation Planner" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "email", "name", "phone", "specialty" },
                values: new object[] { "Maryse.Walsh@hotmail.com", "Carter O'Kon", "(353) 463-6386 x34451", "Regional Intranet Specialist" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "date_born", "email", "last_name", "name", "phone" },
                values: new object[] { new DateTime(1996, 7, 22, 19, 50, 42, 583, DateTimeKind.Local).AddTicks(6007), "Rodolfo46@hotmail.com", "Reichert", "Elise", "1-775-566-2438 x9641" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "date_born", "email", "last_name", "name", "phone" },
                values: new object[] { new DateTime(1977, 3, 27, 0, 40, 46, 962, DateTimeKind.Local).AddTicks(4045), "Emelia22@hotmail.com", "Torphy", "Lyric", "1-901-377-7401 x23218" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "date_born", "email", "last_name", "name", "phone" },
                values: new object[] { new DateTime(1977, 9, 15, 18, 11, 50, 347, DateTimeKind.Local).AddTicks(1792), "Janis_West94@gmail.com", "DuBuque", "Deontae", "480.838.1696 x6185" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "date_born", "email", "last_name", "name", "phone" },
                values: new object[] { new DateTime(1985, 2, 13, 21, 32, 23, 634, DateTimeKind.Local).AddTicks(6414), "Kenyatta10@yahoo.com", "Waelchi", "Mackenzie", "603.512.1464 x33156" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "date_born", "email", "last_name", "name", "phone" },
                values: new object[] { new DateTime(2001, 1, 6, 18, 9, 47, 350, DateTimeKind.Local).AddTicks(7576), "Savannah37@hotmail.com", "Sawayn", "Mckayla", "(515) 624-1939" });
        }
    }
}
