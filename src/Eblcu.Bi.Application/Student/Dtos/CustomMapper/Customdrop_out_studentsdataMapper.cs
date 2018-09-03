

using AutoMapper;
using Eblcu.Bi.Student;

namespace Eblcu.Bi.Student.Dtos.CustomMapper
{

	/// <summary>
    /// 配置drop_out_studentsdata的AutoMapper
    ///</summary>
	internal static class Customerdrop_out_studentsdataMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <drop_out_studentsdata, drop_out_studentsdataListDto>
    ();
    configuration.CreateMap <drop_out_studentsdataEditDto, drop_out_studentsdata>
        ();



        //// custom codes
         
        //// custom codes end

        }
        }
        }
