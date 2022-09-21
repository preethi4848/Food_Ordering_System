using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserLoginSignup.ViewModel
{
    public class Register
    {
        [Required]
        [Display(Name = "Name")]
        public string CustomerName { get; set; }

        //Required attribute implements validation on Model item that this fields is mandatory for user
        [Required]
        //We are also implementing Regular expression to check if email is valid like a1@test.com
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail id is not valid")]
        public string CustomerEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string CustomerPassword { get; set; }

        public string PhoneNo { get; set; }
    }
}
