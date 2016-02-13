using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Owen.UserControl.Api.Models
{
    public class ResetPasswordModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}