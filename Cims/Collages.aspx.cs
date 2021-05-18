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
    public partial class Collages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    legendAddCollage.InnerText = " Edit Collage ";
                    BindData();
                }
                else
                {
                    legendAddCollage.InnerText = " Add New Collage ";
                }
            }
        }
        private void BindData()
        {
            clglistBAL objBranch = new clglistBAL();
            DataTable dt = objBranch.SelectById(int.Parse(Request.QueryString["id"])).Tables[0];
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                var collagename = Convert.ToString(dr["name"]);
                var Address = Convert.ToString(dr["address"]);
                var fax = Convert.ToString(dr["fax"]);
                var email = Convert.ToString(dr["email"]);
                var Phone = Convert.ToString(dr["phoneno"]);
                var city = Convert.ToString(dr["city"]);
                //var stateid = Convert.ToString(dr["stateid"]);

                txtName.Text = collagename;
                txtAddress.Text = Address;
                txtfax.Text = fax;
                txtEmail.Text = email;
                txtphoneno.Text = Phone;
                txtcity.Text = city;
                //  txtstateid.Text = stateid;
            }


        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var address = txtAddress.Text;
            var fax = txtfax.Text;
            var email = txtEmail.Text;
            var phone = txtphoneno.Text;
            var city = txtcity.Text;
            //var stateid = txtstateid.Text;
            
            clglistBEL objclglist = new clglistBEL();
            objclglist.Name = name;
            objclglist.Address = address;
            objclglist.City = city;
            objclglist.Email = email;
            objclglist.Fax = fax;
            objclglist.Merit = txtMerit.Text;
            objclglist.Createddate = DateTime.Now;
            objclglist.Updateddate = DateTime.Now;
            if(Session["UserId"]!= null)
            {
                objclglist.Updatedby = Convert.ToInt32(Session["UserId"]);
                objclglist.Createdby = Convert.ToInt32(Session["UserId"]);
            }
            else
            {
                objclglist.Updatedby = 0;
                objclglist.Createdby = 0;
            }
            

            if (!string.IsNullOrEmpty(phone))
                objclglist.Phoneno = Convert.ToInt32(phone);
            //objclglist.Stateid =Convert.ToInt32(stateid);

            clglistBAL objbal = new clglistBAL();
            if (Request.QueryString["id"] != null)
            {
                objclglist.Id = Convert.ToInt32(Request.QueryString["id"]);

                objbal.Updateclglist(objclglist);
            }
            else
            {
                objbal.Insertclglist(objclglist);
            }


            Response.Redirect("Collagelist.aspx");
        }
    }
}
