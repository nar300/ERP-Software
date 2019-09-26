﻿// <auto-generated />
using System;
using ErpBackend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ErpBackend.Migrations
{
    [DbContext(typeof(ErpDbContext))]
    [Migration("20190926100320_leave")]
    partial class leave
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ErpBackend.Models.Attendance", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<int>("EmployeeId");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("ErpBackend.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .IsRequired();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("ErpBackend.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<DateTime>("CreatedTime");

                    b.Property<DateTime>("DateofBirth");

                    b.Property<DateTime>("DateofJoin");

                    b.Property<string>("Education")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("EmployeeType")
                        .IsRequired();

                    b.Property<string>("Experience")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("HomeAddress")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("MaritalStatus")
                        .IsRequired();

                    b.Property<string>("ModeofRecruitment")
                        .IsRequired();

                    b.Property<string>("NiNumber")
                        .IsRequired();

                    b.Property<int>("PhoneNumber");

                    b.Property<string>("PostCode")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("Town")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("ErpBackend.Models.Leave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("LeaveFromDate");

                    b.Property<DateTime>("LeaveToDate");

                    b.Property<string>("LeaveType")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Leave");
                });

            modelBuilder.Entity("ErpBackend.Models.Attendance", b =>
                {
                    b.HasOne("ErpBackend.Models.Employee", "Employee")
                        .WithMany("Attendances")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ErpBackend.Models.Leave", b =>
                {
                    b.HasOne("ErpBackend.Models.Employee", "Employee")
                        .WithMany("Leaves")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
