﻿// <auto-generated />
using System;
using CitasClinica.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CitasClinica.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241115135414_SeederForAdmin_avail_doctor_patient")]
    partial class SeederForAdmin_avail_doctor_patient
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("CitasClinica.Models.Administrator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("Administrators");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@myapp.com",
                            Password = "Admin123"
                        });
                });

            modelBuilder.Entity("CitasClinica.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date_time");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("doctor_id");

                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("patient_id");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("CitasClinica.Models.Availability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Available")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("available");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date_time");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("doctor_id");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Availabilities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Available = true,
                            DateTime = new DateTime(2047, 10, 31, 5, 26, 7, 401, DateTimeKind.Local).AddTicks(9451),
                            DoctorId = 3
                        },
                        new
                        {
                            Id = 2,
                            Available = false,
                            DateTime = new DateTime(2041, 12, 2, 18, 2, 59, 473, DateTimeKind.Local).AddTicks(8450),
                            DoctorId = 5
                        },
                        new
                        {
                            Id = 3,
                            Available = true,
                            DateTime = new DateTime(2046, 6, 29, 3, 0, 26, 643, DateTimeKind.Local).AddTicks(2837),
                            DoctorId = 2
                        },
                        new
                        {
                            Id = 4,
                            Available = true,
                            DateTime = new DateTime(2033, 11, 25, 6, 19, 42, 239, DateTimeKind.Local).AddTicks(2396),
                            DoctorId = 5
                        },
                        new
                        {
                            Id = 5,
                            Available = false,
                            DateTime = new DateTime(2054, 4, 23, 19, 58, 39, 834, DateTimeKind.Local).AddTicks(2384),
                            DoctorId = 3
                        });
                });

            modelBuilder.Entity("CitasClinica.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("phone");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("specialty");

                    b.HasKey("Id");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Corene_Hettinger80@hotmail.com",
                            Name = "Caesar Hilll",
                            Phone = "879.263.2834 x00431",
                            Specialty = "National Marketing Director"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Nedra.Schowalter62@gmail.com",
                            Name = "Ella Hahn",
                            Phone = "1-290-448-2415 x5700",
                            Specialty = "Corporate Identity Orchestrator"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Norval.Smitham@gmail.com",
                            Name = "Buster Pfeffer",
                            Phone = "1-542-680-4179",
                            Specialty = "Legacy Program Supervisor"
                        },
                        new
                        {
                            Id = 4,
                            Email = "Gaston_Raynor@gmail.com",
                            Name = "Wayne Balistreri",
                            Phone = "1-761-226-8404",
                            Specialty = "Principal Implementation Planner"
                        },
                        new
                        {
                            Id = 5,
                            Email = "Maryse.Walsh@hotmail.com",
                            Name = "Carter O'Kon",
                            Phone = "(353) 463-6386 x34451",
                            Specialty = "Regional Intranet Specialist"
                        });
                });

            modelBuilder.Entity("CitasClinica.Models.HistoryDating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int")
                        .HasColumnName("appointment_id");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date_time");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("reason");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.ToTable("HistoryDates");
                });

            modelBuilder.Entity("CitasClinica.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateBorn")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date_born");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("last_name");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("phone");

                    b.HasKey("Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateBorn = new DateTime(1996, 7, 22, 19, 50, 42, 583, DateTimeKind.Local).AddTicks(6007),
                            Email = "Rodolfo46@hotmail.com",
                            LastName = "Reichert",
                            Name = "Elise",
                            Phone = "1-775-566-2438 x9641"
                        },
                        new
                        {
                            Id = 2,
                            DateBorn = new DateTime(1977, 3, 27, 0, 40, 46, 962, DateTimeKind.Local).AddTicks(4045),
                            Email = "Emelia22@hotmail.com",
                            LastName = "Torphy",
                            Name = "Lyric",
                            Phone = "1-901-377-7401 x23218"
                        },
                        new
                        {
                            Id = 3,
                            DateBorn = new DateTime(1977, 9, 15, 18, 11, 50, 347, DateTimeKind.Local).AddTicks(1792),
                            Email = "Janis_West94@gmail.com",
                            LastName = "DuBuque",
                            Name = "Deontae",
                            Phone = "480.838.1696 x6185"
                        },
                        new
                        {
                            Id = 4,
                            DateBorn = new DateTime(1985, 2, 13, 21, 32, 23, 634, DateTimeKind.Local).AddTicks(6414),
                            Email = "Kenyatta10@yahoo.com",
                            LastName = "Waelchi",
                            Name = "Mackenzie",
                            Phone = "603.512.1464 x33156"
                        },
                        new
                        {
                            Id = 5,
                            DateBorn = new DateTime(2001, 1, 6, 18, 9, 47, 350, DateTimeKind.Local).AddTicks(7576),
                            Email = "Savannah37@hotmail.com",
                            LastName = "Sawayn",
                            Name = "Mckayla",
                            Phone = "(515) 624-1939"
                        });
                });

            modelBuilder.Entity("CitasClinica.Models.Appointment", b =>
                {
                    b.HasOne("CitasClinica.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CitasClinica.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("CitasClinica.Models.Availability", b =>
                {
                    b.HasOne("CitasClinica.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("CitasClinica.Models.HistoryDating", b =>
                {
                    b.HasOne("CitasClinica.Models.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");
                });
#pragma warning restore 612, 618
        }
    }
}
