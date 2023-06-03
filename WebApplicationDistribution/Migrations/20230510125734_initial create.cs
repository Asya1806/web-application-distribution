using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationDistribution.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "applicationForPaid",
                columns: table => new
                {
                    Applic_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Application = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_applicationForPaid", x => x.Applic_Id);
                });

            migrationBuilder.CreateTable(
                name: "benefits",
                columns: table => new
                {
                    Benefit_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _benefit = table.Column<string>(type: "nvarchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_benefits", x => x.Benefit_Id);
                });

            migrationBuilder.CreateTable(
                name: "commissionDecisions",
                columns: table => new
                {
                    Dec_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Decision = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_commissionDecisions", x => x.Dec_Id);
                });

            migrationBuilder.CreateTable(
                name: "entrants",
                columns: table => new
                {
                    Entrant_Id = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Gender_Id = table.Column<int>(type: "int", nullable: false),
                    ApplicationForPaid_Id = table.Column<int>(type: "int", nullable: false),
                    TestMath = table.Column<int>(type: "int", nullable: false),
                    TestPhys = table.Column<int>(type: "int", nullable: false),
                    TestLang = table.Column<int>(type: "int", nullable: false),
                    MiddleMark = table.Column<int>(type: "int", nullable: false),
                    SumOfPoints = table.Column<int>(type: "int", nullable: false),
                    MarkMath = table.Column<int>(type: "int", nullable: false),
                    MarkPhys = table.Column<int>(type: "int", nullable: false),
                    TypeOfСontest_Id = table.Column<int>(type: "int", nullable: false),
                    Specialty1_Id = table.Column<int>(type: "int", nullable: false),
                    Specialty2_Id = table.Column<int>(type: "int", nullable: false),
                    Specialty3_Id = table.Column<int>(type: "int", nullable: false),
                    Specialty4_Id = table.Column<int>(type: "int", nullable: false),
                    Specialty5_Id = table.Column<int>(type: "int", nullable: false),
                    Specialty6_Id = table.Column<int>(type: "int", nullable: false),
                    Benefits_Id = table.Column<int>(type: "int", nullable: false),
                    LangInUniver_Id = table.Column<int>(type: "int", nullable: false),
                    _100IdeasForBelarus_Id = table.Column<int>(type: "int", nullable: false),
                    Volunteer_Id = table.Column<int>(type: "int", nullable: false),
                    BRYU_Id = table.Column<int>(type: "int", nullable: false),
                    MedalDSO_Id = table.Column<int>(type: "int", nullable: false),
                    AdditionalTraining = table.Column<int>(type: "int", nullable: false),
                    Locality_Id = table.Column<int>(type: "int", nullable: false),
                    PassportSeries_Id = table.Column<int>(type: "int", nullable: false),
                    PassportNumber = table.Column<int>(type: "nvarchar(50)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CommissionDecision_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entrants", x => x.Entrant_Id);
                });

            migrationBuilder.CreateTable(
                name: "genders",
                columns: table => new
                {
                    Gender_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genders", x => x.Gender_Id);
                });

            migrationBuilder.CreateTable(
                name: "languageInUnivers",
                columns: table => new
                {
                    Lang_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languageInUnivers", x => x.Lang_Id);
                });

            migrationBuilder.CreateTable(
                name: "localities",
                columns: table => new
                {
                    Locality_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalityName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_localities", x => x.Locality_Id);
                });

            migrationBuilder.CreateTable(
                name: "loginRequests",
                columns: table => new
                {
                    Log_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loginRequests", x => x.Log_Id);
                });

            migrationBuilder.CreateTable(
                name: "passportSeries",
                columns: table => new
                {
                    series_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passportSeries", x => x.series_Id);
                });

            migrationBuilder.CreateTable(
                name: "specialities",
                columns: table => new
                {
                    Spec_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialtyName = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specialities", x => x.Spec_Id);
                });

            migrationBuilder.CreateTable(
                name: "typeOfContests",
                columns: table => new
                {
                    Contest_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contest = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_typeOfContests", x => x.Contest_Id);
                });

            migrationBuilder.CreateTable(
                name: "yesOrNo",
                columns: table => new
                {
                    YN_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Y_N = table.Column<string>(type: "nvarchar(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yesOrNo", x => x.YN_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "applicationForPaid");

            migrationBuilder.DropTable(
                name: "benefits");

            migrationBuilder.DropTable(
                name: "commissionDecisions");

            migrationBuilder.DropTable(
                name: "entrants");

            migrationBuilder.DropTable(
                name: "genders");

            migrationBuilder.DropTable(
                name: "languageInUnivers");

            migrationBuilder.DropTable(
                name: "localities");

            migrationBuilder.DropTable(
                name: "loginRequests");

            migrationBuilder.DropTable(
                name: "passportSeries");

            migrationBuilder.DropTable(
                name: "specialities");

            migrationBuilder.DropTable(
                name: "typeOfContests");

            migrationBuilder.DropTable(
                name: "yesOrNo");
        }
    }
}
