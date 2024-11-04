using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata.Ecma335;
using Webapplication.Data.Context;
using Webapplication.Data.Entity;

namespace Webapplication.Pages
{
    public class AdminHomepageModel : PageModel
    {
        
        public readonly ApplicationdbContext _context;  //


       
        public List<Signuptable> AdminHomepages { get; set; }


        public List<Producttablecs> prodcuttablecs { get; set; }
        public AdminHomepageModel(ApplicationdbContext dbcontext)
        {
            _context = dbcontext;
        }
        public void OnGet()
        {
        AdminHomepages = _context.signUps.ToList();
            prodcuttablecs = _context.prod.ToList();
        }

        public IActionResult OnPostUpdate(int id, bool status)
        {
            var user = _context.signUps.Find(id);
            if(user != null)
            {
                user.isActive = status;
                _context.SaveChanges();
            }
            return RedirectToPage();
        }


        public IActionResult OnPostUpdates(int id, bool newstatus)
        {
            var user = _context.signUps.Find(id);
            if (user != null)
            {
                user.isActive = newstatus;
                _context.SaveChanges();
            }
            return RedirectToPage();
        }

        public IActionResult OnPostDeleterecords(int id)
        {
            var user= _context.signUps.Find(id);
            if (user != null) {
                _context.signUps.Remove(user);
                _context.SaveChanges();
            }
            return RedirectToPage();
        }

        //public IActionResult   OnPostEditrecords(int id)
        //{

        //    var user = _context.signUps.Find(id);
        //    if (user != null)
        //    {
        //        TempData["userid"] = id;
        //        return RedirectToPage("Editform");
        //    }
        //    return RedirectToPage();
        //}

    }

}
   