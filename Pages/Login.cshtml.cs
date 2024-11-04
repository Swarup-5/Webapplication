//PAGE MODEL CLASS used to process the data submitted from the razoor view that is login.cshtml 

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using Webapplication.Data.Context;
using Webapplication.Data.Entity;
using Webapplication.Pages.Modelclass;

namespace Webapplication.Pages
{
    public class LoginModel : PageModel
    {
        public readonly ApplicationdbContext _context;  //


        public LoginModel(ApplicationdbContext dbcontext)
        {
            _context = dbcontext; 
        }

       /* public LoginClass newlogin { get; set; }*/

        [BindProperty]
        public LoginClass lc { get; set; }  // just to get refrence of corresponding model class



        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            } 
            var loginvalidate = _context.signUps.Where(p => p.Email == lc.Email &&  p.Password == lc.Password).FirstOrDefault();
           

            if (loginvalidate != null)
            {
                var Login = new Logintable
                {

                    Email = lc.Email,
                    Password = lc.Password,


                };
                TempData["messageLogin"] = "Sucessfully Login Completed";

                _context.logintable.Add(Login);
                _context.SaveChanges();

                return RedirectToPage("Index");
            }
            TempData["messageLoginfailed"] = "Sucessfully Failed Completed";
            return RedirectToPage();
           
        }

    }

}
