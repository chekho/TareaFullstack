using System.ComponentModel.DataAnnotations;

namespace AuthAPI_901.Dtos
{
    public class ResetPasswordDto
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Token { get; set; }
        [Required]
        [MinLength(6)]
        public string? NewPassword { get; set; }
    }
}
