using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Owen.UserControl.Api.Models
{
    public class ChangePasswordModel
    {
        
        public string Password { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmNewPassword { get; set; }
    }
}