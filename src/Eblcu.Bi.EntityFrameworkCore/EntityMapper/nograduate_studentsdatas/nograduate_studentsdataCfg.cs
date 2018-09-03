


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Eblcu.Bi.Student;

namespace Eblcu.Bi.EntityMapper.nograduate_studentsdatas
{
public class nograduate_studentsdataCfg : IEntityTypeConfiguration<nograduate_studentsdata>
	{
	public void Configure(EntityTypeBuilder<nograduate_studentsdata>
		builder)
		{

		builder.ToTable("nograduate_studentsdata", YoYoAbpefCoreConsts.SchemaNames.CMS);

		builder.Property(a => a.uuid_).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.groupId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.companyId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.userId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.userName).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.createDate).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.modifiedDate).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.status).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.statusByUserId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.statusByUserName).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.statusDate).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.year).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.recruitBatchId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.provinceCode).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.stationId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.firstSubjectId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.studyLevelId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.gender).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.ageGroup).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.entrySpotId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.notGraduateReason).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.highLevelTime).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.notGraduateCnt).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.timeBase).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.graduateBatchId).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.totalCreditCnt).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.requiredCreditCnt).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.generalScoreCnt).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);
builder.Property(a => a.thesisScoreCnt).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);


		}
		}
		}


