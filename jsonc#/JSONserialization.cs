using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basics
{
    // related program is JSONProgram
    public class JSONserialization
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Degree
        {
            get;
            set;
        }
        public int Age
        {
            set; get;
        }
        public int Salary
        {
            set; get;
        }
        public List<string> Hobbies
        {
            get;
            set;
        }
        public override string ToString()
        {
            return string.Format("Student info:\n\tId:{0},\n\tName:{1},\n\tDegree:{2},\n\tAge:{3},\n\tSalary:{4}," + 
                "\n\tHobbies:{5}", Id, Name, Degree,Age,Salary, string.Join(",", Hobbies.ToArray()));
        }
    }
}
    