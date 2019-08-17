﻿// <auto-generated />
using System;
using FileManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FileManager.Migrations
{
    [DbContext(typeof(FileManagerContext))]
    [Migration("20190817173608_Deleted RoleId1 In UserSystemRole entity")]
    partial class DeletedRoleId1InUserSystemRoleentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FileManager.Models.Database.DepartmentsDocuments.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("FileManager.Models.Database.DepartmentsDocuments.DepartmentsDocument", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("DepartmentID");

                    b.Property<Guid>("YearDocumentTitleID");

                    b.HasKey("ID");

                    b.HasAlternateKey("DepartmentID", "YearDocumentTitleID");

                    b.HasIndex("YearDocumentTitleID");

                    b.ToTable("DepartmentsDocument");
                });

            modelBuilder.Entity("FileManager.Models.Database.DepartmentsDocuments.DepartmentsDocumentsVersion", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("DepartmentDocumentID");

                    b.Property<short>("Version");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentDocumentID");

                    b.ToTable("DepartmentsDocumentsVersion");
                });

            modelBuilder.Entity("FileManager.Models.Database.DocumentStatus.DocumentStatus", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Status");

                    b.HasKey("ID");

                    b.ToTable("DocumentStatus");
                });

            modelBuilder.Entity("FileManager.Models.Database.DocumentStatus.DocumentStatusHistory", b =>
                {
                    b.Property<Guid>("DocumentStatusID");

                    b.Property<Guid>("DepartmentsDocumentID");

                    b.Property<string>("CommentEdits");

                    b.Property<Guid>("ID");

                    b.HasKey("DocumentStatusID", "DepartmentsDocumentID");

                    b.HasIndex("DepartmentsDocumentID");

                    b.ToTable("DocumentStatusHistory");
                });

            modelBuilder.Entity("FileManager.Models.Database.DocumentStatus.RoleStatus", b =>
                {
                    b.Property<Guid>("RoleID");

                    b.Property<Guid>("DocumentStatusID");

                    b.Property<Guid>("ID");

                    b.HasKey("RoleID", "DocumentStatusID");

                    b.HasIndex("DocumentStatusID");

                    b.ToTable("RoleStatus");
                });

            modelBuilder.Entity("FileManager.Models.Database.UserDepartmentRoles.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedName");

                    b.HasKey("Id");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("FileManager.Models.Database.UserDepartmentRoles.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FistName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("FileManager.Models.Database.UserDepartmentRoles.UserDepartmentRole", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("DepartmentId");

                    b.HasKey("UserId", "RoleId", "DepartmentId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserDepartmentRoles");
                });

            modelBuilder.Entity("FileManager.Models.Database.UserSystemRoles.SystemRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetSystemRoles");
                });

            modelBuilder.Entity("FileManager.Models.Database.UserSystemRoles.UserSystemRole", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.Property<Guid?>("RoleId1");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("RoleId1");

                    b.ToTable("AspNetUserSystemRoles");
                });

            modelBuilder.Entity("FileManager.Models.Database.YearDocumentTitles.DocumentTitle", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("DocumentTypeID");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("DocumentTypeID");

                    b.ToTable("DocumentTitle");
                });

            modelBuilder.Entity("FileManager.Models.Database.YearDocumentTitles.DocumentType", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("DocumentType");
                });

            modelBuilder.Entity("FileManager.Models.Database.YearDocumentTitles.Year", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Year");
                });

            modelBuilder.Entity("FileManager.Models.Database.YearDocumentTitles.YearDocumentTitle", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("DocumentTitleID");

                    b.Property<Guid>("YearID");

                    b.HasKey("ID");

                    b.HasAlternateKey("DocumentTitleID", "YearID");

                    b.HasIndex("YearID");

                    b.ToTable("YearDocumentTitle");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FileManager.Models.Database.DepartmentsDocuments.DepartmentsDocument", b =>
                {
                    b.HasOne("FileManager.Models.Database.DepartmentsDocuments.Department", "Department")
                        .WithMany("DepartmentsDocuments")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FileManager.Models.Database.YearDocumentTitles.YearDocumentTitle", "YearDocumentTitle")
                        .WithMany("DepartmentsDocuments")
                        .HasForeignKey("YearDocumentTitleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FileManager.Models.Database.DepartmentsDocuments.DepartmentsDocumentsVersion", b =>
                {
                    b.HasOne("FileManager.Models.Database.DepartmentsDocuments.DepartmentsDocument", "DepartmentsDocument")
                        .WithMany("DepartmentsDocumentsVersions")
                        .HasForeignKey("DepartmentDocumentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FileManager.Models.Database.DocumentStatus.DocumentStatusHistory", b =>
                {
                    b.HasOne("FileManager.Models.Database.DepartmentsDocuments.DepartmentsDocument", "DepartmentsDocument")
                        .WithMany("DocumentStatusHistories")
                        .HasForeignKey("DepartmentsDocumentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FileManager.Models.Database.DocumentStatus.DocumentStatus", "DocumentStatus")
                        .WithMany("DocumentStatusHistories")
                        .HasForeignKey("DocumentStatusID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FileManager.Models.Database.DocumentStatus.RoleStatus", b =>
                {
                    b.HasOne("FileManager.Models.Database.DocumentStatus.DocumentStatus", "DocumentStatus")
                        .WithMany("RoleStatuses")
                        .HasForeignKey("DocumentStatusID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FileManager.Models.Database.UserDepartmentRoles.Role", "Role")
                        .WithMany("RoleStatuses")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FileManager.Models.Database.UserDepartmentRoles.UserDepartmentRole", b =>
                {
                    b.HasOne("FileManager.Models.Database.DepartmentsDocuments.Department", "Department")
                        .WithMany("UserDepartmentRoles")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FileManager.Models.Database.UserDepartmentRoles.Role", "Role")
                        .WithMany("UserRoleDepartments")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FileManager.Models.Database.UserDepartmentRoles.User", "User")
                        .WithMany("UserRoleDepartments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FileManager.Models.Database.UserSystemRoles.UserSystemRole", b =>
                {
                    b.HasOne("FileManager.Models.Database.UserSystemRoles.SystemRole", "SystemRole")
                        .WithMany("UserSystemRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FileManager.Models.Database.UserDepartmentRoles.Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId1");

                    b.HasOne("FileManager.Models.Database.UserDepartmentRoles.User", "User")
                        .WithMany("UserSystemRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FileManager.Models.Database.YearDocumentTitles.DocumentTitle", b =>
                {
                    b.HasOne("FileManager.Models.Database.YearDocumentTitles.DocumentType", "DocumentType")
                        .WithMany("DocumentTitles")
                        .HasForeignKey("DocumentTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FileManager.Models.Database.YearDocumentTitles.YearDocumentTitle", b =>
                {
                    b.HasOne("FileManager.Models.Database.YearDocumentTitles.DocumentTitle", "DocumentTitle")
                        .WithMany("YearDocumentTitles")
                        .HasForeignKey("DocumentTitleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FileManager.Models.Database.YearDocumentTitles.Year", "Year")
                        .WithMany("YearDocumentTitles")
                        .HasForeignKey("YearID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("FileManager.Models.Database.UserSystemRoles.SystemRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("FileManager.Models.Database.UserDepartmentRoles.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("FileManager.Models.Database.UserDepartmentRoles.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("FileManager.Models.Database.UserDepartmentRoles.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
