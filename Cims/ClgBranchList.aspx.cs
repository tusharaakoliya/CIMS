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
    public partial class ClgBranchList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ViewState["SortExpression"] = "CollageName ASC";
                BindGrid();
            }
        }
        private void BindGrid()
        {

            CollageBranchBAL clgbranch = new CollageBranchBAL();
            var dataSet = clgbranch.AdminSelectAll();
            DataView dv = dataSet.Tables[0].DefaultView;
            dv.Sort = ViewState["SortExpression"].ToString();
            gvclgbranch.DataSource = dv;
            gvclgbranch.DataBind();

        }

        protected void btnclgbranch_Click(object sender, EventArgs e)
        {
            Response.Redirect("CollageBranch.aspx");
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
    }
}