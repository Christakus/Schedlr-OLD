using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedlr.Models
{
    public class EmployeeModel
    {

        public int EmployeeId { get; set;}
        public string EmployeeJobTitle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ConfirmEmail { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
