using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SupermarketWEB.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly SupermarketContext _context;

        public CreateModel(SupermarketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Product { get; set; }

        public SelectList CategoryList { get; set; }
        public SelectList ProviderList { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            CategoryList = new SelectList(_context.Categories, "Id", "Id"); 
            ProviderList = new SelectList(_context.Providers, "Id", "Id"); 
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                CategoryList = new SelectList(_context.Categories, "Id", "Id");
                ProviderList = new SelectList(_context.Providers, "Id", "Id");
                return Page();
            }

            _context.Products.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
