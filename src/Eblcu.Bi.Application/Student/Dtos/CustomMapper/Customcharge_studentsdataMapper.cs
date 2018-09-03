

using AutoMapper;
using Eblcu.Bi.Student;

namespace Eblcu.Bi.Student.Dtos.CustomMapper
{

    /// <summary>
    /// 配置charge_studentsdata的AutoMapper
    ///</summary>
    internal static class Customercharge_studentsdataMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<charge_studentsdata, charge_studentsdataListDto>
    ();
            configuration.CreateMap<charge_studentsdataEditDto, charge_studentsdata>
                ();



            //// custom codes

            //// custom codes end

        }
    }
}
