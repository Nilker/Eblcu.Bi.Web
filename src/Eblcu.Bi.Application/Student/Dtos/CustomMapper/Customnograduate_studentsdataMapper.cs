

using AutoMapper;

using Eblcu.Bi.Student;

namespace Eblcu.Bi.Student.Dtos.CustomMapper
{

	/// <summary>
    /// 配置nograduate_studentsdata的AutoMapper
    ///</summary>
	internal static class Customernograduate_studentsdataMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <nograduate_studentsdata, nograduate_studentsdataListDto>
    ();
    configuration.CreateMap <nograduate_studentsdataEditDto, nograduate_studentsdata>
        ();



        //// custom codes
         
        //// custom codes end

        }
        }
        }
