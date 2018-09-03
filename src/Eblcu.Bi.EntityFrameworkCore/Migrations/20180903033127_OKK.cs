using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Eblcu.Bi.Migrations
{
    public partial class OKK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_zhx_student_inreadings",
                schema: "CMS",
                table: "zhx_student_inreadings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_nograduate_studentsdatas",
                schema: "CMS",
                table: "nograduate_studentsdatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_graduate_studentsdatas",
                schema: "CMS",
                table: "graduate_studentsdatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_entry_recruit_studentsdatas",
                schema: "CMS",
                table: "entry_recruit_studentsdatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_drop_out_studentsdatas",
                schema: "CMS",
                table: "drop_out_studentsdatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_charge_studentsdatas",
                schema: "CMS",
                table: "charge_studentsdatas");

            migrationBuilder.RenameTable(
                name: "zhx_student_inreadings",
                schema: "CMS",
                newName: "zhx_student_inreading");

            migrationBuilder.RenameTable(
                name: "nograduate_studentsdatas",
                schema: "CMS",
                newName: "nograduate_studentsdata");

            migrationBuilder.RenameTable(
                name: "graduate_studentsdatas",
                schema: "CMS",
                newName: "graduate_studentsdata");

            migrationBuilder.RenameTable(
                name: "entry_recruit_studentsdatas",
                schema: "CMS",
                newName: "entry_recruit_studentsdata");

            migrationBuilder.RenameTable(
                name: "drop_out_studentsdatas",
                schema: "CMS",
                newName: "drop_out_studentsdata");

            migrationBuilder.RenameTable(
                name: "charge_studentsdatas",
                schema: "CMS",
                newName: "charge_studentsdata");

            migrationBuilder.AddPrimaryKey(
                name: "PK_zhx_student_inreading",
                schema: "CMS",
                table: "zhx_student_inreading",
                column: "inReadingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_nograduate_studentsdata",
                schema: "CMS",
                table: "nograduate_studentsdata",
                column: "noGraduateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_graduate_studentsdata",
                schema: "CMS",
                table: "graduate_studentsdata",
                column: "graduateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_entry_recruit_studentsdata",
                schema: "CMS",
                table: "entry_recruit_studentsdata",
                column: "recruitStudentsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_drop_out_studentsdata",
                schema: "CMS",
                table: "drop_out_studentsdata",
                column: "dropOutId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_charge_studentsdata",
                schema: "CMS",
                table: "charge_studentsdata",
                column: "chargeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_zhx_student_inreading",
                schema: "CMS",
                table: "zhx_student_inreading");

            migrationBuilder.DropPrimaryKey(
                name: "PK_nograduate_studentsdata",
                schema: "CMS",
                table: "nograduate_studentsdata");

            migrationBuilder.DropPrimaryKey(
                name: "PK_graduate_studentsdata",
                schema: "CMS",
                table: "graduate_studentsdata");

            migrationBuilder.DropPrimaryKey(
                name: "PK_entry_recruit_studentsdata",
                schema: "CMS",
                table: "entry_recruit_studentsdata");

            migrationBuilder.DropPrimaryKey(
                name: "PK_drop_out_studentsdata",
                schema: "CMS",
                table: "drop_out_studentsdata");

            migrationBuilder.DropPrimaryKey(
                name: "PK_charge_studentsdata",
                schema: "CMS",
                table: "charge_studentsdata");

            migrationBuilder.RenameTable(
                name: "zhx_student_inreading",
                schema: "CMS",
                newName: "zhx_student_inreadings");

            migrationBuilder.RenameTable(
                name: "nograduate_studentsdata",
                schema: "CMS",
                newName: "nograduate_studentsdatas");

            migrationBuilder.RenameTable(
                name: "graduate_studentsdata",
                schema: "CMS",
                newName: "graduate_studentsdatas");

            migrationBuilder.RenameTable(
                name: "entry_recruit_studentsdata",
                schema: "CMS",
                newName: "entry_recruit_studentsdatas");

            migrationBuilder.RenameTable(
                name: "drop_out_studentsdata",
                schema: "CMS",
                newName: "drop_out_studentsdatas");

            migrationBuilder.RenameTable(
                name: "charge_studentsdata",
                schema: "CMS",
                newName: "charge_studentsdatas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_zhx_student_inreadings",
                schema: "CMS",
                table: "zhx_student_inreadings",
                column: "inReadingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_nograduate_studentsdatas",
                schema: "CMS",
                table: "nograduate_studentsdatas",
                column: "noGraduateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_graduate_studentsdatas",
                schema: "CMS",
                table: "graduate_studentsdatas",
                column: "graduateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_entry_recruit_studentsdatas",
                schema: "CMS",
                table: "entry_recruit_studentsdatas",
                column: "recruitStudentsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_drop_out_studentsdatas",
                schema: "CMS",
                table: "drop_out_studentsdatas",
                column: "dropOutId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_charge_studentsdatas",
                schema: "CMS",
                table: "charge_studentsdatas",
                column: "chargeId");
        }
    }
}
