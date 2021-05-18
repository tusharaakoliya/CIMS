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

namespace Cias.DAL
{
    public class roleDAL
    {
        public int Insert(roleBEL role)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("roleInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@id", role.Id);
                cmd.Parameters.AddWithValue("@name", role.Name);
                cmd.Parameters.AddWithValue("@description", role.Description);
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

        public int Update(roleBEL role)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("roleUpdate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@id", role.Id);
                cmd.Parameters.AddWithValue("@name", role.Name);
                cmd.Parameters.AddWithValue("@description", role.Description);
                
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
            var cmd = new SqlCommand("roleSelectALL", con);
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
            var cmd = new SqlCommand("roleSelectALL", con);
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

        public void Deleteall(int id)
        {
            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("roledelete", con);
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
    }
}