﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace Eblcu.Bi.Student
{
    [Table("drop_out_studentsdata")]

    public class drop_out_studentsdata :Entity<long>
    {
        public string uuid_ { get; set; }
        public long dropOutId { get; set; }

        [Column("dropOutId")]

        public override long  Id { get; set; }

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
        public string entrySpotId { get; set; }
        public string semester { get; set; }
        public Nullable<int> enrollCnt { get; set; }
        public Nullable<int> dropOutCnt { get; set; }
        public Nullable<double> dropOutRatio { get; set; }
    }
}
