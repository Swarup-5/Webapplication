using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Webapplication.Data.Context;
using Webapplication.Data.Entity;
using Webapplication.Pages.Modelclasses;

namespace Webapplication.Pages.Shared
{


    public class ProductModel : PageModel
    {
        public readonly ApplicationdbContext _context;




        public ProductModel(ApplicationdbContext dbContext)
        {
            _context = dbContext;
        }

        [BindProperty]
        public Product product { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var newproduct = new Producttablecs
            {
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                Quantity= product.Quantity,
                Category= product.Category,
                IsActive = true

            };

            _context.prod.Add(newproduct);
            _context.SaveChanges();

            return RedirectToPage("AdminHomePage");
        }
    }
}
