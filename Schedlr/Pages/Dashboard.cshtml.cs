using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Schedlr.Models;
using static DataLibrary.BusinessLogic.EmployeeProcessor; // new function to add static class ;)
using static DataLibrary.BusinessLogic.ShiftProcessor; // new function to add static class ;)

namespace Schedlr.Pages
{
    public class DashboardModel : PageModel
    {
        private readonly ILogger<DashboardModel> _logger;

        public DashboardModel(ILogger<DashboardModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public DataLibrary.Models.EmployeeModel loggedEmployee { get; set; }


        [BindProperty(SupportsGet = true)] // binding to variable to use on front-end
        public List<ShiftModel> Shifts { get; set; }


        public void OnGet()
        {
            string name = loggedEmployee.FirstName;
            Shifts =  LoadShifts(loggedEmployee.EmployeeId); // loading the shifts affiliated with employee's id

        }
    }
}
