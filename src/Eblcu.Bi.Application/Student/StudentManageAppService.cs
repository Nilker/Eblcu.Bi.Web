using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Organizations;
using Abp.Web.Models;
using Eblcu.Bi.StudentPermissions;

namespace Eblcu.Bi.Student
{
    /// <summary>
    /// 学生管理
    /// </summary>
    [DontWrapResult]
    //[AbpAuthorize(StudentAppPermissions.StudentManage)]

    public class StudentManageAppService : BiAppServiceBase
    {

        private readonly IRepository<charge_studentsdata, long> _charge_studentsdataRepository;
        private readonly IRepository<drop_out_studentsdata, long> _drop_out_studentsdataRepository;
        private readonly IRepository<entry_recruit_studentsdata, long> _entry_recruit_studentsdataRepository;
        private readonly IRepository<graduate_studentsdata, long> _graduate_studentsdataRepository;
        private readonly IRepository<nograduate_studentsdata, long> _nograduate_studentsdataRepository;
        private readonly IRepository<zhx_student_inreading, long> _zhx_student_inreadingRepository;

        public StudentManageAppService(
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
        /// 在学学生年龄性别比例
        /// </summary>
        /// <returns></returns>
        public ResultJsonObj InReading_AgeSex_Count()
        {
            var entities = _zhx_student_inreadingRepository.GetAll().Where(s => s.recruitBatchId == "201709").GroupBy(s => s.ageGroup)
                .Select(s => new
                {
                    age = s.Key,
                    //ageDesc =s.Key.Value==1? "18岁以下":s.Key.Value==2? "19-25岁":s.Key.Value==3?"26-30岁":s.Key.Value==4? "31-40岁": "40岁以上",
                    num = s.Sum(t => t.inReadingCnt).Value
                }).ToList();


            return new ResultJsonObj(entities);
        }

        /// <summary>
        /// 在籍学生批次分布
        /// </summary>
        /// <returns></returns>
        public ResultJsonObj InReading_Batch_Count()
        {
            var entities = _zhx_student_inreadingRepository.GetAll().GroupBy(s => s.recruitBatchId)
                .Select(s => new
                {
                    recruitBatchId = s.Key,
                    num = s.Sum(t => t.inReadingCnt)

                }).ToList();

            return new ResultJsonObj(entities.Where(s => s.num != 0).OrderBy(s => s.recruitBatchId));
        }
    }
}
