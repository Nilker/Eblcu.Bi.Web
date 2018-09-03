using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Eblcu.Bi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "CMS");
            migrationBuilder.CreateTable(
                name: "charge_studentsdatas",
                schema: "CMS",
                columns: table => new
                {
                    chargeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ageGroup = table.Column<int>(maxLength: 65, nullable: true),
                    companyId = table.Column<long>(maxLength: 65, nullable: true),
                    createDate = table.Column<DateTime>(maxLength: 65, nullable: true),
                    entrySpotId = table.Column<string>(maxLength: 65, nullable: true),
                    firstSubjectId = table.Column<string>(maxLength: 65, nullable: true),
                    gender = table.Column<int>(maxLength: 65, nullable: true),
                    groupId = table.Column<long>(maxLength: 65, nullable: true),
                    modifiedDate = table.Column<DateTime>(maxLength: 65, nullable: true),
                    partCnt = table.Column<long>(maxLength: 65, nullable: true),
                    partRatio = table.Column<double>(maxLength: 65, nullable: true),
                    provinceCode = table.Column<string>(maxLength: 65, nullable: true),
                    recruitBatchId = table.Column<string>(maxLength: 65, nullable: true),
                    stationId = table.Column<string>(maxLength: 65, nullable: true),
                    status = table.Column<int>(maxLength: 65, nullable: true),
                    statusByUserId = table.Column<long>(maxLength: 65, nullable: true),
                    statusByUserName = table.Column<string>(maxLength: 65, nullable: true),
                    statusDate = table.Column<DateTime>(maxLength: 65, nullable: true),
                    studentType = table.Column<string>(maxLength: 65, nullable: true),
                    studyLevelId = table.Column<string>(maxLength: 65, nullable: true),
                    userId = table.Column<long>(maxLength: 65, nullable: true),
                    userName = table.Column<string>(maxLength: 65, nullable: true),
                    uuid_ = table.Column<string>(maxLength: 65, nullable: true),
                    wholeCnt = table.Column<long>(maxLength: 65, nullable: true),
                    year = table.Column<int>(maxLength: 65, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_charge_studentsdatas", x => x.chargeId);
                });

            migrationBuilder.CreateTable(
                name: "drop_out_studentsdatas",
                schema: "CMS",
                columns: table => new
                {
                    dropOutId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ageGroup = table.Column<int>(maxLength: 65, nullable: true),
                    companyId = table.Column<long>(maxLength: 65, nullable: true),
                    createDate = table.Column<DateTime>(maxLength: 65, nullable: true),
                    dropOutCnt = table.Column<int>(maxLength: 65, nullable: true),
                    dropOutRatio = table.Column<double>(maxLength: 65, nullable: true),
                    enrollCnt = table.Column<int>(maxLength: 65, nullable: true),
                    entrySpotId = table.Column<string>(maxLength: 65, nullable: true),
                    firstSubjectId = table.Column<string>(maxLength: 65, nullable: true),
                    gender = table.Column<int>(maxLength: 65, nullable: true),
                    groupId = table.Column<long>(maxLength: 65, nullable: true),
                    modifiedDate = table.Column<DateTime>(maxLength: 65, nullable: true),
                    provinceCode = table.Column<string>(maxLength: 65, nullable: true),
                    recruitBatchId = table.Column<string>(maxLength: 65, nullable: true),
                    semester = table.Column<string>(maxLength: 65, nullable: true),
                    stationId = table.Column<string>(maxLength: 65, nullable: true),
                    status = table.Column<int>(maxLength: 65, nullable: true),
                    statusByUserId = table.Column<long>(maxLength: 65, nullable: true),
                    statusByUserName = table.Column<string>(maxLength: 65, nullable: true),
                    statusDate = table.Column<DateTime>(maxLength: 65, nullable: true),
                    studyLevelId = table.Column<string>(maxLength: 65, nullable: true),
                    userId = table.Column<long>(maxLength: 65, nullable: true),
                    userName = table.Column<string>(maxLength: 65, nullable: true),
                    uuid_ = table.Column<string>(maxLength: 65, nullable: true),
                    year = table.Column<int>(maxLength: 65, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drop_out_studentsdatas", x => x.dropOutId);
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
