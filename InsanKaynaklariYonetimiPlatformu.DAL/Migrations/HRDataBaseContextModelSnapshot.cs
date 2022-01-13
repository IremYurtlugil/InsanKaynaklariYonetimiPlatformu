﻿// <auto-generated />
using System;
using InsanKaynaklariYonetimiPlatformu.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InsanKaynaklariYonetimiPlatformu.DAL.Migrations
{
    [DbContext(typeof(HRDataBaseContext))]
    partial class HRDataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Adminler");
                });

            modelBuilder.Entity("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Yorumlar");
                });

            modelBuilder.Entity("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailExtension")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("Şirketler");
                });

            modelBuilder.Entity("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Surname")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Manager", b =>
                {
                    b.Property<int>("ManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusType")
                        .HasColumnType("int");

                    b.HasKey("ManagerId");

                    b.HasIndex("AdminId");

                    b.HasIndex("CompanyId")
                        .IsUnique();

                    b.ToTable("Yöneticiler");
                });

            modelBuilder.Entity("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Membership", b =>
                {
                    b.Property<int>("MembershipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("MembershipType")
                        .HasColumnType("int");

                    b.HasKey("MembershipId");

                    b.HasIndex("CompanyId")
                        .IsUnique();

                    b.ToTable("ÜyelikTürleri");
                });

            modelBuilder.Entity("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FinishDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.Property<int>("PermissionType")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PermissionId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ManagerId");

                    b.ToTable("İzinler");
                });

            modelBuilder.Entity("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Comment", b =>
                {
                    b.HasOne("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Employee", b =>
                {
                    b.HasOne("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Company", null)
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId");

                    b.HasOne("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Manager", "Manager")
                        .WithMany("Employees")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Manager", b =>
                {
                    b.HasOne("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Admin", "Admin")
                        .WithMany("Managers")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Company", "Company")
                        .WithOne("Manager")
                        .HasForeignKey("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Manager", "CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Membership", b =>
                {
                    b.HasOne("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Company", "Company")
                        .WithOne("Membership")
                        .HasForeignKey("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Membership", "CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Permission", b =>
                {
                    b.HasOne("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Employee", null)
                        .WithMany("Permissions")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Manager", "Manager")
                        .WithMany("Permissions")
                        .HasForeignKey("ManagerId");

                    b.Navigation("Employee");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Admin", b =>
                {
                    b.Navigation("Managers");
                });

            modelBuilder.Entity("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Company", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Manager");

                    b.Navigation("Membership");
                });

            modelBuilder.Entity("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Employee", b =>
                {
                    b.Navigation("Permissions");
                });

            modelBuilder.Entity("InsanKaynaklariYonetimiPlatformu.Entity.Entities.Manager", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Permissions");
                });
#pragma warning restore 612, 618
        }
    }
}
