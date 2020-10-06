using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EStudy.Infrastructure.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "File",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Path = table.Column<string>(maxLength: 500, nullable: false),
                    UniqueId = table.Column<string>(maxLength: 40, nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    OriginalName = table.Column<string>(nullable: false),
                    Extension = table.Column<string>(maxLength: 25, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    MD5CheckSum = table.Column<string>(maxLength: 40, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedFromIPAddress = table.Column<string>(maxLength: 30, nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DateDeleted = table.Column<DateTime>(nullable: true),
                    DeletedById = table.Column<int>(nullable: true),
                    DeletedFromIPAddress = table.Column<string>(maxLength: 30, nullable: true),
                    MaxDateUpToRecovery = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_File", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IHEs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    EnglishName = table.Column<string>(maxLength: 200, nullable: true),
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
                    AddressInfo = table.Column<string>(maxLength: 150, nullable: true),
                    Locality = table.Column<string>(maxLength: 50, nullable: true),
                    Region = table.Column<string>(maxLength: 50, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 6, nullable: true),
                    PhoneHumanResourcesDepartment = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneAccounting = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneSelectionCommittee = table.Column<string>(maxLength: 50, nullable: true),
                    ReceptionOfTheDirector = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneLibrary = table.Column<string>(maxLength: 50, nullable: true),
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
                    table.PrimaryKey("PK_IHEs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleAudiences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAudience = table.Column<string>(maxLength: 25, nullable: false),
                    NameAudienceEng = table.Column<string>(maxLength: 25, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastEdited = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleAudiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleDayOfWeeks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<string>(maxLength: 25, nullable: false),
                    DayEng = table.Column<string>(maxLength: 25, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastEdited = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleDayOfWeeks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleDisciplines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisciplineName = table.Column<string>(maxLength: 100, nullable: false),
                    ShortDisciplineName = table.Column<string>(maxLength: 5, nullable: true),
                    DisciplineNameEng = table.Column<string>(maxLength: 100, nullable: true),
                    ShortDisciplineNameEng = table.Column<string>(maxLength: 5, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastEdited = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleDisciplines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 10, nullable: false),
                    NameEng = table.Column<string>(maxLength: 10, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastEdited = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleLessons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<byte>(nullable: false),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastEdited = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleLessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleParityOfWeeks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Week = table.Column<string>(maxLength: 25, nullable: false),
                    WeekEng = table.Column<string>(maxLength: 30, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastEdited = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleParityOfWeeks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleTypeLessons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(maxLength: 25, nullable: false),
                    ShortTypeName = table.Column<string>(maxLength: 5, nullable: true),
                    TypeNameEng = table.Column<string>(maxLength: 25, nullable: true),
                    ShortTypeNameEng = table.Column<string>(maxLength: 5, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastEdited = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleTypeLessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ShortName = table.Column<string>(maxLength: 10, nullable: true),
                    CourseName = table.Column<string>(maxLength: 50, nullable: true),
                    TeacherId = table.Column<int>(nullable: false),
                    WithExam = table.Column<bool>(nullable: false),
                    MaxMarkUpToExam = table.Column<int>(nullable: false),
                    MaxMarkOnExam = table.Column<int>(nullable: false),
                    CommonHours = table.Column<int>(nullable: false),
                    HoursPracticalTasks = table.Column<int>(nullable: false),
                    HoursSeminarTasks = table.Column<int>(nullable: false),
                    HoursLectures = table.Column<int>(nullable: false),
                    TypeSubject = table.Column<int>(nullable: false),
                    Literature = table.Column<string>(maxLength: 1000, nullable: true),
                    FinalMark = table.Column<int>(nullable: false),
                    NumberSemesters = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_Subjects", x => x.Id);
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
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    InstituteName = table.Column<string>(maxLength: 60, nullable: true),
                    Shifr = table.Column<string>(maxLength: 100, nullable: false),
                    HeadById = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    ContactInformation = table.Column<string>(maxLength: 3000, nullable: true),
                    Description = table.Column<string>(maxLength: 300, nullable: false),
                    IHEId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_IHEs_IHEId",
                        column: x => x.IHEId,
                        principalTable: "IHEs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsReplacement = table.Column<bool>(nullable: false),
                    TeacherId = table.Column<int>(nullable: true),
                    DateLesson = table.Column<DateTime>(nullable: false),
                    ScheduleDayOfWeekId = table.Column<int>(nullable: false),
                    ScheduleParityOfWeekId = table.Column<int>(nullable: false),
                    ScheduleLessonId = table.Column<int>(nullable: false),
                    ScheduleGroupId = table.Column<int>(nullable: false),
                    ScheduleDisciplineId = table.Column<int>(nullable: false),
                    ScheduleTypeLessonId = table.Column<int>(nullable: false),
                    ScheduleAudienceId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastEdited = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_ScheduleAudiences_ScheduleAudienceId",
                        column: x => x.ScheduleAudienceId,
                        principalTable: "ScheduleAudiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_ScheduleDayOfWeeks_ScheduleDayOfWeekId",
                        column: x => x.ScheduleDayOfWeekId,
                        principalTable: "ScheduleDayOfWeeks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_ScheduleDisciplines_ScheduleDisciplineId",
                        column: x => x.ScheduleDisciplineId,
                        principalTable: "ScheduleDisciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_ScheduleGroups_ScheduleGroupId",
                        column: x => x.ScheduleGroupId,
                        principalTable: "ScheduleGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_ScheduleLessons_ScheduleLessonId",
                        column: x => x.ScheduleLessonId,
                        principalTable: "ScheduleLessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_ScheduleParityOfWeeks_ScheduleParityOfWeekId",
                        column: x => x.ScheduleParityOfWeekId,
                        principalTable: "ScheduleParityOfWeeks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_ScheduleTypeLessons_ScheduleTypeLessonId",
                        column: x => x.ScheduleTypeLessonId,
                        principalTable: "ScheduleTypeLessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Theme = table.Column<string>(maxLength: 100, nullable: false),
                    Text = table.Column<string>(maxLength: 1000, nullable: false),
                    DateLesson = table.Column<DateTime>(nullable: false),
                    AssignedToTeacherId = table.Column<int>(nullable: false),
                    IsHindFromStudent = table.Column<bool>(nullable: false),
                    IsReplacement = table.Column<bool>(nullable: false),
                    TeacherReplacementId = table.Column<int>(nullable: true),
                    TypeLesson = table.Column<int>(nullable: false),
                    SubjectId = table.Column<long>(nullable: false),
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
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Specialties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Shifr = table.Column<string>(maxLength: 20, nullable: false),
                    CodeSpec = table.Column<string>(maxLength: 6, nullable: false),
                    Qualification = table.Column<int>(maxLength: 100, nullable: false),
                    EducationalProgram = table.Column<string>(maxLength: 250, nullable: true),
                    ProfessionalQualification = table.Column<string>(maxLength: 250, nullable: true),
                    DepartmentId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_Specialties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specialties_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Presences",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(nullable: false),
                    Presents = table.Column<int>(nullable: false),
                    LessonId = table.Column<long>(nullable: false),
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
                    table.PrimaryKey("PK_Presences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Presences_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(maxLength: 1000, nullable: false),
                    MaxMarkByThisTask = table.Column<int>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: true),
                    LessonId = table.Column<long>(nullable: false),
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
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(maxLength: 20, nullable: false),
                    IndexItemToChanged = table.Column<byte>(nullable: false),
                    Released = table.Column<bool>(nullable: false),
                    CodeForConnect = table.Column<string>(maxLength: 12, nullable: false),
                    AdditionalInfo = table.Column<string>(maxLength: 500, nullable: true),
                    EmailByGroup = table.Column<string>(maxLength: 100, nullable: true),
                    LoginToEmail = table.Column<string>(maxLength: 100, nullable: true),
                    PasswordToEmail = table.Column<string>(maxLength: 150, nullable: true),
                    IsShowEmail = table.Column<bool>(nullable: false),
                    GroupHeadId = table.Column<int>(nullable: true),
                    SpecialtyId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Specialties_SpecialtyId",
                        column: x => x.SpecialtyId,
                        principalTable: "Specialties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Homeworks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsComplate = table.Column<bool>(nullable: false),
                    ComplateByStudentId = table.Column<int>(nullable: true),
                    DateComplated = table.Column<DateTime>(nullable: true),
                    Text = table.Column<string>(maxLength: 5000, nullable: true),
                    TeacherSetId = table.Column<int>(nullable: false),
                    TaskId = table.Column<long>(nullable: false),
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
                    table.PrimaryKey("PK_Homeworks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Homeworks_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 75, nullable: true),
                    TypeMark = table.Column<int>(nullable: false),
                    TeacherSetId = table.Column<int>(nullable: false),
                    IsHindFromStudents = table.Column<bool>(nullable: false),
                    LessonId = table.Column<long>(nullable: true),
                    TaskId = table.Column<long>(nullable: true),
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
                    table.PrimaryKey("PK_Marks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marks_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Marks_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupSubjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false),
                    SubjectId1 = table.Column<long>(nullable: true),
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
                    table.PrimaryKey("PK_GroupSubjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupSubjects_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupSubjects_Subjects_SubjectId1",
                        column: x => x.SubjectId1,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    LinkVerify = table.Column<string>(maxLength: 120, nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Diplomas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeDiploma = table.Column<int>(nullable: false),
                    SeriesDiploma = table.Column<string>(maxLength: 7, nullable: true),
                    NumberDiploma = table.Column<string>(maxLength: 10, nullable: true),
                    PresentedAt = table.Column<DateTime>(nullable: true),
                    Firstname = table.Column<string>(maxLength: 50, nullable: false),
                    Patronymic = table.Column<string>(maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(maxLength: 50, nullable: false),
                    IHEFullName = table.Column<string>(maxLength: 200, nullable: false),
                    Specialty = table.Column<string>(maxLength: 100, nullable: false),
                    EducationalProgram = table.Column<string>(maxLength: 150, nullable: false),
                    ProfessionalQualification = table.Column<string>(maxLength: 150, nullable: false),
                    NameOfRector = table.Column<string>(maxLength: 100, nullable: false),
                    PathToPrinting = table.Column<string>(maxLength: 250, nullable: true),
                    PathToSignature = table.Column<string>(maxLength: 250, nullable: true),
                    IsRed = table.Column<bool>(nullable: false),
                    InPass = table.Column<bool>(nullable: false),
                    UniqCode = table.Column<string>(maxLength: 25, nullable: false),
                    UserId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_Diplomas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diplomas_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_IHEId_Name_HeadById_InstituteName_Phone_Shifr",
                table: "Departments",
                columns: new[] { "IHEId", "Name", "HeadById", "InstituteName", "Phone", "Shifr" });

            migrationBuilder.CreateIndex(
                name: "IX_Diplomas_UserId",
                table: "Diplomas",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Diplomas_IsRed_InPass_UniqCode",
                table: "Diplomas",
                columns: new[] { "IsRed", "InPass", "UniqCode" });

            migrationBuilder.CreateIndex(
                name: "IX_File_UniqueId_OriginalName_MaxDateUpToRecovery_Size_Path",
                table: "File",
                columns: new[] { "UniqueId", "OriginalName", "MaxDateUpToRecovery", "Size", "Path" });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_SpecialtyId",
                table: "Groups",
                column: "SpecialtyId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_GroupHeadId_CodeForConnect_EmailByGroup_GroupName_IndexItemToChanged_IsShowEmail_Released_SpecialtyId",
                table: "Groups",
                columns: new[] { "GroupHeadId", "CodeForConnect", "EmailByGroup", "GroupName", "IndexItemToChanged", "IsShowEmail", "Released", "SpecialtyId" });

            migrationBuilder.CreateIndex(
                name: "IX_GroupSubjects_SubjectId1",
                table: "GroupSubjects",
                column: "SubjectId1");

            migrationBuilder.CreateIndex(
                name: "IX_GroupSubjects_GroupId_SubjectId_CreatedFromIPAddress",
                table: "GroupSubjects",
                columns: new[] { "GroupId", "SubjectId", "CreatedFromIPAddress" });

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_TaskId",
                table: "Homeworks",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_ComplateByStudentId_IsComplate_TaskId_TeacherSetId",
                table: "Homeworks",
                columns: new[] { "ComplateByStudentId", "IsComplate", "TaskId", "TeacherSetId" });

            migrationBuilder.CreateIndex(
                name: "IX_IHEs_Name_ShortName_StudentCode_TeacherCode_Region_AreaIHE_Locality_LevelOfAccreditation",
                table: "IHEs",
                columns: new[] { "Name", "ShortName", "StudentCode", "TeacherCode", "Region", "AreaIHE", "Locality", "LevelOfAccreditation" });

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_SubjectId",
                table: "Lessons",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_Theme_Text_DateLesson_AssignedToTeacherId_SubjectId",
                table: "Lessons",
                columns: new[] { "Theme", "Text", "DateLesson", "AssignedToTeacherId", "SubjectId" });

            migrationBuilder.CreateIndex(
                name: "IX_Marks_LessonId",
                table: "Marks",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_TaskId",
                table: "Marks",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_Value_TypeMark_TeacherSetId_IsHindFromStudents_LessonId",
                table: "Marks",
                columns: new[] { "Value", "TypeMark", "TeacherSetId", "IsHindFromStudents", "LessonId" });

            migrationBuilder.CreateIndex(
                name: "IX_Presences_LessonId_Presents_StudentId",
                table: "Presences",
                columns: new[] { "LessonId", "Presents", "StudentId" });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ScheduleAudienceId",
                table: "Schedules",
                column: "ScheduleAudienceId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ScheduleDayOfWeekId",
                table: "Schedules",
                column: "ScheduleDayOfWeekId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ScheduleDisciplineId",
                table: "Schedules",
                column: "ScheduleDisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ScheduleGroupId",
                table: "Schedules",
                column: "ScheduleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ScheduleLessonId",
                table: "Schedules",
                column: "ScheduleLessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ScheduleParityOfWeekId",
                table: "Schedules",
                column: "ScheduleParityOfWeekId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ScheduleTypeLessonId",
                table: "Schedules",
                column: "ScheduleTypeLessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialties_DepartmentId",
                table: "Specialties",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialties_Name_CodeSpec_DepartmentId_ProfessionalQualification_Qualification_Shifr",
                table: "Specialties",
                columns: new[] { "Name", "CodeSpec", "DepartmentId", "ProfessionalQualification", "Qualification", "Shifr" });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Name_ShortName_CourseName_TeacherId_MaxMarkUpToExam_MaxMarkOnExam_CommonHours_NumberSemesters_FinalMark_TypeSubject",
                table: "Subjects",
                columns: new[] { "Name", "ShortName", "CourseName", "TeacherId", "MaxMarkUpToExam", "MaxMarkOnExam", "CommonHours", "NumberSemesters", "FinalMark", "TypeSubject" });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_LessonId",
                table: "Tasks",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_Text_MaxMarkByThisTask_DueDate_LessonId",
                table: "Tasks",
                columns: new[] { "Text", "MaxMarkByThisTask", "DueDate", "LessonId" });

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
                name: "Diplomas");

            migrationBuilder.DropTable(
                name: "File");

            migrationBuilder.DropTable(
                name: "GroupSubjects");

            migrationBuilder.DropTable(
                name: "Homeworks");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "Presences");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "TestEntities");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "ScheduleAudiences");

            migrationBuilder.DropTable(
                name: "ScheduleDayOfWeeks");

            migrationBuilder.DropTable(
                name: "ScheduleDisciplines");

            migrationBuilder.DropTable(
                name: "ScheduleGroups");

            migrationBuilder.DropTable(
                name: "ScheduleLessons");

            migrationBuilder.DropTable(
                name: "ScheduleParityOfWeeks");

            migrationBuilder.DropTable(
                name: "ScheduleTypeLessons");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Specialties");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "IHEs");
        }
    }
}
