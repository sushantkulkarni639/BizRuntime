using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP.NETCore.Models;

namespace ASP.NETCore.Pages.Movies
{
    public class DeleteModel : PageModel
    {
        private readonly ASP.NETCore.Models.ASPNETCoreContext _context;

        public DeleteModel(ASP.NETCore.Models.ASPNETCoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public LaraTechnology LaraTechnology { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LaraTechnology = await _context.LaraTechnology.FirstOrDefaultAsync(m => m.ID == id);

            if (LaraTechnology == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LaraTechnology = await _context.LaraTechnology.FindAsync(id);

            if (LaraTechnology != null)
            {
                _context.LaraTechnology.Remove(LaraTechnology);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
