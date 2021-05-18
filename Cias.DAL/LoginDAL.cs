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
    public class LoginDAL
    {
        public DataSet Login(string username, string password)
        {
            var ds = new DataSet();

            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("LoginBy", con);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
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

        public int Insert(LoginBEL loginDetail)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("loginInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@Username", loginDetail.UserName);
                cmd.Parameters.AddWithValue("@Password", loginDetail.Password);
                if (loginDetail.CreatedDate != DateTime.MinValue)
                    cmd.Parameters.AddWithValue("@CreatedDate", loginDetail.CreatedDate);
                if (loginDetail.LastLoginDate != DateTime.MinValue)
                    cmd.Parameters.AddWithValue("@LastLoginDate", loginDetail.LastLoginDate);
                cmd.Parameters.AddWithValue("@roleId", loginDetail.RoleId);
                cmd.Parameters.Add("@userId", SqlDbType.Int).Direction = ParameterDirection.Output;

                var result = cmd.ExecuteNonQuery();

                var Id = cmd.Parameters["@userId"].Value.ToString();
                return Convert.ToInt32(Id);

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

        public int Update(LoginBEL login)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("loginUpdate", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@Username", login.UserName);
                cmd.Parameters.AddWithValue("@Password", login.Password);
                if (login.CreatedDate != DateTime.MinValue)
                    cmd.Parameters.AddWithValue("@CreatedDate", login.CreatedDate);
                if (login.LastLoginDate != DateTime.MinValue)
                    cmd.Parameters.AddWithValue("@LastLoginDate", login.LastLoginDate);
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
            var cmd = new SqlCommand("loginSelectAll", con);
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

        public DataSet SelectById(int userid)
        {
            var ds = new DataSet();

            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("loginSelectbyId", con);
            cmd.Parameters.AddWithValue("@userId", userid);
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

        public void Deleteall(int userid)
        {
            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
            con.Open();
            var cmd = new SqlCommand("logindelete", con);
            cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                cmd.Parameters.AddWithValue("@userid", userid);
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
