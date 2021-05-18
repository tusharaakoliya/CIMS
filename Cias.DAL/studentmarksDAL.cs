using Cims.BEL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cias.DAL
{
    public class studentmarksDAL
    {
        public void Insert(studentmarksBEL studentmarks)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("studentmarksInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@marks", studentmarks.Marks);
                cmd.Parameters.AddWithValue("@studentid", studentmarks.StudentId);
                cmd.Parameters.AddWithValue("@subjectid", studentmarks.SubjectId);

                cmd.ExecuteNonQuery();
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

        public void Update(studentmarksBEL studentmarks)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("StudentMarksUpdate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@id", studentmarks.Id);
                cmd.Parameters.AddWithValue("@marks", studentmarks.Marks);
                cmd.Parameters.AddWithValue("@studentid", studentmarks.StudentId);
                cmd.Parameters.AddWithValue("@subjectid", studentmarks.SubjectId);

                cmd.ExecuteNonQuery();
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

        public DataSet SelectAll()
        {
            var ds = new DataSet();

            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("studentmarksSelectAll", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                var dap = new SqlDataAdapter(cmd);
                dap.Fill(ds);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }

            return ds;
        }

        public DataSet Select(int studentid)
        {
            var ds = new DataSet();

            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("GetstudentmarksbyStudent", con);
            cmd.Parameters.AddWithValue("@studentid", studentid);

            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                var dap = new SqlDataAdapter(cmd);
                dap.Fill(ds);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }

            return ds;
        }

        public DataSet MeritList()
        {
            var ds = new DataSet();

            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("GetMeritList", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                var dap = new SqlDataAdapter(cmd);
                dap.Fill(ds);
            }
            catch (Exception ex)
            {
                throw;
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
