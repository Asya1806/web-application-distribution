﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationDistribution.Data;

#nullable disable

namespace WebApplicationDistribution.Migrations
{
    [DbContext(typeof(EntrantDbContext))]
    [Migration("20230510125734_initial create")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApplicationDistribution.Contracts.ApplicationForPaid", b =>
                {
                    b.Property<int>("Applic_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Applic_Id"), 1L, 1);

                    b.Property<string>("Application")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Applic_Id");

                    b.ToTable("applicationForPaid");
                });

            modelBuilder.Entity("WebApplicationDistribution.Contracts.Benefit", b =>
                {
                    b.Property<int>("Benefit_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Benefit_Id"), 1L, 1);

                    b.Property<string>("_benefit")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Benefit_Id");

                    b.ToTable("benefits");
                });

            modelBuilder.Entity("WebApplicationDistribution.Contracts.CommissionDecision", b =>
                {
                    b.Property<int>("Dec_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dec_Id"), 1L, 1);

                    b.Property<string>("Decision")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Dec_Id");

                    b.ToTable("commissionDecisions");
                });

            modelBuilder.Entity("WebApplicationDistribution.Contracts.Entrant", b =>
                {
                    b.Property<string>("Entrant_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AdditionalTraining")
                        .HasColumnType("int");

                    b.Property<int>("ApplicationForPaid_Id")
                        .HasColumnType("int");

                    b.Property<int>("BRYU_Id")
                        .HasColumnType("int");

                    b.Property<int>("Benefits_Id")
                        .HasColumnType("int");

                    b.Property<int>("CommissionDecision_Id")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Gender_Id")
                        .HasColumnType("int");

                    b.Property<int>("LangInUniver_Id")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Locality_Id")
                        .HasColumnType("int");

                    b.Property<int>("MarkMath")
                        .HasColumnType("int");

                    b.Property<int>("MarkPhys")
                        .HasColumnType("int");

                    b.Property<int>("MedalDSO_Id")
                        .HasColumnType("int");

                    b.Property<int>("MiddleMark")
                        .HasColumnType("int");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PassportNumber")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PassportSeries_Id")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Specialty1_Id")
                        .HasColumnType("int");

                    b.Property<int>("Specialty2_Id")
                        .HasColumnType("int");

                    b.Property<int>("Specialty3_Id")
                        .HasColumnType("int");

                    b.Property<int>("Specialty4_Id")
                        .HasColumnType("int");

                    b.Property<int>("Specialty5_Id")
                        .HasColumnType("int");

                    b.Property<int>("Specialty6_Id")
                        .HasColumnType("int");

                    b.Property<int>("SumOfPoints")
                        .HasColumnType("int");

                    b.Property<int>("TestLang")
                        .HasColumnType("int");

                    b.Property<int>("TestMath")
                        .HasColumnType("int");

                    b.Property<int>("TestPhys")
                        .HasColumnType("int");

                    b.Property<int>("TypeOfСontest_Id")
                        .HasColumnType("int");

                    b.Property<int>("Volunteer_Id")
                        .HasColumnType("int");

                    b.Property<int>("_100IdeasForBelarus_Id")
                        .HasColumnType("int");

                    b.HasKey("Entrant_Id");

                    b.ToTable("entrants");
                });

            modelBuilder.Entity("WebApplicationDistribution.Contracts.Gender", b =>
                {
                    b.Property<int>("Gender_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Gender_Id"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Gender_Id");

                    b.ToTable("genders");
                });

            modelBuilder.Entity("WebApplicationDistribution.Contracts.LanguageInUniver", b =>
                {
                    b.Property<int>("Lang_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Lang_Id"), 1L, 1);

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Lang_Id");

                    b.ToTable("languageInUnivers");
                });

            modelBuilder.Entity("WebApplicationDistribution.Contracts.Locality", b =>
                {
                    b.Property<int>("Locality_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Locality_Id"), 1L, 1);

                    b.Property<string>("LocalityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Locality_Id");

                    b.ToTable("localities");
                });

            modelBuilder.Entity("WebApplicationDistribution.Contracts.LoginRequest", b =>
                {
                    b.Property<int>("Log_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Log_Id"), 1L, 1);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Log_Id");

                    b.ToTable("loginRequests");
                });

            modelBuilder.Entity("WebApplicationDistribution.Contracts.PassportSeries", b =>
                {
                    b.Property<int>("series_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("series_Id"), 1L, 1);

                    b.Property<string>("SeriesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("series_Id");

                    b.ToTable("passportSeries");
                });

            modelBuilder.Entity("WebApplicationDistribution.Contracts.Speciality", b =>
                {
                    b.Property<int>("Spec_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Spec_Id"), 1L, 1);

                    b.Property<string>("SpecialtyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Spec_Id");

                    b.ToTable("specialities");
                });

            modelBuilder.Entity("WebApplicationDistribution.Contracts.TypeOfContest", b =>
                {
                    b.Property<int>("Contest_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Contest_Id"), 1L, 1);

                    b.Property<string>("Contest")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Contest_Id");

                    b.ToTable("typeOfContests");
                });

            modelBuilder.Entity("WebApplicationDistribution.Contracts.YesOrNo", b =>
                {
                    b.Property<int>("YN_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YN_Id"), 1L, 1);

                    b.Property<string>("Y_N")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("YN_Id");

                    b.ToTable("yesOrNo");
                });
#pragma warning restore 612, 618
        }
    }
}
