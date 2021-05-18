using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
namespace Cims
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                panelResult.Visible = false;
                btnExportPdf.Visible = false;
                ViewState["SortExpression"] = "CollageName ASC";
                BindResultDate();
            }
        }

        private void BindResultDate()
        {
            try
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
                        if (Session["Username"] != null)
                        {
                            var date = Convert.ToDateTime(dr["ResultDate"].ToString());
                            var currentDate = DateTime.Now.Date;
                            if (date == currentDate)
                            {
                                lblResultDate.Visible = false;
                                panelResult.Visible = true;
                                BindTempGrid();
                                BindGrid();




                            }
                            else if (date < currentDate)
                            {
                                lblResultDate.Visible = true;
                                panelResult.Visible = false;
                                lblResultDate.Text = "Next Result Date will be declared soon....";
                            }
                            else
                            {
                                lblResultDate.Visible = true;
                                panelResult.Visible = false;
                                lblResultDate.Text = "Your result will be declared on Date : " + Convert.ToDateTime(dr["ResultDate"].ToString()).ToShortDateString();
                            }
                        }
                        else
                        {
                            lblResultDate.Visible = true;
                            panelResult.Visible = false;
                            lblResultDate.Text = "Your result will be declared on Date : " + Convert.ToDateTime(dr["ResultDate"].ToString()).ToShortDateString();
                        }

                    }

                }
                con.Close();
            }
            catch (Exception ex)
            {
                lblResultDate.Visible = true;
                btnExportPdf.Visible = false;
                lblResultDate.Text = "Something wrong ! Please try later again";
            }

        }

        private void BindGrid()
        {
            choicefilingBAL clgbranch = new choicefilingBAL();
            if (Session["StudentId"] != null)
            {
                var dataSet = clgbranch.Result(Convert.ToInt64(Session["StudentId"]));

                var dv = dataSet.Tables[0].DefaultView;
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = dataSet.Tables[0].Rows[0];
                    var collageId = Convert.ToString(dr["collageid"]);
                    var branchId = Convert.ToString(dr["branchid"]);
                    btnExportPdf.Visible = true;


                    var dt = GetStudentResult(Convert.ToInt32(Session["StudentId"]), Convert.ToInt32(collageId), Convert.ToInt32(branchId));

                    if (dt.Rows.Count == 0)
                    {
                        InsertStudentResult(Convert.ToInt32(Session["StudentId"]), Convert.ToInt32(collageId), Convert.ToInt32(branchId));
                    }

                }
                else
                {
                    btnExportPdf.Visible = false;
                }
                dv.Sort = ViewState["SortExpression"].ToString();
                gvresult.DataSource = dv;
                gvresult.DataBind();
            }


        }

        public int InsertStudentResult(int studentId, int collageId, int branchId)
        {

            //Create the SQL Query for inserting an article
            string sqlQuery = String.Format("Insert into tbl_SeatAssign (CollageId, StudentId, BranchId) Values('{0}', '{1}', '{2}');"
            + "Select @@Identity", collageId, studentId, branchId);

            //Create and open a connection to SQL Server 
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            connection.Open();

            //Create a Command object
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //Execute the command to SQL Server and return the newly created ID
            int newStudentResultId = Convert.ToInt32((decimal)command.ExecuteScalar());

            //Close and dispose
            command.Dispose();
            connection.Close();
            connection.Dispose();

            // Set return value
            return newStudentResultId;
        }

        public DataTable GetStudentResult(int studentId, int collageId, int branchId)
        {
            DataTable dt = new DataTable();

            //Create and open a connection to SQL Server 
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            connection.Open();

            //Create a Command object
            SqlCommand command = new SqlCommand("Select * from tbl_SeatAssign where StudentId = '" + studentId + "' and CollageId = " + collageId + " and BranchId = " + branchId + "", connection);

            SqlDataAdapter dap = new SqlDataAdapter(command);
            dap.Fill(dt);

            command.Dispose();
            connection.Close();

            return dt;
        }

        private void BindTempGrid()
        {
            choicefilingBAL clgbranch = new choicefilingBAL();
            if (Session["StudentId"] != null)
            {
                var dataSet = clgbranch.Result(Convert.ToInt64(Session["StudentId"]));

                var dv = dataSet.Tables[0].DefaultView;
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    btnExportPdf.Visible = true;
                }
                else
                {
                    btnExportPdf.Visible = false;
                }
                dv.Sort = ViewState["SortExpression"].ToString();
                GridView1.DataSource = dv;
                GridView1.DataBind();
            }


        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            return;/* Verifies that the control is rendered */
        }

        protected void btnExportPdf_Click(object sender, System.EventArgs e)
        {

            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Result.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            GridView1.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();
            GridView1.AllowPaging = true;
            GridView1.DataBind();
        }
    }


}