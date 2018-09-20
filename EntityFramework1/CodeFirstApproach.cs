using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFramework1
{
    public class Post
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }

    class CodeFirstApproach
    {
        static void Main(string[] args)
        {

        }
    }
}
