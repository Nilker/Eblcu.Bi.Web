

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Eblcu.Bi.Test;

namespace Eblcu.Bi.Test.Dtos
{
    public class CreateOrUpdateProductInput
    {
        [Required]
        public ProductEditDto Product { get; set; }

    }
}