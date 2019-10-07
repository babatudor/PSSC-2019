namespace Before
{
    public class EmployeeService
    {
        public string FirstName { get; set; }  
        public string LastName { get; set; }  
  
        public void EmployeeRegistration(EmployeeService employee)  
        {  
            StaticData.Employees.Add(employee);  
        }  
    }
}