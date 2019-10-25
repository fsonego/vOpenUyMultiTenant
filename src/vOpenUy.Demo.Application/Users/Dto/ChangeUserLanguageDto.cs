using System.ComponentModel.DataAnnotations;

namespace vOpenUy.Demo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}