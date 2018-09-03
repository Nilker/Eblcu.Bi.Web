

using AutoMapper;
using Eblcu.Bi.Student;

namespace Eblcu.Bi.Student.Dtos.CustomMapper
{

	/// <summary>
    /// 配置graduate_studentsdata的AutoMapper
    ///</summary>
	internal static class Customergraduate_studentsdataMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <graduate_studentsdata, graduate_studentsdataListDto>
    ();
    configuration.CreateMap <graduate_studentsdataEditDto, graduate_studentsdata>
        ();



        //// custom codes
         
        //// custom codes end

        }
        }
        }
