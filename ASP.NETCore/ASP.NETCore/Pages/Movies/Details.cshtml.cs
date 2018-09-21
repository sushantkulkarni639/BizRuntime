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
    public class DetailsModel : PageModel
    {
        private readonly ASP.NETCore.Models.ASPNETCoreContext _context;

        public DetailsModel(ASP.NETCore.Models.ASPNETCoreContext context)
        {
            _context = context;
        }

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
    }
}
