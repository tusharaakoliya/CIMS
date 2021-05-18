
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
namespace Cims.DAL
{
    public class StateDAL
    {
        public int Insert(StateBEL state)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("StateInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@StateId", state.stateid);
                cmd.Parameters.AddWithValue("@StateName", state.statename);
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

        public int Update(StateBEL state )
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("StateUpdate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@StateId", state.stateid);
                cmd.Parameters.AddWithValue("@StateName", state.statename);
              
              
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
            var cmd = new SqlCommand("StateSelectall", con);
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

        public DataSet SelectById(int stateid)
        {
            var ds = new DataSet();

            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("StateSelectbyid", con);
            cmd.Parameters.AddWithValue("@stateid", stateid);
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

        public void Deleteall(int stateid) 
        {
            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("Statedelete", con);
            cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                cmd.Parameters.AddWithValue("@stateid", stateid);
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

       
 
    

