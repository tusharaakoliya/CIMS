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
    public partial class admission : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ViewState["SortExpression"] = "Marks desc";
                if (Session["StudentId"] != null)
                {
                    var studentid = Convert.ToInt32(Session["StudentId"]);
                    BindData(studentid);
                    BindMerit();
                }
            }
        }

        public void BindMerit()
        {
            studentmarksBAL marks = new studentmarksBAL();
            var dataSet = marks.MeritList();
            DataView dv = dataSet.Tables[0].DefaultView;
            dv.Sort = ViewState["SortExpression"].ToString();
            gvmarks.DataSource = dv;
            gvmarks.DataBind();
        }
        private void BindData(int studentid)
        {
            studentmarksBAL studentmarksobj = new studentmarksBAL();
            DataTable dt = studentmarksobj.Select(studentid).Tables[0];
            if (dt.Rows.Count > 0)
            {
                var totalMarks = 0;
                foreach (DataRow student in dt.Rows)
                {
                    totalMarks += Convert.ToInt32(Convert.ToString(student["Marks"]));
                }

                lblTotalMarks.Text = totalMarks.ToString();

                lblMeritPercentage.Text = (totalMarks / 3).ToString("##");
                //DataRow dr = dt.Rows[0];
                //var branchName = Convert.ToString(dr["MATHES"]);
                //var desc = Convert.ToString(dr["SC"]);
                //var courseId = Convert.ToString(dr["courseid"]);
                //txtbranchName.Text = branchName;
                //txtDescription.Text = desc;
                //ddlCourses.SelectedValue = courseId;
            }
        }

        protected void gvmarks_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvmarks.PageIndex = e.NewPageIndex;
            BindMerit();
        }

        protected void gvmarks_Sorting(object sender, GridViewSortEventArgs e)
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

           

        }

               
    }
}