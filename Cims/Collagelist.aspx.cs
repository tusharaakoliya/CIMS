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
    public partial class Collagelist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ViewState["SortExpression"] = "id ASC";
                if (Session["Username"] != null && !string.IsNullOrEmpty(Session["RoleName"].ToString()))
                {
                    if (Session["RoleName"].ToString() == "Admin")
                        btnclg.Visible = true;
                    else
                        btnclg.Visible = false;
                }
                else
                {
                    btnclg.Visible = false;
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
            
            clglistBAL collages = new clglistBAL();
            var dataSet = collages.SelectAll();
            DataView dv = dataSet.Tables[0].DefaultView;
            dv.Sort = ViewState["SortExpression"].ToString();
            gvCollages.DataSource = dv;
            gvCollages.DataBind();
        }

        protected void gvCollages_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
            clglistBAL objbal = new clglistBAL();
            objbal.Delete(int.Parse(Convert.ToString(e.Keys[0])));

            BindGrid();
        }

        protected void gvCollages_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCollages.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void gvCollages_Sorting(object sender, GridViewSortEventArgs e)
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
        public static clglistBEL[] BindCollages()
        {
            var clgList = new List<clglistBEL>();
            clglistBAL collages = new clglistBAL();
            var dataSet = collages.SelectAll();
            DataTable dt = dataSet.Tables[0];

            foreach (DataRow dr in dt.Rows)
            {
                var clgDetail = new clglistBEL();
                clgDetail.Id = Convert.ToInt32(dr["id"].ToString());
                clgDetail.Name = dr["name"].ToString();
                clgDetail.Phoneno = !string.IsNullOrEmpty(dr["phoneno"].ToString()) ? Convert.ToInt32(dr["phoneno"].ToString()) : 0;
                clgDetail.Code = dr["code"].ToString();
                clgDetail.Address = dr["address"].ToString();
                clgDetail.Fax = dr["fax"].ToString();
                clgDetail.Email = dr["email"].ToString();
                clgDetail.City = dr["city"].ToString();
                clgDetail.Zipcode = !string.IsNullOrEmpty(dr["zipcode"].ToString()) ? Convert.ToInt32(dr["zipcode"].ToString()) : 0;

                clgList.Add(clgDetail);
            }

            return clgList.ToArray();
        }

        protected void gvCollages_PreRender(object sender, EventArgs e)
        {
            if (Session["Username"] != null && !string.IsNullOrEmpty(Session["RoleName"].ToString()))
            {
                if (Session["RoleName"].ToString() == "Admin")
                {
                    gvCollages.Columns[5].Visible = true;
                    gvCollages.Columns[6].Visible = true;
                }
                else
                {
                    gvCollages.Columns[6].Visible = false;
                    gvCollages.Columns[7].Visible = false;
                }

            }
            else
            {
                gvCollages.Columns[6].Visible = false;
                gvCollages.Columns[7].Visible = false;
            }
        }

        protected void btnclg_Click(object sender, EventArgs e)
        {
            Response.Redirect("Collages.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            var searchstring = txtSearch.Text;
            clglistBAL collages = new clglistBAL();
            var dataSet = collages.Search(searchstring);
            DataView dv = dataSet.Tables[0].DefaultView;
            dv.Sort = ViewState["SortExpression"].ToString();
            gvCollages.DataSource = dv;
            gvCollages.DataBind();
        }


    }
}