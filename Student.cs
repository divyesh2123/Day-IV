using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_IV
{
    public class Student
    {
        public int id;
        public string name;
        public int mark1;
        public int mark2;
        public int mark3;   

        public void input()
        {
            Console.WriteLine("Please enter id");
            id = Convert.ToInt32(Console.ReadLine());   


        }

        public void output()
        {

        }
    }
}
