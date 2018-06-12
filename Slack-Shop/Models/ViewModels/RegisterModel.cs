using System.ComponentModel.DataAnnotations;

namespace Slack_Shop.Models.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Required field.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Required field.")]
        [DataType(DataType.Password, ErrorMessage = "Insecure password.")]
        public string Password { get; set; }
    }
}