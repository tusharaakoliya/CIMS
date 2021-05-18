using Cias.DAL;
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
    public partial class Brach : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCourses();
                if (Request.QueryString["id"] != null)
                {
                    BindData();
                }
            }
        }

        private void BindData()
        {
            branchBAL objBranch = new branchBAL();
            DataTable dt = objBranch.SelectById(int.Parse(Request.QueryString["id"])).Tables[0];
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                var branchName = Convert.ToString(dr["branchname"]);
                var desc = Convert.ToString(dr["description"]);
                var courseId = Convert.ToString(dr["courseid"]);
                txtbranchName.Text = branchName;
                txtDescription.Text = desc;
                ddlCourses.SelectedValue = courseId;
            }

            
        }

        private void BindCourses()
        {
            courseBAL courses = new courseBAL();
            DataSet ds = courses.SelectAll();
            ddlCourses.DataSource = ds;
            ddlCourses.DataTextField = "fullname";
            ddlCourses.DataValueField = "course_id";
            ddlCourses.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var branchName = txtbranchName.Text;
            var description = txtDescription.Text;
            var courseId = ddlCourses.SelectedValue;

            branchBEL branchDetail = new branchBEL();
            branchDetail.Branchname = branchName;
            branchDetail.Description = description;
            branchDetail.CourseId = Convert.ToInt32(courseId);

            branchBAL objBranch = new branchBAL();
            if (Request.QueryString["id"] != null)
            {
                branchDetail.Id = Convert.ToInt32(Request.QueryString["id"]);

                objBranch.Update(branchDetail);
            }
            else
            {
                objBranch.insert(branchDetail);
            }
            

            Response.Redirect("BranchList.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("BranchList.aspx");
        }
    }
}