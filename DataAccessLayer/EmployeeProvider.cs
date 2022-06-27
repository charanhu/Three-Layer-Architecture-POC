using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class EmployeeProvider
    {
        //To get list all eployees
        public static DataTable GetEmployeeList()
        {
            return SqlHelper.GetTableFromSP("sp_EmployeeList");
        }

        //to insert new employee
        public static string InsertEmployee(string firstname, string lastname, DateTime dateofbirth, string email,  decimal salary, int departmentid, string address1, string address2, string createrusername)
        {
            List<SqlParameter> lstInsertEmployee = new List<SqlParameter>()
            {
                new SqlParameter("@firstname", SqlDbType.NVarChar) {Value = firstname},
                new SqlParameter("@lastname", SqlDbType.NVarChar) {Value = lastname},
                new SqlParameter("@dateofbirth", SqlDbType.DateTime) {Value = dateofbirth},
                new SqlParameter("@email", SqlDbType.NVarChar) {Value = email},
                new SqlParameter("@salary", SqlDbType.Decimal) {Value = salary},
                new SqlParameter("@departmentid", SqlDbType.Int) {Value = departmentid},
                new SqlParameter("@address1", SqlDbType.NVarChar) {Value = address1},
                new SqlParameter("@address2", SqlDbType.NVarChar) {Value = address2},
                new SqlParameter("@createrusername", SqlDbType.NVarChar) {Value = createrusername}
            };

            return SqlHelper.ExecuteNonQueryReturn("sp_AddEmployee", lstInsertEmployee.ToArray());
        }

        //to get employee by id
        public static DataTable GetEmployeeById(int id)
        {
            List<SqlParameter> lstGetEmployeeById = new List<SqlParameter>()
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = id}
            };
            return SqlHelper.GetTableFromSP("sp_GetEmployeeById", lstGetEmployeeById.ToArray());
        }

        //to Update the Employee Record
        public static string UpdateEmployee(int id, string firstname, string lastname, DateTime dateofbirth, string email, decimal salary, int departmentid, string address1, string address2, string updaterusername)
        {
            List<SqlParameter> lstUpdateEmployee = new List<SqlParameter>()
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = id},
                new SqlParameter("@firstname", SqlDbType.NVarChar) {Value = firstname},
                new SqlParameter("@lastname", SqlDbType.NVarChar) {Value = lastname},
                new SqlParameter("@dateofbirth", SqlDbType.DateTime) {Value = dateofbirth},
                new SqlParameter("@email", SqlDbType.NVarChar) {Value = email},
                new SqlParameter("@salary", SqlDbType.Decimal) {Value = salary},
                new SqlParameter("@departmentid", SqlDbType.Int) {Value = departmentid},
                new SqlParameter("@address1", SqlDbType.NVarChar) {Value = address1},
                new SqlParameter("@address2", SqlDbType.NVarChar) {Value = address2},
                new SqlParameter("@updaterusername", SqlDbType.NVarChar) {Value = updaterusername}
            };
            return SqlHelper.ExecuteNonQueryReturn("sp_UpdateEmployee", lstUpdateEmployee.ToArray());
        }

        // To Delete Employee By ID
        public static void DeleteEmployeeById(int id, string updaterusername)
        {
            List<SqlParameter> lstDeleteEmployeeById = new List<SqlParameter>()
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = id},
                new SqlParameter("@updaterusername", SqlDbType.NVarChar) {Value = updaterusername}
            };
            SqlHelper.ExecuteNonQuery("sp_DeleteEmployeeById", lstDeleteEmployeeById.ToArray());
        }
    }
}
