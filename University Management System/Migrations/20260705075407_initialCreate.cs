using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    instructorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    officeNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    hireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    academicTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.instructorId);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    studentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    dateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    enrollmentYear = table.Column<int>(type: "int", nullable: false),
                    gpa = table.Column<decimal>(type: "decimal(3,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.studentId);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    departmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departmentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    building = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    budget = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    headInstructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.departmentId);
                    table.ForeignKey(
                        name: "FK_Department_Instructor_headInstructorId",
                        column: x => x.headInstructorId,
                        principalTable: "Instructor",
                        principalColumn: "instructorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    courseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    courseTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    creditHours = table.Column<int>(type: "int", nullable: false),
                    semesterOffered = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    departmentId = table.Column<int>(type: "int", nullable: false),
                    instructorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.courseId);
                    table.ForeignKey(
                        name: "FK_Course_Department_departmentId",
                        column: x => x.departmentId,
                        principalTable: "Department",
                        principalColumn: "departmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Course_Instructor_instructorId",
                        column: x => x.instructorId,
                        principalTable: "Instructor",
                        principalColumn: "instructorId");
                });

            migrationBuilder.CreateTable(
                name: "Enrollment",
                columns: table => new
                {
                    enrollmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    enrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    finalGrade = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    status = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    courseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollment", x => x.enrollmentId);
                    table.ForeignKey(
                        name: "FK_Enrollment_Course_courseId",
                        column: x => x.courseId,
                        principalTable: "Course",
                        principalColumn: "courseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollment_Student_studentId",
                        column: x => x.studentId,
                        principalTable: "Student",
                        principalColumn: "studentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_courseCode",
                table: "Course",
                column: "courseCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Course_departmentId",
                table: "Course",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_instructorId",
                table: "Course",
                column: "instructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_departmentName",
                table: "Department",
                column: "departmentName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_headInstructorId",
                table: "Department",
                column: "headInstructorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_courseId",
                table: "Enrollment",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_studentId",
                table: "Enrollment",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_email",
                table: "Instructor",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_email",
                table: "Student",
                column: "email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollment");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Instructor");
        }
    }
}
