using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eblcu.Bi.StudentPermissions
{
    public static class StudentAppPermissions
    {
        //招生录取
        public const string EnrollRecruit = "EnrollRecruit";
        public const string EnrollRecruit_EveryYear_GQZ_EnrollRecruit_Count = "EnrollRecruit.EveryYear_GQZ_EnrollRecruit_Count";
        public const string EnrollRecruit_EveryYear_ZSB_EnrollRecruit_Count = "EnrollRecruit.EveryYear_ZSB_EnrollRecruit_Count";
        public const string EnrollRecruit_EveryYear_EnrollRecruit_Count = "EnrollRecruit.EveryYear_EnrollRecruit_Count";
        public const string EnrollRecruit_EveryYear_Recruit_Per = "EnrollRecruit.EveryYear_Recruit_Per";
        public const string EnrollRecruit_Province_Data = "EnrollRecruit.Province_Data";
        public const string EnrollRecruit_CurrentBatch_Recruit_AgeSex_Count = "EnrollRecruit.CurrentBatch_Recruit_AgeSex_Count";
        public const string EnrollRecruit_CurrentBatch_EveryProfession_Recruit_Count = "EnrollRecruit.CurrentBatch_EveryProfession_Recruit_Count";
        public const string EnrollRecruit_EveryStation_EnrollRecruit_Count = "EnrollRecruit.EveryStation_EnrollRecruit_Count";
        public const string EnrollRecruit_EveryBatch_Recruit_Sex_Count = "EnrollRecruit.EveryBatch_Recruit_Sex_Count";
        public const string EnrollRecruit_Profession_Data = "EnrollRecruit.Profession_Data";
        public const string EnrollRecruit_Station_Data = "EnrollRecruit.Station_Data";


        //学生缴费
        public const string StudentPay = "StudentPay";
        public const string StudentPay_EveryProfession_StudentFirstPay_Per = "StudentPay.EveryProfession_StudentFirstPay_Per";
        public const string StudentPay_EveryProfession_OldStudentRenewPay_Per = "StudentPay.EveryProfession_OldStudentRenewPay_Per";
        public const string StudentPay_EveryStation_StudentFirstPay_Per = "StudentPay.EveryStation_StudentFirstPay_Per";
        public const string StudentPay_EveryStation_OldStudentRenewPay_Per = "StudentPay.EveryStation_OldStudentRenewPay_Per";
        public const string StudentPay_EveryBatch_OldStudentRenewPay_Per = "StudentPay.EveryBatch_OldStudentRenewPay_Per";
        public const string StudentPay_DropOut_Term_Per = "StudentPay.DropOut_Term_Per";
        public const string StudentPay_DropOut_AgeSex_Count = "StudentPay.DropOut_AgeSex_Count";
        public const string StudentPay_DropOut_StudyLevel_Per = "StudentPay.DropOut_StudyLevel_Per";
        public const string StudentPay_EveryBatch_StudentFirstPay_Per = "StudentPay.EveryBatch_StudentFirstPay_Per";
        public const string StudentPay_EveryProfession_DropOut_Count = "StudentPay.EveryProfession_DropOut_Count";
        public const string StudentPay_EveryStation_DropOut_Count = "StudentPay.EveryStation_DropOut_Count";
        public const string StudentPay_EveryBatch_DropOut_Count = "StudentPay.EveryBatch_DropOut_Count";

        //学生管理
        public const string StudentManage = "StudentManage";
        public const string StudentManage_InReading_Profession_Data = "StudentManage.InReading_Profession_Data";
        public const string StudentManage_InReading_Profession_Per = "StudentManage.InReading_Profession_Per";
        public const string StudentManage_InReading_AgeSex_Count = "StudentManage.InReading_AgeSex_Count";
        public const string StudentManage_InReading_Batch_Count = "StudentManage.InReading_Batch_Count";
        public const string StudentManage_EveryYear_Graduate_Count = "StudentManage.EveryYear_Graduate_Count";
        public const string StudentManage_NotGraduate_2_5_Per = "StudentManage.NotGraduate_2_5_Per";
        public const string StudentManage_EveryStation_Graduate_Per = "StudentManage.EveryStation_Graduate_Per";
        public const string StudentManage_EveryProfession_Graduate_Per = "StudentManage.EveryProfession_Graduate_Per";
        public const string StudentManage_Graduate_StudyTime_Count = "StudentManage.Graduate_StudyTime_Count";
        public const string StudentManage_NotGraduate_Term = "StudentManage.NotGraduate_Term";
        public const string StudentManage_Graduate_EveryBatch_BZ_Data = "StudentManage.Graduate_EveryBatch_BZ_Data";
        public const string StudentManage_Graduate_EveryBatch_Term_Data = "StudentManage.Graduate_EveryBatch_Term_Data";
        public const string StudentManage_NotGraduate_5_5_AgeSex_Count = "StudentManage.NotGraduate_5_5_AgeSex_Count";
        public const string StudentManage_NotGraduate_5_5_Per = "StudentManage.NotGraduate_5_5_Per";
    }
}
