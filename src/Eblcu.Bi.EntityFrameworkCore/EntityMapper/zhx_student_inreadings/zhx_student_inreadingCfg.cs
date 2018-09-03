


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Eblcu.Bi.Student;

namespace Eblcu.Bi.EntityMapper.zhx_student_inreadings
{
public class zhx_student_inreadingCfg : IEntityTypeConfiguration<zhx_student_inreading>
	{
	public void Configure(EntityTypeBuilder<zhx_student_inreading>
		builder)
		{

		builder.ToTable("zhx_student_inreading", YoYoAbpefCoreConsts.SchemaNames.CMS);

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
builder.Property(a => a.inReadingCnt).HasMaxLength(YoYoAbpefCoreConsts.EntityLengthNames.Length64);


		}
		}
		}


