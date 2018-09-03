using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Eblcu.Bi.Migrations
{
    public partial class OK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "entry_recruit_studentsdatas",
                schema: "CMS",
                columns: table => new
                {
                    recruitStudentsId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ageGroup = table.Column<int>(maxLength: 65, nullable: true),
                    companyId = table.Column<long>(maxLength: 65, nullable: true),
                    createDate = table.Column<DateTime>(maxLength: 65, nullable: true),
                    enrollCnt = table.Column<int>(maxLength: 65, nullable: true),
                    firstSubjectId = table.Column<string>(maxLength: 65, nullable: true),
                    gender = table.Column<int>(maxLength: 65, nullable: true),
                    groupId = table.Column<long>(maxLength: 65, nullable: true),
                    modifiedDate = table.Column<DateTime>(maxLength: 65, nullable: true),
                    provinceCode = table.Column<string>(maxLength: 65, nullable: true),
                    recruitBatchId = table.Column<int>(maxLength: 65, nullable: true),
                    recruitCnt = table.Column<int>(maxLength: 65, nullable: true),
                    recruitRatio = table.Column<double>(maxLength: 65, nullable: true),
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
                    table.PrimaryKey("PK_entry_recruit_studentsdatas", x => x.recruitStudentsId);
                });

            migrationBuilder.CreateTable(
                name: "graduate_studentsdatas",
                schema: "CMS",
                columns: table => new
                {
                    graduateId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ageGroup = table.Column<int>(maxLength: 65, nullable: true),
                    companyId = table.Column<long>(maxLength: 65, nullable: true),
                    createDate = table.Column<DateTime>(maxLength: 65, nullable: true),
                    entrySpotId = table.Column<string>(maxLength: 65, nullable: true),
                    firstSubjectId = table.Column<string>(maxLength: 65, nullable: true),
                    gender = table.Column<int>(maxLength: 65, nullable: true),
                    graduateBatchId = table.Column<string>(maxLength: 65, nullable: true),
                    graduateCnt = table.Column<long>(maxLength: 65, nullable: true),
                    groupId = table.Column<long>(maxLength: 65, nullable: true),
                    modifiedDate = table.Column<DateTime>(maxLength: 65, nullable: true),
                    provinceCode = table.Column<string>(maxLength: 65, nullable: true),
                    recruitBatchId = table.Column<string>(maxLength: 65, nullable: true),
                    stationId = table.Column<string>(maxLength: 65, nullable: true),
                    status = table.Column<int>(maxLength: 65, nullable: true),
                    statusByUserId = table.Column<long>(maxLength: 65, nullable: true),
                    statusByUserName = table.Column<string>(maxLength: 65, nullable: true),
                    statusDate = table.Column<DateTime>(maxLength: 65, nullable: true),
                    studyLevelId = table.Column<string>(maxLength: 65, nullable: true),
                    studyTime = table.Column<string>(maxLength: 65, nullable: true),
                    userId = table.Column<long>(maxLength: 65, nullable: true),
                    userName = table.Column<string>(maxLength: 65, nullable: true),
                    uuid_ = table.Column<string>(maxLength: 65, nullable: true),
                    year = table.Column<int>(maxLength: 65, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_graduate_studentsdatas", x => x.graduateId);
                });

            migrationBuilder.CreateTable(
                name: "nograduate_studentsdatas",
                schema: "CMS",
                columns: table => new
                {
                    noGraduateId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ageGroup = table.Column<int>(maxLength: 65, nullable: true),
                    companyId = table.Column<long>(maxLength: 65, nullable: true),
                    createDate = table.Column<DateTime>(maxLength: 65, nullable: true),
                    entrySpotId = table.Column<string>(maxLength: 65, nullable: true),
                    firstSubjectId = table.Column<string>(maxLength: 65, nullable: true),
                    gender = table.Column<int>(maxLength: 65, nullable: true),
                    generalScoreCnt = table.Column<long>(maxLength: 65, nullable: true),
                    graduateBatchId = table.Column<string>(maxLength: 65, nullable: true),
                    groupId = table.Column<long>(maxLength: 65, nullable: true),
                    highLevelTime = table.Column<string>(maxLength: 65, nullable: true),
                    modifiedDate = table.Column<DateTime>(maxLength: 65, nullable: true),
                    notGraduateCnt = table.Column<long>(maxLength: 65, nullable: true),
                    notGraduateReason = table.Column<string>(maxLength: 65, nullable: true),
                    provinceCode = table.Column<string>(maxLength: 65, nullable: true),
                    recruitBatchId = table.Column<string>(maxLength: 65, nullable: true),
                    requiredCreditCnt = table.Column<long>(maxLength: 65, nullable: true),
                    stationId = table.Column<string>(maxLength: 65, nullable: true),
                    status = table.Column<int>(maxLength: 65, nullable: true),
                    statusByUserId = table.Column<long>(maxLength: 65, nullable: true),
                    statusByUserName = table.Column<string>(maxLength: 65, nullable: true),
                    statusDate = table.Column<DateTime>(maxLength: 65, nullable: true),
                    studyLevelId = table.Column<string>(maxLength: 65, nullable: true),
                    thesisScoreCnt = table.Column<long>(maxLength: 65, nullable: true),
                    timeBase = table.Column<int>(maxLength: 65, nullable: true),
                    totalCreditCnt = table.Column<long>(maxLength: 65, nullable: true),
                    userId = table.Column<long>(maxLength: 65, nullable: true),
                    userName = table.Column<string>(maxLength: 65, nullable: true),
                    uuid_ = table.Column<string>(maxLength: 65, nullable: true),
                    year = table.Column<int>(maxLength: 65, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nograduate_studentsdatas", x => x.noGraduateId);
                });

            migrationBuilder.CreateTable(
                name: "zhx_student_inreadings",
                schema: "CMS",
                columns: table => new
                {
                    inReadingId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ageGroup = table.Column<int>(maxLength: 65, nullable: true),
                    companyId = table.Column<long>(maxLength: 65, nullable: true),
                    createDate = table.Column<DateTime>(maxLength: 65, nullable: true),
                    firstSubjectId = table.Column<string>(maxLength: 65, nullable: true),
                    gender = table.Column<int>(maxLength: 65, nullable: true),
                    groupId = table.Column<long>(maxLength: 65, nullable: true),
                    inReadingCnt = table.Column<long>(maxLength: 65, nullable: true),
                    modifiedDate = table.Column<DateTime>(maxLength: 65, nullable: true),
                    provinceCode = table.Column<string>(maxLength: 65, nullable: true),
                    recruitBatchId = table.Column<string>(maxLength: 65, nullable: true),
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
                    table.PrimaryKey("PK_zhx_student_inreadings", x => x.inReadingId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "entry_recruit_studentsdatas",
                schema: "CMS");

            migrationBuilder.DropTable(
                name: "graduate_studentsdatas",
                schema: "CMS");

            migrationBuilder.DropTable(
                name: "nograduate_studentsdatas",
                schema: "CMS");

            migrationBuilder.DropTable(
                name: "zhx_student_inreadings",
                schema: "CMS");
        }
    }
}
