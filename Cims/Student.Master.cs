using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cims
{
    public partial class Student : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {

                lblmsg.Text = "Welcome " + Session["Username"].ToString();
                lnkbtnlogin.Visible = false;
                lnkbtnlogout.Visible = true;
                lnkbtnhome.Visible = false;
                lnkbtnregister.Visible = false;
                //lnkbtnprofile.Visible = true;
                lnkfillchoice.Visible = true;
            }

            if (Session["RoleName"] != null)
            {
                if (Session["RoleName"].ToString() == "Admin")
                {
                    adminTopMenu.Visible = true;
                    studentTopMenu.Visible = false;
                    publicTopMenu.Visible = false;
                    lnkfillchoice.Visible = false;
                }
                else if (Session["RoleName"].ToString() == "Student")
                {
                    adminTopMenu.Visible = false;
                    studentTopMenu.Visible = true;
                    publicTopMenu.Visible = false;
                }
                else
                {
                    adminTopMenu.Visible = false;
                    studentTopMenu.Visible = false;
                    publicTopMenu.Visible = true;
                }
            }
            else
            {
                adminTopMenu.Visible = false;
                studentTopMenu.Visible = false;
                publicTopMenu.Visible = true;
            }

            //if (Session["Username"] != null && !string.IsNullOrEmpty(Session["RoleName"].ToString()))
            //{
            //    if (Session["RoleName"].ToString() == "Admin")
            //        tdadminmenu.Visible = true;
            //    else
            //        tdadminmenu.Visible = false;
            //    tdConent.Attributes.Add("style", "width:100%");
            //}
            //else
            //{
            //    tdadminmenu.Visible = false;
            //    tdConent.Attributes.Add("style", "width:100%");
            //}
        }

        protected void lnkbtnlogout_Click(object sender, EventArgs e)
        {
            Session["Username"] = null;
            Session["UserId"] = null;
            Session["RoleName"] = null;
            Response.Redirect("Home.aspx");
        }
    }
}