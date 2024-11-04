using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Webapplication.Data.Context;
using Webapplication.Pages.Modelclasses;

namespace Webapplication.Pages
{
    public class AdminLoginModel : PageModel
    {

        public readonly ApplicationdbContext _context;
        [BindProperty]

        public AdminClass adminclass { get; set; }


        public AdminLoginModel(ApplicationdbContext context)
        {
            _context = context;
           
        }

        

        public void OnGet()
        {
           

        }

        public IActionResult OnPost()
        {

            if ((adminclass.Adminname.Equals("admin"))  &&(adminclass.Adminpassowrd.Equals("admin")))
            {
                return RedirectToPage("AdminHomepage");
            }
           else
            {
                return RedirectToPage();
            }
        }
    }
}
