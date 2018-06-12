using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Slack_Shop.Models.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Required field.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Required field.")]
        [DataType(DataType.Password, ErrorMessage = "Insecure password.")]
        public string Password { get; set; }
    }
}