using System.ComponentModel.DataAnnotations;

namespace Eblcu.Bi.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
