using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Cims.BEL;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;

namespace Cias.DAL
{
    public class circularDAL
    {
            public void insert(circularBEL circular)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("circularinsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@id", circular.Id);
                cmd.Parameters.AddWithValue("@name", circular.Name);
                cmd.Parameters.AddWithValue("@description", circular.Description);
                cmd.Parameters.AddWithValue("@status", circular.Status);
                cmd.Parameters.AddWithValue("@cdate", circular.Cdate);
                cmd.Parameters.AddWithValue("@createdby", circular.Createdby);
                cmd.Parameters.AddWithValue("@updatedby", circular.Updatedby);
                cmd.Parameters.AddWithValue("@createddate", circular.Createddate);
                cmd.Parameters.AddWithValue("@updateddate", circular.Updateddate);
            }
                catch(Exception ex)
            {
                throw ex;
            }
                finally
            {
                con.Dispose();
                con.Close();
                cmd.Dispose();
            }
        }

            public int Update(circularBEL circular)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("circularUpdate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    cmd.Parameters.AddWithValue("@id", circular.Id);
                    cmd.Parameters.AddWithValue("@name", circular.Name);
                    cmd.Parameters.AddWithValue("@description", circular.Description);
                    cmd.Parameters.AddWithValue("@status", circular.Status);
                    cmd.Parameters.AddWithValue("@cdate", circular.Cdate);
                    cmd.Parameters.AddWithValue("@createdby", circular.Createdby);
                    cmd.Parameters.AddWithValue("@updatedby", circular.Updatedby);
                    cmd.Parameters.AddWithValue("@createddate", circular.Createddate);
                    cmd.Parameters.AddWithValue("@updateddate", circular.Updateddate);
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
                var cmd = new SqlCommand("circularSelectAll", con);
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
                var cmd = new SqlCommand("circularSelectbyId", con);
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
                var cmd = new SqlCommand("Circulardelete", con);
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
