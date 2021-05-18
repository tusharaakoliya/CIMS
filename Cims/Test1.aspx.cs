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
    public partial class Test1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var studentDetails = new StudentBEL();
            studentDetails.StateId = 4;
            studentDetails.StateName = "guj";
            //studentDetails.UserId = 1;
            //studentDetails.EnrollmentId = 1233;
            //studentDetails.FirstName = "Darshan";
            //studentDetails.LastName = "Ahir";
            //studentDetails.MiddleName = "D";
            //studentDetails.Gender = true;
            //studentDetails.DOb = DateTime.Now;
            //studentDetails.MOBILENO = 99885522;
            //studentDetails.City = "a'bad";
            //studentDetails.phoneNo = "886622";
            //studentDetails.address = "28,djsdfjbdsjfsdd";
            //studentDetails.CreatedDate = DateTime.Now;
            //studentDetails.UpdatedDate = DateTime.Now;
            //studentDetails.Email = "test@gmail.com";
            //studentDetails.StateId = 1;

            //var studentBal = new StudentBAL();
            //var id = studentBal.UpdateStudent(studentDetails);

         //   var ds = new DataSet();
           // var studentBal = new StudentBAL();
            
            ///studentBal.Delete(4);

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var firstName = txtFirstName.Text;
            var middleName = txtMiddleName.Text;
            var lastName = txtLastName.Text;
            var email = txtEmail.Text;
            var address = txtAddress.Text;
            var phoneNo = txtPno.Text;
            var mobileNo = txtMno.Text;
            var city = txtCity.Text;
            var dob = txtDob.Text;
            var state = ddlState.SelectedValue;
            var gender = radioGender.SelectedValue;

            var studentDetails = new StudentBEL();
            studentDetails.StateId = Convert.ToInt32(state);
            studentDetails.UserId = 1;
            studentDetails.EnrollmentId = 1233;
            studentDetails.FirstName = firstName;
            studentDetails.LastName = middleName;
            studentDetails.MiddleName = lastName;
            studentDetails.Gender = true;
            studentDetails.DOb = DateTime.Now;
            studentDetails.MOBILENO = mobileNo;
            studentDetails.City = city;
            studentDetails.phoneNo = phoneNo;
            studentDetails.address = address;
            studentDetails.CreatedDate = DateTime.Now;
            studentDetails.UpdatedDate = DateTime.Now;
            studentDetails.Email = email;
            studentDetails.StateId = 1;

            var studentBal = new StudentBAL();
            var id = studentBal.UpdateStudent(studentDetails);


        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtDob.Text = "";
            txtEmail.Text = "";
            txtMno.Text = "";
            txtPno.Text = "";
            ddlState.SelectedValue = "";
            radioGender.SelectedValue = "true";

        }
    }
}