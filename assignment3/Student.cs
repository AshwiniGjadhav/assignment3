using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class Student
    {
        int roll_no;
        string name,address;
        long contact;

        public void assign()
        {
            roll_no=23;
            name = "monica";
            address = "pune";
            contact = 8923456712;
        }

    public string display()
        {
            return $"student details : \n rollno - {roll_no} \n name - {name} \n address - {address} \n contact - {contact}";
        }
    }
}
