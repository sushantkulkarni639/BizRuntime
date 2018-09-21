using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASP.NETCore.Models;

namespace ASP.NETCore.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly ASP.NETCore.Models.ASPNETCoreContext _context;

        public CreateModel(ASP.NETCore.Models.ASPNETCoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public LaraTechnology LaraTechnology { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.LaraTechnology.Add(LaraTechnology);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}