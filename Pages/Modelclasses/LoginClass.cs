using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Webapplication.Pages.Modelclass      /* MODEL CLASS*/ 
{ 
    public class LoginClass
    {
        

    
           
        //public string Name { get; set; }

        [Required(ErrorMessage ="Email cant be empty")] // custom validation msg can be shown using required annotation
        [BindProperty]
        public string Email { get; set; }


        public String Password { get; set; }

        //[BindProperty]
        //public string Message { get; set; }
    }
}
