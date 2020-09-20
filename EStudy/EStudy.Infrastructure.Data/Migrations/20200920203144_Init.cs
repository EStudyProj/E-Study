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
                    PartOfIHE = table.Column<int>(nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateLastEdit = table.Column<DateTime>(nullable: true),
                    EditedByUserId = table.Column<int>(nullable: true),
                    EditedFromIPAddress = table.Column<string>(maxLength: 30, nullable: true),
                    AddressInfo = table.Column<string>(maxLength: 150, nullable: true),
                    Locality = table.Column<string>(maxLength: 50, nullable: true),
                    Region = table.Column<string>(maxLength: 50, nullable: true),
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
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedFromIpAddress = table.Column<string>(maxLength: 30, nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 24, nullable: false),
                    InstituteName = table.Column<string>(maxLength: 24, nullable: true),
                    Shifr = table.Column<string>(maxLength: 100, nullable: false),
                    HeadById = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 300, nullable: false),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateLastEdit = table.Column<DateTime>(nullable: false),
                    EditUserById = table.Column<int>(nullable: true),
                    IpFromLastEdit = table.Column<string>(maxLength: 30, nullable: true),
                    IHEId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_IHEs_IHEId",
                        column: x => x.IHEId,
                        principalTable: "IHEs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Specialties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedFromIPAddress = table.Column<string>(maxLength: 30, nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Shifr = table.Column<string>(maxLength: 20, nullable: true),
                    CodeSpec = table.Column<string>(maxLength: 6, nullable: true),
                    Qualification = table.Column<int>(maxLength: 100, nullable: false),
                    EducationalProgram = table.Column<string>(maxLength: 250, nullable: true),
                    ProfessionalQualification = table.Column<string>(maxLength: 250, nullable: true),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateLastEdit = table.Column<DateTime>(nullable: true),
                    LastEditUserId = table.Column<int>(nullable: true),
                    LastEditFromIpAddress = table.Column<string>(maxLength: 30, nullable: true),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specialties_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedFromIPAddress = table.Column<string>(maxLength: 30, nullable: false),
                    CreatedById = table.Column<int>(nullable: false),
                    GroupName = table.Column<string>(maxLength: 20, nullable: false),
                    IndexItemToChanged = table.Column<byte>(nullable: false),
                    Released = table.Column<bool>(nullable: false),
                    CodeForConnect = table.Column<string>(maxLength: 7, nullable: false),
                    AdditionalInfo = table.Column<string>(maxLength: 500, nullable: true),
                    EmailByGroup = table.Column<string>(maxLength: 100, nullable: true),
                    LoginToEmail = table.Column<string>(maxLength: 100, nullable: true),
                    PasswordToEmail = table.Column<string>(maxLength: 150, nullable: true),
                    IsShowEmail = table.Column<bool>(nullable: false),
                    ClassHeadId = table.Column<int>(nullable: true),
                    IsEdit = table.Column<bool>(nullable: false),
                    DateLastEdit = table.Column<DateTime>(nullable: true),
                    LastEditUserId = table.Column<int>(nullable: true),
                    LastEditFromIPAddress = table.Column<string>(maxLength: 30, nullable: true),
                    SpecialtyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Specialties_SpecialtyId",
                        column: x => x.SpecialtyId,
                        principalTable: "Specialties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    GroupId = table.Column<int>(nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Users_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_IHEId_Name_HeadById_InstituteName_Phone_Shifr",
                table: "Departments",
                columns: new[] { "IHEId", "Name", "HeadById", "InstituteName", "Phone", "Shifr" });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_SpecialtyId",
                table: "Groups",
                column: "SpecialtyId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_ClassHeadId_CodeForConnect_EmailByGroup_GroupName_IndexItemToChanged_IsShowEmail_Released_SpecialtyId",
                table: "Groups",
                columns: new[] { "ClassHeadId", "CodeForConnect", "EmailByGroup", "GroupName", "IndexItemToChanged", "IsShowEmail", "Released", "SpecialtyId" });

            migrationBuilder.CreateIndex(
                name: "IX_IHEs_Name_ShortName_StudentCode_TeacherCode_Region_AreaIHE_Locality_LevelOfAccreditation",
                table: "IHEs",
                columns: new[] { "Name", "ShortName", "StudentCode", "TeacherCode", "Region", "AreaIHE", "Locality", "LevelOfAccreditation" });

            migrationBuilder.CreateIndex(
                name: "IX_Specialties_DepartmentId",
                table: "Specialties",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialties_Name_CodeSpec_DepartmentId_ProfessionalQualification_Qualification_Shifr",
                table: "Specialties",
                columns: new[] { "Name", "CodeSpec", "DepartmentId", "ProfessionalQualification", "Qualification", "Shifr" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_GroupId",
                table: "Users",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Firstname_Patronymic_Lastname_Username_UserStatus_Role_Login_Born_Email_Phone_Chair_LinkVerify_StudentRecordBook_Stude~",
                table: "Users",
                columns: new[] { "Firstname", "Patronymic", "Lastname", "Username", "UserStatus", "Role", "Login", "Born", "Email", "Phone", "Chair", "LinkVerify", "StudentRecordBook", "StudentTicketNumber", "StudentTicketSeries", "TeacherCode" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestEntities");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Specialties");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "IHEs");
        }
    }
}
