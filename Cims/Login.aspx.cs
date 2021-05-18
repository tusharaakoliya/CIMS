using Cims.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cims
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            LoginBAL objLoginDal = new LoginBAL();
            DataTable dt = objLoginDal.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            
            if (dt.Rows.Count > 0)
            {
                Session["UserId"] = dt.Rows[0]["UserId"].ToString();
                Session["Username"] = dt.Rows[0]["Username"].ToString();
                var roleId = dt.Rows[0]["RoleId"].ToString();
                if (!string.IsNullOrEmpty(roleId))
                {
                    if (roleId == "1")
                        Session["RoleName"] = "Admin";
                    else
                    {
                        Session["RoleName"] = "Student";
                        StudentBAL objStudentBAL = new StudentBAL();
                        DataSet ds = objStudentBAL.SelectByuser(Convert.ToInt32(Session["UserId"]));
                        var dt1 = ds.Tables[0];
                        if (dt1.Rows.Count > 0)
                        {
                            Session["StudentId"] = dt1.Rows[0]["StudentId"].ToString();
                        }


                    }
                }

                Response.Redirect("Home.aspx");

            }
            else
            {
                //return false;
                // lblMessage.Text = "Invalid UserName or Password";
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Invalid UserName or Password');", true);
            }
        }
    }
}