using System;

namespace EmployeeManagement
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeePayRoll");
            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();

            employee.EmployeeName = "Bruce Wayne";
            employee.PhoneNumber = "87754465546";
            employee.Address = "Banglore";
            employee.Department = "Hr";
            employee.Gender = 'M';
            employee.BasicPay = 222000;
            employee.Deductions = 212;
            employee.TaxablePay = 454;
            employee.Tax = 465;
            employee.NetPay = 25898;
            employee.City = "Banglore";
            employee.Country = "India";
            employee.StartDate = DateTime.Now;
            //uc1
            repo.AddEmployee(employee);
            //uc2
            //repo.GetAllEmployee();
        }
    }
}
