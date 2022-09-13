using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class Employee
    {
        int eid,expirence;
        string ename,quilification;

        public void assignvalue()
        {
            eid = 16;
            ename = "vishakha"; 
            expirence = 2;
            quilification = "PG";
        }

        public string displaydetail()
        {
            return $"\nemployee details:\n eid : {eid} \nename : {ename} \nexpirence : {expirence} \nquilification : {quilification}";
        }
    }
}
