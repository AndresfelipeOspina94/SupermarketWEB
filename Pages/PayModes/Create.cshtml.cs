using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Data;
using SupermarketWEB.Models;
using System.Threading.Tasks;

namespace SupermarketWEB.Pages.PayModes
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly SupermarketContext _context;

        public CreateModel(SupermarketContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        [BindProperty]
        public PayMode PayMode { get; set; } = new PayMode();

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || PayMode == null)
            {
                return Page();
            }

            _context.PayModes.Add(PayMode);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
