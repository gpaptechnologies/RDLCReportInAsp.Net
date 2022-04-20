using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Microsoft.Reporting.WebForms;

namespace RDLC
{
    public partial class EmployeeDetailsWithRDLC : System.Web.UI.Page
    {
        BLL_EmployeeDetails objBLL_EmployeeDetails = new BLL_EmployeeDetails();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetEmployeeDetails();
            }
        }

        void GetEmployeeDetails()
        {
            DataTable dtEmployees = null;
            dtEmployees = objBLL_EmployeeDetails.GetEmployeedetails();

            if (dtEmployees.Rows.Count > 0)
            {
                rvEmployeeReport.LocalReport.ReportPath = "EmployeeDetails.rdlc";
                rvEmployeeReport.LocalReport.DataSources.Clear();
                rvEmployeeReport.LocalReport.DataSources.Add(new ReportDataSource("DataSet_EmployeeDetails", dtEmployees));
                rvEmployeeReport.LocalReport.Refresh();
            }
            else
            {
                lblMessage.Text = "Data not found...!";
            }
        }
        
    }
}