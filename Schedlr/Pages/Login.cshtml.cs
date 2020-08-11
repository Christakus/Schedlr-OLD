using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Schedlr.Models;

namespace Schedlr.Pages
{
    public class UserLoginModel : PageModel
    {

        [BindProperty]
        public LoginModel Login { get; set; }


        public void OnGet()
        {

        }

        // IActionResult is used for posts, as we are doing some type of action when submitting a form
        public IActionResult OnPost()
        {
            //if there is something invalid about the values that have been entered
            if(ModelState.IsValid == false)
            {
                // refreshing page
                return Page();
            }

            // Check Model Against Database

            // anonymous object being passed back to index, to welcome the Username
            return RedirectToPage("./Index", new { Login.Username });
        }

    }
}
