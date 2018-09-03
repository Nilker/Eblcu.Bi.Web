

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Eblcu.Bi.Student;

namespace Eblcu.Bi.Student.Dtos
{
    public class CreateOrUpdatecharge_studentsdataInput
    {
        [Required]
        public charge_studentsdataEditDto charge_studentsdata { get; set; }



		//// custom codes
 
        //// custom codes end
    }
}