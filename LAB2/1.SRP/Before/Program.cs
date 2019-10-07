using System;

namespace Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single responsability principle");

            EmployeeService employeeService = new EmployeeService  
            {  
                FirstName = "John",  
                LastName = "Deo"  
            };  

            employeeService.EmployeeRegistration(employeeService);

            WriteEmployeesToConsole();

            Console.ReadKey();  
        }

        static void WriteEmployeesToConsole()
        {
            foreach (EmployeeService employee in StaticData.Employees)
            {
                Console.WriteLine(employee.FirstName + employee.LastName);  
            }
        }
    }
}
