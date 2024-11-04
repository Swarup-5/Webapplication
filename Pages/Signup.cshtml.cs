    using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Webapplication.Data.Context;
using Webapplication.Data.Entity;
using Webapplication.Pages.Modelclasses;


namespace Webapplication.Pages
{
    public class SignupModel : PageModel
    {
        private readonly ApplicationdbContext _context; // create object of applicationdbContext class in order to send form data to table  
        private readonly IWebHostEnvironment _environment;

        public string? ffname;
        public string? llname;

      
        public SignupModel(ApplicationdbContext dbContext, IWebHostEnvironment _env)
        {
            _context = dbContext;
            _environment = _env;
        }
        [BindProperty]
        public List<SelectListItem> courseOptions { get; set; }


        [BindProperty]
        public SignupClass newusersign { get; set; }
          
        public void OnGet(/*Dictionary<string, string> getParas*/) { 
       
           /* if (getParas.TryGetValue("fname", out var fname))
            {
                this.ffname = fname;
            }
            if (getParas.TryGetValue("lname", out var lname))
            {
                this.llname = lname;
            }*/

            courseOptions = new List<SelectListItem>
            {
                new SelectListItem { Value = "Maths", Text = "Maths" },
                new SelectListItem { Value = "Science", Text = "Science" },
                new SelectListItem { Value = "Physics", Text = "Physics" },
                new SelectListItem { Value = "Biology", Text = "Biology" }


            };

        }


        public async Task<IActionResult> OnPostAsync()
        {


            if (!ModelState.IsValid)
            {

                return Page();
            }

            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(newusersign.ImageFile.FileName);

            string filePath = Path.Combine(_environment.WebRootPath, "Images", fileName);
            var fileStream = new FileStream(filePath, FileMode.Create);
            await newusersign.ImageFile.CopyToAsync(fileStream);
            var newUser = new Signuptable
            {
                FistName = newusersign.firstname,
                LastName = newusersign.lastname,
                Email = newusersign.email,
                Password = newusersign.password,
                ConfirmPassword = newusersign.confirmpasword,
                Course = newusersign.CourseList,
                age = newusersign.age,
                Userstatus= "active",
                isActive = true,
                imagepath = fileName,
            };  
           await _context.signUps.AddAsync(newUser);
           await  _context.SaveChangesAsync();

            TempData["messageSign-up"] = "Sucessfully Sign-up Completed";
            Console.WriteLine($" fname is {newusersign.firstname}\n lastname is {newusersign.lastname} and email is {newusersign.email}\n and age is {newusersign.age}\n and course is {newusersign.CourseList}\n");
            return RedirectToPage("Commonmessage");

        }


    }
}
