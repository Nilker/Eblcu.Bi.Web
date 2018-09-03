using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;

namespace Eblcu.Bi.Student
{
    /// <summary>
    /// 在读学生信息
    /// </summary>
    [Table("zhx_student_inreading")]
    public  class zhx_student_inreading : Entity<long>
    {
        public string uuid_ { get; set; }
        //public long inReadingId { get; set; }
        [Column("inReadingId")]
        public override long Id { get; set; }

        public Nullable<long> groupId { get; set; }
        public Nullable<long> companyId { get; set; }
        public Nullable<long> userId { get; set; }
        public string userName { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> modifiedDate { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<long> statusByUserId { get; set; }
        public string statusByUserName { get; set; }
        public Nullable<System.DateTime> statusDate { get; set; }
        public Nullable<int> year { get; set; }
        public string recruitBatchId { get; set; }
        public string provinceCode { get; set; }
        public string stationId { get; set; }
        public string firstSubjectId { get; set; }
        public string studyLevelId { get; set; }
        public Nullable<int> gender { get; set; }
        public Nullable<int> ageGroup { get; set; }
        public Nullable<long> inReadingCnt { get; set; }
    }
}
