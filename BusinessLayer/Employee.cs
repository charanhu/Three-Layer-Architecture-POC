using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Salary { get; set; }
        public string DepartmentName { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int DepartmentId { get; set; }
        public string CreaterUsername { get; set; }
        public string UpdaterUsername { get; set; }


        public static DataTable getEmployeeList()
        {
            DataTable emp_dt = EmployeeProvider.GetEmployeeList();
            return emp_dt;
        }
        public string insertEmployee()
        {
            return EmployeeProvider.InsertEmployee(FirstName, LastName, DateOfBirth, Email, Salary, DepartmentId, Address1, Address2, CreaterUsername);
        }
        public DataTable getEmployeeById()
        {
            return EmployeeProvider.GetEmployeeById(Id);
        }
        public string updateEmployee()
        {
            return EmployeeProvider.UpdateEmployee(Id, FirstName, LastName, DateOfBirth, Email, Salary, DepartmentId, Address1, Address2, UpdaterUsername);
        }
        public void deleteEmployeeById()
        {
            EmployeeProvider.DeleteEmployeeById(Id, UpdaterUsername);
        }
    }
}
