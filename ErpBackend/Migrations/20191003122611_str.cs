using Microsoft.EntityFrameworkCore.Migrations;

namespace ErpBackend.Migrations
{
    public partial class str : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Employee_EmployeeId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Designation_Employee_EmployeeId",
                table: "Designation");

            migrationBuilder.DropIndex(
                name: "IX_Designation_EmployeeId",
                table: "Designation");

            migrationBuilder.DropIndex(
                name: "IX_Department_EmployeeId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Designation");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Department");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DesignationId",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DesignationId",
                table: "Employee",
                column: "DesignationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Designation_DesignationId",
                table: "Employee",
                column: "DesignationId",
                principalTable: "Designation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Designation_DesignationId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_DesignationId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DesignationId",
                table: "Employee");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Designation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Department",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Designation_EmployeeId",
                table: "Designation",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_EmployeeId",
                table: "Department",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Employee_EmployeeId",
                table: "Department",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Designation_Employee_EmployeeId",
                table: "Designation",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
