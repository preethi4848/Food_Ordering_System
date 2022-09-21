using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserLoginSignup.ViewModel
{
    public class LoginViewModel
    {
        
            [Required]
            [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail id is not valid")]
            public string CustomerEmail { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string CustomerPassword { get; set; }
        }
    }
