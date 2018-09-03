

using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using Eblcu.Bi.Student;

namespace Eblcu.Bi.Student.Dtos
{
    public class drop_out_studentsdataEditDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public long? Id { get; set; }


        /// <summary>
        /// uuid_
        /// </summary>
        public string uuid_ { get; set; }


        /// <summary>
        /// dropOutId
        /// </summary>
        public long dropOutId { get; set; }



        /// <summary>
        /// groupId
        /// </summary>
        public Nullable<long> groupId { get; set; }


        /// <summary>
        /// companyId
        /// </summary>
        public Nullable<long> companyId { get; set; }


        /// <summary>
        /// userId
        /// </summary>
        public Nullable<long> userId { get; set; }


        /// <summary>
        /// userName
        /// </summary>
        public string userName { get; set; }


        /// <summary>
        /// createDate
        /// </summary>
        public Nullable<System.DateTime> createDate { get; set; }


        /// <summary>
        /// modifiedDate
        /// </summary>
        public Nullable<System.DateTime> modifiedDate { get; set; }


        /// <summary>
        /// status
        /// </summary>
        public Nullable<int> status { get; set; }


        /// <summary>
        /// statusByUserId
        /// </summary>
        public Nullable<long> statusByUserId { get; set; }


        /// <summary>
        /// statusByUserName
        /// </summary>
        public string statusByUserName { get; set; }


        /// <summary>
        /// statusDate
        /// </summary>
        public Nullable<System.DateTime> statusDate { get; set; }


        /// <summary>
        /// year
        /// </summary>
        public Nullable<int> year { get; set; }


        /// <summary>
        /// recruitBatchId
        /// </summary>
        public string recruitBatchId { get; set; }


        /// <summary>
        /// provinceCode
        /// </summary>
        public string provinceCode { get; set; }


        /// <summary>
        /// stationId
        /// </summary>
        public string stationId { get; set; }


        /// <summary>
        /// firstSubjectId
        /// </summary>
        public string firstSubjectId { get; set; }


        /// <summary>
        /// studyLevelId
        /// </summary>
        public string studyLevelId { get; set; }


        /// <summary>
        /// gender
        /// </summary>
        public Nullable<int> gender { get; set; }


        /// <summary>
        /// ageGroup
        /// </summary>
        public Nullable<int> ageGroup { get; set; }


        /// <summary>
        /// entrySpotId
        /// </summary>
        public string entrySpotId { get; set; }


        /// <summary>
        /// semester
        /// </summary>
        public string semester { get; set; }


        /// <summary>
        /// enrollCnt
        /// </summary>
        public Nullable<int> enrollCnt { get; set; }


        /// <summary>
        /// dropOutCnt
        /// </summary>
        public Nullable<int> dropOutCnt { get; set; }


        /// <summary>
        /// dropOutRatio
        /// </summary>
        public Nullable<double> dropOutRatio { get; set; }






        //// custom codes

        //// custom codes end
    }
}