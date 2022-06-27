using BusinessLayer;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginProject
{
    public partial class EmployeesList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!Page.IsPostBack)
            {
                refreshData();
            }

        }
        public void refreshData()
        {
            GridView1.DataSource = Employee.getEmployeeList();
            GridView1.DataBind();
        }

        protected void OnLogoutButtonClick(object sender, EventArgs e)
        {
            Session["User"] = null;
            Response.Redirect("Login.aspx");
        }

        protected void OnAddEmployeeButtonClick(object sender, EventArgs e)
        {
            Response.Redirect("CreateNewEmployee.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                GridViewRow row=(GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
                Label lblEmpId = row.FindControl("lblId") as Label;

                Response.Redirect("CreateNewEmployee.aspx?EmployeeID="+ lblEmpId.Text.ToString());
            }

            if (e.CommandName == "Delete")
            {
                GridViewRow row = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
                Label lblEmpId = row.FindControl("lblId") as Label;
                Employee objEmployee = new Employee();
                objEmployee.Id = Convert.ToInt32(lblEmpId.Text);

                if (Session["User"] != null)
                {
                    objEmployee.UpdaterUsername = Session["User"].ToString();
                }

                objEmployee.deleteEmployeeById();
                Response.Redirect("EmployeesList.aspx");
            }

        }
    }
}