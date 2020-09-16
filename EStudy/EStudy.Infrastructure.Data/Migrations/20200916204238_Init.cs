using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EStudy.Infrastructure.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IHEs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedFromIPAddress = table.Column<string>(maxLength: 30, nullable: false),
                    CreatedById = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    ShortName = table.Column<string>(maxLength: 25, nullable: false),
                    TypeIHE = table.Column<int>(nullable: false),
                    AreaIHE = table.Column<string>(maxLength: 100, nullable: false),
                    LevelOfAccreditation = table.Column<string>(maxLength: 75, nullable: false),
                    TimeStudyOfMagister = table.Column<double>(nullable: false),
                    TimeStudyOfBakalavr = table.Column<double>(nullable: false),
                    PhotoPath = table.Column<string>(maxLength: 300, nullable: true),
                    Logo25 = table.Column<string>(maxLength: 300, nullable: true),
                    Logo50 = table.Column<string>(maxLength: 300, nullable: true),
                    Logo100 = table.Column<string>(maxLength: 300, nullable: true),
                    LogoMax = table.Column<string>(maxLength: 300, nullable: true),
                    TeacherCode = table.Column<string>(maxLength: 16, nullable: false),
                    StudentCode = table.Column<string>(maxLength: 16, nullable: false),
                    History = table.Column<string>(maxLength: 1000, nullable: true),
                    HeadOfIheId = table.Column<int>(nullable: false),
                    PartOfIHE = table.Column<int>(nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateLastEdit = table.Column<DateTime>(nullable: true),
                    EditedByUserId = table.Column<int>(nullable: true),
                    EditedFromIPAddress = table.Column<string>(maxLength: 30, nullable: true),
                    AddressInfo = table.Column<string>(maxLength: 150, nullable: true),
                    Locality = table.Column<string>(maxLength: 50, nullable: false),
                    Region = table.Column<string>(nullable: false),
                    PostalCode = table.Column<string>(maxLength: 6, nullable: true),
                    PhoneHumanResourcesDepartment = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneAccounting = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneSelectionCommittee = table.Column<string>(maxLength: 50, nullable: true),
                    ReceptionOfTheDirector = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneLibrary = table.Column<string>(maxLength: 50, nullable: true),
                    ChangeHistory = table.Column<string>(maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IHEs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Code = table.Column<string>(maxLength: 20, nullable: false),
                    Guid = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(maxLength: 50, nullable: false),
                    Patronymic = table.Column<string>(maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(maxLength: 50, nullable: false),
                    Born = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(maxLength: 300, nullable: true),
                    Username = table.Column<string>(maxLength: 35, nullable: false),
                    Phone = table.Column<string>(maxLength: 30, nullable: true),
                    IsShowPhone = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    IsShowEmail = table.Column<bool>(nullable: false),
                    PhotoPath = table.Column<string>(maxLength: 300, nullable: true),
                    Role = table.Column<int>(nullable: false),
                    UserStatus = table.Column<int>(nullable: false),
                    Chair = table.Column<string>(maxLength: 25, nullable: true),
                    Login = table.Column<string>(maxLength: 150, nullable: false),
                    PasswordHash = table.Column<string>(maxLength: 300, nullable: false),
                    StudentRecordBook = table.Column<string>(maxLength: 20, nullable: true),
                    StudentTicketSeries = table.Column<string>(maxLength: 5, nullable: true),
                    StudentTicketNumber = table.Column<string>(maxLength: 50, nullable: true),
                    TeacherCode = table.Column<string>(maxLength: 25, nullable: true),
                    CanEdit = table.Column<bool>(nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    LinkVerify = table.Column<string>(maxLength: 300, nullable: true),
                    DateVerified = table.Column<DateTime>(nullable: true),
                    Raiting = table.Column<double>(nullable: false),
                    Degree = table.Column<int>(nullable: false),
                    AcademicStatus = table.Column<int>(nullable: false),
                    ChangeHistory = table.Column<string>(maxLength: 5000, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedFromIPAddress = table.Column<string>(maxLength: 30, nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateLastEdit = table.Column<DateTime>(nullable: true),
                    EditedFromIPAddress = table.Column<string>(maxLength: 30, nullable: true),
                    LastEditedByUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IHEs_Name_ShortName_StudentCode_TeacherCode_Region_AreaIHE_Locality_LevelOfAccreditation",
                table: "IHEs",
                columns: new[] { "Name", "ShortName", "StudentCode", "TeacherCode", "Region", "AreaIHE", "Locality", "LevelOfAccreditation" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Firstname_Patronymic_Lastname_Username_UserStatus_Role_Login_Born_Email_Phone_Chair_LinkVerify_StudentRecordBook_Stude~",
                table: "Users",
                columns: new[] { "Firstname", "Patronymic", "Lastname", "Username", "UserStatus", "Role", "Login", "Born", "Email", "Phone", "Chair", "LinkVerify", "StudentRecordBook", "StudentTicketNumber", "StudentTicketSeries", "TeacherCode" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IHEs");

            migrationBuilder.DropTable(
                name: "TestEntities");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
