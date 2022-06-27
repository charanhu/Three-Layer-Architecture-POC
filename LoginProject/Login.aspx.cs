using BusinessLayer;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnLoginButtonClick(object sender, EventArgs e)
        {
            User obj = new User
            {
                UserName = txtUsername.Text,
                Password = txtPassword.Text
            };

            if (obj.checkUserDetails())
            {
                Session["User"]=obj.UserName;
                Response.Redirect("EmployeesList.aspx");
            }
            else
            {
                lblError.Text="Please enter Correct Username and Password";
                Clear();
                txtUsername.Focus();
            }
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
                }
            }
        }
    }
}