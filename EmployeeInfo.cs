using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_IV
{
    public class EmployeeInfo1
    {
        public int EmployeeID=0;
        public string EmployeeName = "";

       
        
        public void Input()
        {
            Console.WriteLine("Please Enter EmploteeId");
            EmployeeID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter EmployeeName");
            EmployeeName = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine(EmployeeID);
            Console.WriteLine(EmployeeName);
        }

    }

   


}
