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
    /// 招生录取
    /// </summary>
    [DontWrapResult]
    //[AbpAuthorize(StudentAppPermissions.EnrollRecruit)]

    public class EnrollRecruitAppService : BiAppServiceBase
    {

        private readonly IRepository<charge_studentsdata, long> _charge_studentsdataRepository;
        private readonly IRepository<drop_out_studentsdata, long> _drop_out_studentsdataRepository;
        private readonly IRepository<entry_recruit_studentsdata, long> _entry_recruit_studentsdataRepository;
        private readonly IRepository<graduate_studentsdata, long> _graduate_studentsdataRepository;
        private readonly IRepository<nograduate_studentsdata, long> _nograduate_studentsdataRepository;
        private readonly IRepository<zhx_student_inreading, long> _zhx_student_inreadingRepository;

        public EnrollRecruitAppService(
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
    }
}
