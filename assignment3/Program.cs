using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Employee e = new Employee();    
            s.assign();
            Console.WriteLine(s.display());
        
            e.assignvalue();
            Console.WriteLine(e.displaydetail());
        }
    }
}
