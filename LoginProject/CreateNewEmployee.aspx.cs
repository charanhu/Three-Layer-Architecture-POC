using BusinessLayer;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginProject
{
    public partial class CreateNewEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            btnSave.Enabled = true;
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["EmployeeID"] != null)
                {
                    int EmployeeID = Convert.ToInt32(Request.QueryString["EmployeeID"].ToString());
                    Employee employee = new Employee
                    {
                        Id = EmployeeID
                    };
                    DataTable EmployeeDataTable = employee.getEmployeeById();
                    
                    if (EmployeeDataTable != null)
                    {
                        lblHead.Text = "Update Employee";
                        hdEmpId.Value = EmployeeDataTable.Rows[0]["Id"].ToString();
                        txtFirstName.Text = EmployeeDataTable.Rows[0]["FirstName"].ToString();
                        txtLastName.Text = EmployeeDataTable.Rows[0]["LastName"].ToString();
                        txtEmail.Text = EmployeeDataTable.Rows[0]["Email"].ToString();
                        txtDepartment.Text = EmployeeDataTable.Rows[0]["DepartmentId"].ToString();
                        txtDate.Text = EmployeeDataTable.Rows[0]["DateOfBirth"].ToString();
                        txtSalary.Text = EmployeeDataTable.Rows[0]["Salary"].ToString();
                        txtAddress1.Text = EmployeeDataTable.Rows[0]["Address1"].ToString();
                        txtAddress2.Text = EmployeeDataTable.Rows[0]["Address2"].ToString();
                    }
                }
            }
        }


        //On Add Employee Button Click
        protected void OnSaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["EmployeeID"] != null)
                {
                    lblHead.Text = "Update Employee";
                }

                btnSave.Enabled = false;

                Employee AddEmployee = new Employee
                {
                    Id = Convert.ToInt32(hdEmpId.Value),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    DateOfBirth = Convert.ToDateTime(txtDate.Text),
                    Email = txtEmail.Text,
                    Salary = Convert.ToDecimal(txtSalary.Text),
                    DepartmentId = Convert.ToInt32(txtDepartment.Text),
                    Address1 = txtAddress1.Text,
                    Address2 = txtAddress2.Text
                };

                string ResultMessageFromDB = string.Empty;

                if (AddEmployee.Id == 0 && Session["User"] != null)
                {
                    AddEmployee.CreaterUsername = Session["User"].ToString();
                    ResultMessageFromDB = AddEmployee.insertEmployee();
                }
                else
                {
                    if (Session["User"] != null)
                    {
                        AddEmployee.UpdaterUsername = Session["User"].ToString();
                    }
                    ResultMessageFromDB = AddEmployee.updateEmployee();
                }
                string[] resMsg = ResultMessageFromDB.Split('|');

                if (resMsg[0].Contains("Success"))
                {
                    lblCheckDup.Text = resMsg[1];
                    Response.Redirect("EmployeesList.aspx");
                }    
                else
                {
                    lblCheckDup.Text = resMsg[1];
                    btnSave.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void OnBackButtonClick(object sender, EventArgs e)
        {
            Response.Redirect("EmployeesList.aspx");
        }

        protected void OnResetButtonClick(object sender, EventArgs e)
        {
            if (Request.QueryString["EmployeeID"] != null)
            {
                lblHead.Text = "Update Employee";
            }
            Clear();
        }
        private void Clear()
        {
            foreach (Control c in Page.Controls)
            {
                foreach (Control ctrl in c.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        ((TextBox)ctrl).Text = string.Empty;
                    }
                    txtDepartment.SelectedIndex = 0;
                }
            }
        }
    }
}