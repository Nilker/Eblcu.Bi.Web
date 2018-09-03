using System.ComponentModel.DataAnnotations;

namespace Eblcu.Bi.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}