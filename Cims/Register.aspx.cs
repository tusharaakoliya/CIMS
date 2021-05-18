using System;
using System.Collections.Generic;
using Cims.BAL;
using Cims.BEL;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cims
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var loginDetails = new LoginBEL();
            loginDetails.UserName = txtEmail.Text;
            loginDetails.RoleId = 2;
            loginDetails.Password = txtPassword.Text;
            loginDetails.CreatedDate = DateTime.Now;
            loginDetails.LastLoginDate = DateTime.Now;

            var userBal = new LoginBAL();
            var userId = userBal.Insert(loginDetails);

            try
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
                var gender = false;

                var studentDetails = new StudentBEL();
                studentDetails.StateId = Convert.ToInt32(state);
                studentDetails.UserId = userId;
                studentDetails.EnrollmentId = 1233;
                studentDetails.FirstName = firstName;
                studentDetails.LastName = middleName;
                studentDetails.MiddleName = lastName;
                if (rbMale.Checked)
                {
                    gender = true;
                }
                else if (rbFemale.Checked)
                {
                    gender = false;
                }
                studentDetails.Gender = gender;
                studentDetails.DOb = Convert.ToDateTime(txtDob.Text);
                studentDetails.MOBILENO = mobileNo;
                studentDetails.City = city;
                studentDetails.phoneNo = phoneNo;
                studentDetails.address = address;
                studentDetails.CreatedDate = DateTime.Now;
                studentDetails.UpdatedDate = DateTime.Now;
                studentDetails.Email = email;


                var studentBal = new StudentBAL();
                var id = studentBal.InsertStudent(studentDetails);

                var sujects = new List<LookupItem>();

                sujects.Add(new LookupItem { Id = (int)SubjectEnum.Maths, Description = txtmathes.Text });
                sujects.Add(new LookupItem { Id = (int)SubjectEnum.Science, Description = txtscience.Text });
                sujects.Add(new LookupItem { Id = (int)SubjectEnum.English, Description = txtenglish.Text });

                foreach (var subjectDetail in sujects)
                {
                    var marksBEL = new studentmarksBEL();
                    marksBEL.SubjectId = subjectDetail.Id;
                    marksBEL.Marks = subjectDetail.Description;
                    marksBEL.StudentId = id;

                    var studentMarksBAL = new studentmarksBAL();
                    studentMarksBAL.insert(marksBEL);
                }
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Session["UserId"] =  userId.ToString();
            Session["Username"] = txtEmail.Text;
            Session["RoleName"] = "Student"; 
            
            Response.Redirect("Home.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}