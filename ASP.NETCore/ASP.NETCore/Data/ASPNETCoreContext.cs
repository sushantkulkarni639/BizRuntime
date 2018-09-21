using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETCore.Models
{
    public class ASPNETCoreContext : DbContext
    {
        public ASPNETCoreContext (DbContextOptions<ASPNETCoreContext> options)
            : base(options)
        {
        }

        public DbSet<ASP.NETCore.Models.LaraTechnology> LaraTechnology { get; set; }
    }
}
