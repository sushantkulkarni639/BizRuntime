using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP.NETCore.Models;

namespace ASP.NETCore.Pages.Movies
{
    public class EditModel : PageModel
    {
        private readonly ASP.NETCore.Models.ASPNETCoreContext _context;

        public EditModel(ASP.NETCore.Models.ASPNETCoreContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(LaraTechnology).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LaraTechnologyExists(LaraTechnology.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LaraTechnologyExists(int id)
        {
            return _context.LaraTechnology.Any(e => e.ID == id);
        }
    }
}
