using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class DataBaseFirst         // THIS IS DATABASE FIRST APPROACH
    {
        static void Main(string[] args)
        {
            var context = new StudentEntities3();
            var entity = new Entity() // instance of table name
            {
                id = 1,
                name = "sushant",
                age = 25
            };
            context.Entities.Add(entity);
            context.SaveChanges();
        }
    }
}
