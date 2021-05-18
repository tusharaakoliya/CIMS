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
    public partial class MyProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var studentId = Convert.ToInt32(Session["StudentId"]);

                if (studentId != null && studentId != 0)
                {
                    var firstName = txtFirstName.Text;
                    var middleName = txtMiddleName.Text;
                    var lastName = txtLastName.Text;
                    var phoneNo = txtPno.Text;
                    var mobileNo = txtMno.Text;
                    var address = txtAddress.Text;

                    var studentDetails = new StudentBEL();
                    studentDetails.FirstName = firstName;
                    studentDetails.LastName = middleName;
                    studentDetails.MiddleName = lastName;
                    studentDetails.MOBILENO = mobileNo;
                    studentDetails.phoneNo = phoneNo;
                    studentDetails.address = address;
                    studentDetails.UpdatedDate = DateTime.Now;


                    var studentBal = new StudentBAL();
                    studentDetails.StudentId = studentId;
                    var id = studentBal.UpdateStudent(studentDetails);

                    var sujects = new List<LookupItem>();

                    sujects.Add(new LookupItem { Id = (int)SubjectEnum.Maths, Description = txtmathes.Text });
                    sujects.Add(new LookupItem { Id = (int)SubjectEnum.Science, Description = txtscience.Text });
                    sujects.Add(new LookupItem { Id = (int)SubjectEnum.English, Description = txtenglish.Text });

                    var studentMarksBAL = new studentmarksBAL();

                    var studentmarks = studentMarksBAL.Select(studentId);
                    if (studentmarks.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in studentmarks.Tables[0].Rows)
                        {
                            var studentMarksBALDetail = new studentmarksBAL();
                            var subjectId = Convert.ToInt32(dr["subjectid"]);
                            var studId = studentId;
                            var marks = Convert.ToString(dr["marks"]);
                            var studentMarksId = Convert.ToInt32(dr["id"]);
                            var marksBEL = new studentmarksBEL();


                            marksBEL.SubjectId = subjectId;

                            if (subjectId == (int)SubjectEnum.Maths)
                            {
                                marksBEL.Marks = txtmathes.Text;
                            }
                            else if (subjectId == (int)SubjectEnum.English)
                            {
                                marksBEL.Marks = txtenglish.Text;
                            }
                            else if (subjectId == (int)SubjectEnum.Science)
                            {
                                marksBEL.Marks = txtscience.Text;
                            }

                            marksBEL.Id = studentMarksId;
                            marksBEL.StudentId = studId;

                            studentMarksBALDetail.Update(marksBEL);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            Response.Redirect("Home.aspx");


        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

    }
}
