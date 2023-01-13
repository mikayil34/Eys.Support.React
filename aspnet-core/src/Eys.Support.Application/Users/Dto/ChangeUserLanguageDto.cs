using System.ComponentModel.DataAnnotations;

namespace Eys.Support.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}