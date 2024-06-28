using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mess_management.Models
{
    public class RegisterViewModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NID { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
    }
}