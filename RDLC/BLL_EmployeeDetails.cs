using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace RDLC
{
    public class BLL_EmployeeDetails
    {
        public static string connectionstring()
        {
            string cstring = string.Empty;
            cstring = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            return cstring;
        }

        public DataTable GetEmployeedetails()
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataAdapter sqlda = null;
            DataTable dtEmployeess = null;

            using (connection = new SqlConnection(connectionstring()))
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "USP_GETEMPLOYEEDETAILS";
                sqlda = new SqlDataAdapter(command);
                dtEmployeess = new DataTable();
                sqlda.Fill(dtEmployeess);
            }
            return dtEmployeess;
        }
    }
}