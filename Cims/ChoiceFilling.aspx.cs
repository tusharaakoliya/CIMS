using Cims.BAL;
using Cims.BEL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cims
{
    public partial class ChoiceFilling : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                ViewState["SortExpression"] = "CollageName ASC";
                BindGrid();
                BindchoicefillingGrid();
                BindResultDate();

            }
        }

        private void BindResultDate()
        {
            SqlDataReader dr = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ResultDate from Result", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["ResultDate"].ToString() != null)
                {
                    lblResultDate.Text = "Your result will be declared on Date : " + Convert.ToDateTime(dr["ResultDate"].ToString()).ToShortDateString();
                    
                    lblResultDate.Visible = true;
                }
               
            }
            con.Close();
        }

        private void BindGrid()
        {
            CollageBranchBAL clgbranch = new CollageBranchBAL();
            if (Session["StudentId"] != null)
            {
                var dataSet = clgbranch.SelectAll(Convert.ToInt64(Session["StudentId"]));
                var dv = dataSet.Tables[0].DefaultView;
                dv.Sort = ViewState["SortExpression"].ToString();
                gvchoicefilling.DataSource = dv;
                gvchoicefilling.DataBind();
            }
        }

        private void BindchoicefillingGrid()
        {
            choicefilingBAL selectedclg = new choicefilingBAL();
            if (Session["StudentId"] != null)
            {
                var dataSet = selectedclg.SelectAllbyStudent(Convert.ToInt64(Session["StudentId"]));
                var dv = dataSet.Tables[0].DefaultView;
                dv.Sort = ViewState["SortExpression"].ToString();
                gvselecctedchoicefilling.DataSource = dv;
                gvselecctedchoicefilling.DataBind();
            }
        }

        protected void gvchoicefilling_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvchoicefilling.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void gvchoicefilling_Sorting(object sender, GridViewSortEventArgs e)
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


        protected void btnBranch_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow dr in gvchoicefilling.Rows)
            {

                string cell_1_Value = gvchoicefilling.Rows[dr.RowIndex].Cells[4].Text;
                Label lblCollage = (Label)dr.FindControl("lblCollageId");
                Label lblBranch = (Label)dr.FindControl("lblbranchid");
                Label lblCourse = (Label)dr.FindControl("lblCourseId");

                var collageId = lblCollage.Text;
                var branchId = lblBranch.Text;
                var courseId = lblCourse.Text;

                if (Session["StudentId"] != null)
                {
                    var studentId = Convert.ToInt32(Session["StudentId"]);
                    var choiceFillingDetail = new choicefillingBEL();
                    choiceFillingDetail.StudentId = studentId;
                    choiceFillingDetail.CollageId = Convert.ToInt32(collageId);
                    choiceFillingDetail.BranchId = Convert.ToInt32(branchId);
                    choiceFillingDetail.Createdate = DateTime.Now;
                    choiceFillingDetail.Updatedate = DateTime.Now;

                    choiceFillingDetail.Courseid = Convert.ToInt32(courseId);

                    CheckBox chksele = (CheckBox)dr.FindControl("chkSelect");

                    if (chksele.Checked)
                    {
                        choicefilingBAL objChoiceFilling = new choicefilingBAL();
                        objChoiceFilling.insert(choiceFillingDetail);
                    }
                }



                //Label lblclg = (Label)dr.FindControl("courseid");

            }
            BindGrid();
            BindchoicefillingGrid();
        }

        protected void gvchoicefilling_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            gvchoicefilling.Columns[0].Visible = false;
            gvchoicefilling.Columns[1].Visible = false;
            gvchoicefilling.Columns[2].Visible = false;
        }

        protected void gvselecctedchoicefilling_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvselecctedchoicefilling.PageIndex = e.NewPageIndex;
            BindchoicefillingGrid();
        }

        protected void gvselecctedchoicefilling_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            gvselecctedchoicefilling.Columns[0].Visible = false;
            gvselecctedchoicefilling.Columns[1].Visible = false;
            gvselecctedchoicefilling.Columns[2].Visible = false;
        }


        protected void gvselecctedchoicefilling_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            choicefilingBAL objBAL = new choicefilingBAL();
            objBAL.Delete(int.Parse(Convert.ToString(e.Keys[0])));

            BindGrid();
            BindchoicefillingGrid();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            var searchstring = txtSearch.Text;
            CollageBranchBAL collageBranch = new CollageBranchBAL();
            var dataSet = collageBranch.SearchClgBranch(searchstring);
            DataView dv = dataSet.Tables[0].DefaultView;
            dv.Sort = ViewState["SortExpression"].ToString();
            gvchoicefilling.DataSource = dv;
            gvchoicefilling.DataBind();
        }

        //protected void selectedSearch_Click(object sender, EventArgs e)
        //{
        //    var searchstring = Selectedgv.Text;
        //    choicefilingBAL choiceselected = new choicefilingBAL();
        //    var dataSet = choiceselected.SearchSelestedChoice(searchstring);
        //    DataView dv = dataSet.Tables[0].DefaultView;
        //    dv.Sort = ViewState["SortExpression"].ToString();
        //    gvselecctedchoicefilling.DataSource = dv;
        //    gvselecctedchoicefilling.DataBind();
        //}


    }
}