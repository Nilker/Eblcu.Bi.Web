using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Organizations;
using Abp.Web.Models;
using Eblcu.Bi.StudentPermissions;

namespace Eblcu.Bi.Student
{
    /// <summary>
    /// 学生缴费
    /// </summary>
    [DontWrapResult]
    //[AbpAuthorize(StudentAppPermissions.StudentPay)]

    public class StudentPayAppService : BiAppServiceBase
    {

        private readonly IRepository<charge_studentsdata, long> _charge_studentsdataRepository;
        private readonly IRepository<drop_out_studentsdata, long> _drop_out_studentsdataRepository;
        private readonly IRepository<entry_recruit_studentsdata, long> _entry_recruit_studentsdataRepository;
        private readonly IRepository<graduate_studentsdata, long> _graduate_studentsdataRepository;
        private readonly IRepository<nograduate_studentsdata, long> _nograduate_studentsdataRepository;
        private readonly IRepository<zhx_student_inreading, long> _zhx_student_inreadingRepository;

        public StudentPayAppService(
            IRepository<charge_studentsdata, long> charge_studentsdataRepository,
            IRepository<drop_out_studentsdata, long> drop_out_studentsdataRepository,
            IRepository<entry_recruit_studentsdata, long> entry_recruit_studentsdataRepository,
            IRepository<graduate_studentsdata, long> graduate_studentsdataRepository,
            IRepository<nograduate_studentsdata, long> nograduate_studentsdataRepository,
            IRepository<zhx_student_inreading, long> zhx_student_inreadingRepository
            )
        {
            _charge_studentsdataRepository = charge_studentsdataRepository;
            _drop_out_studentsdataRepository = drop_out_studentsdataRepository;
            _entry_recruit_studentsdataRepository = entry_recruit_studentsdataRepository;
            _graduate_studentsdataRepository = graduate_studentsdataRepository;
            _nograduate_studentsdataRepository = nograduate_studentsdataRepository;
            _zhx_student_inreadingRepository = zhx_student_inreadingRepository;
        }



        /// <summary>
        /// 各招生点学生首次缴费率排名
        /// </summary>
        /// <returns></returns>
        public ResultJsonObj EveryStation_StudentFirstPay_Per()
        {
            var entities = _charge_studentsdataRepository.GetAll().GroupBy(s => s.entrySpotId).Select(t =>
                new { studyCenter = t.Key, pre = ((double)t.Sum(r => r.partCnt.Value) / (double)t.Sum(r => r.wholeCnt.Value)).ToString("F2") }).ToList();

            return new ResultJsonObj(entities.Where(s => s.pre != "0.00").OrderByDescending(s => s.pre).ToList());
        }


        /// <summary>
        /// 获取批次列表 （charge_studentsdata表的）
        /// </summary>
        /// <returns></returns>
        public ResultJsonObj GetCharge_studentsdata_RecruitBatchIds()
        {
            var tem = _charge_studentsdataRepository.GetAll().Select(s => s.recruitBatchId).Distinct().OrderBy(s => s).ToList();
            return new ResultJsonObj(tem);
        }

        /// <summary>
        /// 各专业缴费率
        /// </summary>
        /// <param name="recruitBatchId">批次如 ：201803</param>
        /// <returns></returns>
        public ResultJsonObj EveryProfession_StudentFirstPay_Per(string recruitBatchId)
        {
            var tem = _charge_studentsdataRepository.GetAll()
                .WhereIf(!recruitBatchId.IsNullOrEmpty(), s => s.recruitBatchId == recruitBatchId)
                .GroupBy(s => s.firstSubjectId).Select(s => new
                {
                    profession = s.Key,
                    ra = ((double)s.Sum(t => t.partCnt.Value) / (double)s.Sum(t => t.wholeCnt.Value)).ToString("F2")
                }).ToList();

            return new ResultJsonObj(tem.OrderBy(s => s.ra));
        }

    }
}
