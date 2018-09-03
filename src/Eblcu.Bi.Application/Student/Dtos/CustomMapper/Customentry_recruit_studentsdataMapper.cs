

using AutoMapper;
using Eblcu.Bi.Student;

namespace Eblcu.Bi.Student.Dtos.CustomMapper
{

	/// <summary>
    /// 配置entry_recruit_studentsdata的AutoMapper
    ///</summary>
	internal static class Customerentry_recruit_studentsdataMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <entry_recruit_studentsdata, entry_recruit_studentsdataListDto>
    ();
    configuration.CreateMap <entry_recruit_studentsdataEditDto, entry_recruit_studentsdata>
        ();



        //// custom codes
         
        //// custom codes end

        }
        }
        }
