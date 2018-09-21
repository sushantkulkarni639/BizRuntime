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
    public class IndexModel : PageModel
    {
        private readonly ASP.NETCore.Models.ASPNETCoreContext _context;

        public IndexModel(ASP.NETCore.Models.ASPNETCoreContext context)
        {
            _context = context;
        }

        public IList<LaraTechnology> LaraTechnology { get;set; }

        public async Task OnGetAsync()
        {
            LaraTechnology = await _context.LaraTechnology.ToListAsync();
        }
    }
}
