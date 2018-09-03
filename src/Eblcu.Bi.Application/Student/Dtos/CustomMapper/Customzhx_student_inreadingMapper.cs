

using AutoMapper;
using Eblcu.Bi.Student;

namespace Eblcu.Bi.Student.Dtos.CustomMapper
{

	/// <summary>
    /// 配置zhx_student_inreading的AutoMapper
    ///</summary>
	internal static class Customerzhx_student_inreadingMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <zhx_student_inreading, zhx_student_inreadingListDto>
    ();
    configuration.CreateMap <zhx_student_inreadingEditDto, zhx_student_inreading>
        ();



        //// custom codes
         
        //// custom codes end

        }
        }
        }
