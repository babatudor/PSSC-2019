namespace After
{
    public class EmployeeService
    {
        public void EmployeeRegistration(Employee employee)  
        {  
            StaticData.Employees.Add(employee);  
        }  
    }
}