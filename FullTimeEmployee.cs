using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_IV
{
    public class FullTimeEmployee
    {
        public int EmployeeId;
        public string EmployeeName;
        public int BasicSalary;
       
        public void Input()
        {
            Console.WriteLine("Please Enter Id");
            EmployeeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter EmployeeName");
            EmployeeName = Console.ReadLine();


            Console.WriteLine("Please Enter BasicSalary");
            BasicSalary = Convert.ToInt32(Console.ReadLine());

        }

        public void Output()
        {
            var calculateHRA = BasicSalary / 2;
            var Da = BasicSalary * 0.10;
            var finalSalary = BasicSalary + Da + calculateHRA;
            var tax = finalSalary * 0.10;
            var totalPay = finalSalary - tax;

            Console.WriteLine($"EmployeeID {EmployeeId}");
            Console.WriteLine($"EmployeeName {EmployeeName}");
            Console.WriteLine($"HRA {calculateHRA}");
            Console.WriteLine($"DA {Da}");
            Console.WriteLine($"totalPay {totalPay}");
        }
    }
}
