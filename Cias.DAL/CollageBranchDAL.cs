using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cims.BEL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Cias.DAL
{
    public class CollageBranchDAL
    {

        public DataSet SelectAll(long studentId)
        {
            var ds = new DataSet();

            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("collagebranchselectall", con);
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

        public DataSet SearchClgBranch(String searchString)
        {
            var ds = new DataSet();

            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("CollageBranchSearch", con);
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

        public void Insert(CollageBranchBEL clgbranchdetail)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("ClgBranchInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@collageid", clgbranchdetail.CollageId);
                cmd.Parameters.AddWithValue("@branchid", clgbranchdetail.BranchId);
                cmd.Parameters.AddWithValue("@seat", clgbranchdetail.Seat);
              

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

        public void Update(CollageBranchBEL clgbranchetail)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("collagebranchupdate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@Id", clgbranchetail.Id);
                cmd.Parameters.AddWithValue("@branchid", clgbranchetail.BranchId);
                cmd.Parameters.AddWithValue("@collageid", clgbranchetail.CollageId);
                cmd.Parameters.AddWithValue("@seat", clgbranchetail.Seat);

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

        public void Delete(int id)
        {
            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("collagebranchdelete", con);
            cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                cmd.Parameters.AddWithValue("@id",id);
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

        public void SelectById(int id)
        {
            var ds = new DataSet();

            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("collagebranchselectbyid", con);
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
        }

        public DataSet AdminSelectAll()
        {
            var ds = new DataSet();

            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("AdminClgBranchSelect", con);
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
