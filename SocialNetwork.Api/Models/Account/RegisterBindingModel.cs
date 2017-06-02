using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Api.Models.Account
{
    public class RegisterBindingModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
    }
}