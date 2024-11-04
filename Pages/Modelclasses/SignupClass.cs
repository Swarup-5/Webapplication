using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Webapplication.Pages.Modelclasses
{
    public class SignupClass
    {
       
        [Required]

        public string firstname { get; set; }

        public string lastname { get; set; }

        [Required]
        [BindProperty]
        [StringLength(12, MinimumLength = 5)]

        public string password { get; set; }

        [Required]
        [Compare("password", ErrorMessage ="Password does not match")]
        public string confirmpasword { get; set; }


        
        [Required]
        [EmailAddress(ErrorMessage ="Enter Valid Email Address")]
        public string email { get; set; }

        [Range(18, 64, ErrorMessage = "Age cant be less than 18 and more than 64")]
        public int age { get; set; }
        
        

        [Required(ErrorMessage ="Please Select a Course")]
        [BindProperty]
        public string CourseList { get; set; }

        

        //IFormFile is build in interface used to manage all file upload operations 
        public IFormFile ImageFile { get; set; }
       
    }
}
