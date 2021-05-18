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
    public class choicefilingDAL
    {
        public void insert(choicefillingBEL choice)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("choicefillingInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@courseid", choice.Courseid);
                cmd.Parameters.AddWithValue("@branchid", choice.BranchId);
                cmd.Parameters.AddWithValue("@collageid", choice.CollageId);
                cmd.Parameters.AddWithValue("@studentid", choice.StudentId);
                cmd.Parameters.AddWithValue("@createddate", choice.Createdate);
                cmd.Parameters.AddWithValue("@updatedate", choice.Updatedate);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                con.Dispose();
                con.Close();

            }
        }

        public int Update(choicefillingBEL choice)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("choicefillingUpdate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@id", choice.Id);
                cmd.Parameters.AddWithValue("@courseid", choice.Courseid);
                cmd.Parameters.AddWithValue("@branchid", choice.BranchId);
                cmd.Parameters.AddWithValue("@collageid", choice.CollageId);
                cmd.Parameters.AddWithValue("@studentid", choice.StudentId);
                cmd.Parameters.AddWithValue("@createdate", choice.Createdate);
                cmd.Parameters.AddWithValue("@updatedate", choice.Updatedate);
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
            var cmd = new SqlCommand("choicefillingSelectAll", con);
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

        public DataSet SelectById(int id)
        {
            var ds = new DataSet();

            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("choicefillingSelectbyId", con);
            cmd.Parameters.AddWithValue("@id", id);
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

        public void Delete(int id)
        {
            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("Choicefillingdelete", con);
            cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                cmd.Parameters.AddWithValue("@id", id);
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

        public DataSet SelectAllbyStudent(long studentId)
        {
            var ds = new DataSet();

            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("GetChiocefillingbyStudent", con);
            cmd.Parameters.AddWithValue("@studentId", studentId);
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

        public DataSet SearchSelestedChoice(String searchString)
        {
            var ds = new DataSet();

            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("ChoicefillingSearch", con);
            cmd.Parameters.AddWithValue("@Searchstring", searchString);
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

        public DataSet Result(long studentId)
        {
            var ds = new DataSet();

            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("GetResult", con);
            cmd.Parameters.AddWithValue("@studentId", studentId);
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
