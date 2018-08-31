using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    public class IndexerEg
    {
            int Id;
            double salary;
            string name, dpt, job, location;
            public IndexerEg (int Id,double salary, string name, string dpt, string job, string location)
            {
                this.Id = Id;
                this.salary = salary;
                this.name = name;
                this.dpt = dpt;
                this.job = job;
                this.location = location;
            }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return Id;
                else if (index == 1)
                    return salary;
                else if (index == 2)
                    return name;
                else if (index == 3)
                    return dpt;
                else if (index == 4)
                    return job;
                else if (index == 5)
                    return location;
                return null;
            }
            set
            {
                if (index == 0)
                    Id = (int)value;// ref type if we need to convert to values then unbox(type casting)
                else if (index == 1)
                    salary = (double)value;
                else if (index == 2)
                    name = (string)value;
                else if (index == 3)
                    dpt = (string)value;
                else if (index == 4)
                    job = (string)value;
                else if (index == 5)
                    location = (string)value;

            }
        }
    }
}
