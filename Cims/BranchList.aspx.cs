using Cims.BAL;
using Cims.BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cims
{
    public partial class BranchList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ViewState["SortExpression"] = "branchname ASC";
                if (Session["Username"] != null && !string.IsNullOrEmpty(Session["RoleName"].ToString()))
                {
                    if (Session["RoleName"].ToString() == "Admin")
                        btnBrach.Visible = true;
                    else
                        btnBrach.Visible = false;
                }
                else
                {
                    btnBrach.Visible = false;
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

                    this.Page.MasterPageFile = "~/Admin.master";
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
            branchBAL branches = new branchBAL();
            var dataSet = branches.SelectAll();
            DataView dv = dataSet.Tables[0].DefaultView;
            dv.Sort = ViewState["SortExpression"].ToString();
            gvBranches.DataSource = dv;
            gvBranches.DataBind();
        }

        protected void gvBranches_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            branchBAL objBAl = new branchBAL();
            objBAl.Delete(int.Parse(Convert.ToString(e.Keys[0])));
            BindGrid();
        }

        protected void gvBranches_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvBranches.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void gvBranches_Sorting(object sender, GridViewSortEventArgs e)
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

        [WebMethod]
        public static branchBEL[] Bindbranch()
        {
            var branchlist = new List<branchBEL>();
            branchBAL collages = new branchBAL();
            var dataSet = collages.SelectAll();
            DataTable dt = dataSet.Tables[0];

            foreach (DataRow dr in dt.Rows)
            {
                var branchdetail = new branchBEL();
                branchdetail.Id = Convert.ToInt32(dr["id"].ToString());
                branchdetail.Branchname = dr["branchname"].ToString();
                branchdetail.Description = dr["description"].ToString();

                branchlist.Add(branchdetail);
            }

            return branchlist.ToArray();
        }

        protected void btnBrach_Click(object sender, EventArgs e)
        {
            Response.Redirect("Branch.aspx");
        }

        protected void gvBranches_PreRender(object sender, EventArgs e)
        {
            if (Session["Username"] != null && !string.IsNullOrEmpty(Session["RoleName"].ToString()))
            {
                if (Session["RoleName"].ToString() == "Admin")
                {
                    gvBranches.Columns[2].Visible = true;
                    gvBranches.Columns[3].Visible = true;
                }
                else
                {
                    gvBranches.Columns[2].Visible = false;
                    gvBranches.Columns[3].Visible = false;
                }

            }
            else
            {
                gvBranches.Columns[2].Visible = false;
                gvBranches.Columns[3].Visible = false;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            var searchstring = txtSearch.Text;
            branchBAL branch = new branchBAL();
            var dataSet = branch.Search(searchstring.ToLower());
            DataView dv = dataSet.Tables[0].DefaultView;
            dv.Sort = ViewState["SortExpression"].ToString();
            gvBranches.DataSource = dv;
            gvBranches.DataBind();
        }
    }
}