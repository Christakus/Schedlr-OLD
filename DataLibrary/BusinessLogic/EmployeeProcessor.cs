using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class EmployeeProcessor
    {
        // function to create new employee
        public static int CreateEmployee(int employeeId, string jobTitle, string firstName, 
            string lastName, string emailAddress)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeId,
                JobTitle = jobTitle,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress

            };

            string sql = @"insert into dbo.Employee (EmployeeId, JobTitle, FirstName, LastName, EmailAddress)
                            values (@EmployeeId, @JobTitle, @FirstName, @LastName, @EmailAddress);";

            return SQLDataAccess.SaveData(sql, data);
        }

        // function to load employee
        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select Id, EmployeId, JobTitle, FirstName, LastName, EmailAddress 
                            from dbo.Employee";

            return SQLDataAccess.LoadData<EmployeeModel>(sql);
        }

    }
}
