using System;

namespace After
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single responsability principle");

            Employee john = new Employee  
            {  
                FirstName = "John",  
                LastName = "Deo"  
            };  
            Employee tudor = new Employee  
            {  
                FirstName = "Tudor",  
                LastName = "Baba"  
            };  


            EmployeeService service = new EmployeeService();
            service.EmployeeRegistration(john);
            service.EmployeeRegistration(tudor);

            WriteEmployeesToConsole();

            Console.ReadKey();  
        }

        static void WriteEmployeesToConsole()
        {
            foreach (Employee employee in StaticData.Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");  
            }
        }
    }
}
