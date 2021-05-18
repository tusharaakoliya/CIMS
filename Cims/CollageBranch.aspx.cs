using Cims.BAL;
using Cims.BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cims
{
    public partial class CollageBranch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindBranches();
            BindCollages();
            if (!this.IsPostBack)
            {

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var branchId = ddlBranch.SelectedValue;
            var clgId = ddlcollage.SelectedValue;
            var seat = txtSeat.Text;

            CollageBranchBEL branchDetail = new CollageBranchBEL();
            branchDetail.BranchId = Convert.ToInt32(branchId);
            branchDetail.CollageId = Convert.ToInt32(clgId);
            branchDetail.Seat = seat;

            CollageBranchBAL objBranch = new CollageBranchBAL();
            objBranch.insert(branchDetail);

            Response.Redirect("ClgBranchList.aspx");
        }

        private void BindBranches()
        {
            branchBAL ddlBranches = new branchBAL();
            DataSet ds = ddlBranches.SelectAll();
            ddlBranch.DataSource = ds;
            ddlBranch.DataTextField = "branchname";
            ddlBranch.DataValueField = "id";
            ddlBranch.DataBind();
        }

        private void BindCollages()
        {
            clglistBAL ddlCollage = new clglistBAL();
            DataSet ds = ddlCollage.SelectAll();
            ddlcollage.DataSource = ds;
            ddlcollage.DataTextField = "name";
            ddlcollage.DataValueField = "id";
            ddlcollage.DataBind();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("BranchList.aspx");
        }


    }
}