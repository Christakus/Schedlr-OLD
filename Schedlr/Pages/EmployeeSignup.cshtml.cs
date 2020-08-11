using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Schedlr.Models;

namespace Schedlr.Pages
{
    public class EmployeeSignupModel : PageModel
    {

        [BindProperty]
        public EmployeeModel Employee { get; set; }

        public void OnGet()
        {

        }
    }
}
