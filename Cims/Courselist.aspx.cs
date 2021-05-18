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
    public partial class Courselist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                ViewState["SortExpression"] = "course_id ASC";
                if (Session["Username"] != null && !string.IsNullOrEmpty(Session["RoleName"].ToString()))
                {
                    if (Session["RoleName"].ToString() == "Admin")
                        btncourse.Visible = true;
                    else
                        btncourse.Visible = false;
                }
                else
                {
                    btncourse.Visible = false;
                }
                BindGrid();
            }
            //BindGrid();
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            try
            {
                if (Session["Username"] != null && !string.IsNullOrEmpty(Session["RoleName"].ToString()))
                {
                    if (Session["RoleName"].ToString() == "Admin")
                    {
                        this.Page.MasterPageFile = "~/Admin.master";
                    }
                    else
                    {
                        this.Page.MasterPageFile = "~/Student.master";
                    }

                }
                else
                {
                    this.Page.MasterPageFile = "~/Student.master";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void BindGrid()
        {
            courseBAL collages = new courseBAL();
            var dataSet = collages.SelectAll();
            DataView dv = dataSet.Tables[0].DefaultView;
            dv.Sort = ViewState["SortExpression"].ToString();
            gvCourse.DataSource = dv;
            gvCourse.DataBind();
        }

        protected void gvCourse_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Company comp = new Company();
            //comp.CompanyID = int.Parse(Convert.ToString(e.Keys[0]));
            //comp.Delete();
            BindGrid();
        }

        protected void gvCourse_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCourse.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void gvCourse_Sorting(object sender, GridViewSortEventArgs e)
        {
            string[] strSortExpression = ViewState["SortExpression"].ToString().Split(' ');

            if (strSortExpression[0] == e.SortExpression)
            {
                if (strSortExpression[1] == "ASC")
                {
                    ViewState["SortExpression"] = e.SortExpression + " " + "DESC";
                }
                else
                {
                    ViewState["SortExpression"] = e.SortExpression + " " + "ASC";
                }
            }

            else
            {
                ViewState["SortExpression"] = e.SortExpression + " " + "ASC";
            }

            BindGrid();
        }

        protected void gvCourse_PreRender(object sender, EventArgs e)
        {
            if (Session["Username"] != null && !string.IsNullOrEmpty(Session["RoleName"].ToString()))
            {
                if (Session["RoleName"].ToString() == "Admin")
                {
                    gvCourse.Columns[2].Visible = true;
                    gvCourse.Columns[3].Visible = true;
                }
                else
                {
                    gvCourse.Columns[2].Visible = false;
                    gvCourse.Columns[3].Visible = false;
                }

            }
            else
            {
                gvCourse.Columns[2].Visible = false;
                gvCourse.Columns[3].Visible = false;
            }
        }

        protected void btnBrach_Click(object sender, EventArgs e)
        {
            Response.Redirect("Branch.aspx");
        }
    }


}