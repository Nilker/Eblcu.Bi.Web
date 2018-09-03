

using System;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Eblcu.Bi.Student;

namespace Eblcu.Bi.Student.Dtos
{
    public class nograduate_studentsdataListDto : EntityDto<long>
    {

/// <summary>
/// uuid_
/// </summary>
public string uuid_ { get; set; }


/// <summary>
/// Id
/// </summary>
public long? Id { get; set; }


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
/// notGraduateReason
/// </summary>
public string notGraduateReason { get; set; }


/// <summary>
/// highLevelTime
/// </summary>
public string highLevelTime { get; set; }


/// <summary>
/// notGraduateCnt
/// </summary>
public Nullable<long> notGraduateCnt { get; set; }


/// <summary>
/// timeBase
/// </summary>
public Nullable<int> timeBase { get; set; }


/// <summary>
/// graduateBatchId
/// </summary>
public string graduateBatchId { get; set; }


/// <summary>
/// totalCreditCnt
/// </summary>
public Nullable<long> totalCreditCnt { get; set; }


/// <summary>
/// requiredCreditCnt
/// </summary>
public Nullable<long> requiredCreditCnt { get; set; }


/// <summary>
/// generalScoreCnt
/// </summary>
public Nullable<long> generalScoreCnt { get; set; }


/// <summary>
/// thesisScoreCnt
/// </summary>
public Nullable<long> thesisScoreCnt { get; set; }






		//// custom codes
 
        //// custom codes end
    }
}