using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Cims.BEL;

using System.Data;
using System.Data.Common;
namespace Cias.DAL
{
    public class StudentDAL
    {
        public int Insert(StudentBEL student)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("StudentInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@UserId", student.UserId);
                cmd.Parameters.AddWithValue("@EnrollementId", student.EnrollmentId);
                cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", student.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@Gender", student.Gender);
                cmd.Parameters.AddWithValue("@Email", student.Email);

                cmd.Parameters.AddWithValue("@Address", student.address);
                cmd.Parameters.AddWithValue("@State", student.StateId);
                cmd.Parameters.AddWithValue("@City", student.City);
                cmd.Parameters.AddWithValue("@MobileNo", student.MOBILENO);
                cmd.Parameters.AddWithValue("@PhoneNo", student.phoneNo);
                if (student.DOb != DateTime.MinValue)
                    cmd.Parameters.AddWithValue("@DOB", student.DOb);
                if (student.CreatedDate != DateTime.MinValue)
                {
                    cmd.Parameters.AddWithValue("@createdDate", student.CreatedDate);
                }
                if (student.UpdatedDate != DateTime.MinValue)
                    cmd.Parameters.AddWithValue("@UpdatedDate", student.UpdatedDate);

                cmd.Parameters.Add("@studentId", SqlDbType.Int).Direction = ParameterDirection.Output;
                var result = cmd.ExecuteNonQuery();

                var Id = cmd.Parameters["@studentId"].Value.ToString(); 


                if (result > 0)
                {
                    return Convert.ToInt32(Id);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }
        }

        public int Update(StudentBEL student)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("StudentProfileUpdate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@StudentId", student.StudentId);
                cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", student.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@Address", student.address);

                
                cmd.Parameters.AddWithValue("@MobileNo", student.MOBILENO);
                cmd.Parameters.AddWithValue("@PhoneNo", student.phoneNo);
                if (student.UpdatedDate != DateTime.MinValue)
                    cmd.Parameters.AddWithValue("@UpdatedDate", student.UpdatedDate);
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }

            }

            catch (Exception)
            {
                throw;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }
        }

        public DataSet SelectAll()
        {
            var ds = new DataSet();

            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("StudentSelectAll", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                var dap = new SqlDataAdapter(cmd);
                dap.Fill(ds);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }
            
            return ds;
        }

        public DataSet SelectById(int studentId)
        {
            var ds = new DataSet();

            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("StudentSelect", con);
            cmd.Parameters.AddWithValue("@StudentId", studentId);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                var dap = new SqlDataAdapter(cmd);
                dap.Fill(ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }

            return ds;
        }

        public void Deleteall(int StudentId)
        {
            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("Studentdelete", con);
            cmd.CommandType = CommandType.StoredProcedure;
           

            try
            {
                cmd.Parameters.AddWithValue("@StudentId", StudentId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw  ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }

        }

        public DataSet SelectByUser(int userid)
        {
            var ds = new DataSet();

            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("getstudentbyuser", con);
            cmd.Parameters.AddWithValue("@UserId", userid);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                var dap = new SqlDataAdapter(cmd);
                dap.Fill(ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }

            return ds;
        }
    }
}
