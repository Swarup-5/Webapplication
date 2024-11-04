using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Webapplication.Data.Context;
using Webapplication.Data.Entity;
using Webapplication.Pages.Modelclasses;

namespace Webapplication.Pages
{

    public class EditformModel : PageModel
    {
        public readonly ApplicationdbContext _context;

        public EditformModel(ApplicationdbContext dbContext)
        {
            _context = dbContext;
        }

        [BindProperty]
        public EditForm newusersigns { get; set; }
       
        public IActionResult OnGet(int id)
        {
            var user= _context.signUps.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                newusersigns = new EditForm
                {
                    firstname = user.FistName,
                    lastname = user.FistName,
                    age = user.age,
                    email = user.Email,
                    password = user.Password,
                    confirmpasword = user.ConfirmPassword,
                };
                return Page();
            }
        }
        public IActionResult OnPost(int id)
        {
            var user = _context.signUps.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                user.FistName = newusersigns.firstname;
                user.LastName = newusersigns.lastname;
                user.age = newusersigns.age;
                user.Email = newusersigns.email;
                user.Password = newusersigns.password;
                user.ConfirmPassword = newusersigns.confirmpasword;

            }
            _context.SaveChanges();
            return RedirectToPage("AdminHomepage");
        }


            }
        }

       