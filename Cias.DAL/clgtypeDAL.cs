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
   public class clgtypeDAL
    {
       public int insert(clgtypeBEL clgtype)
       {
           SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
           con.Open();
           SqlCommand cmd = new SqlCommand("clgtypeinsert", con);
           cmd.CommandType = CommandType.StoredProcedure;
           try
           {
               cmd.Parameters.AddWithValue("@id", clgtype.Id);
               cmd.Parameters.AddWithValue("@name", clgtype.Name);
               cmd.Parameters.AddWithValue("@description", clgtype.Description);

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
               con.Dispose();
               con.Close();
               cmd.Dispose();
           }
       }

       public int Update(clgtypeBEL clgtype)
       {
           SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
           con.Open();
           SqlCommand cmd = new SqlCommand("clgtypeUpdate", con);
           cmd.CommandType = CommandType.StoredProcedure;
           try
           {
               cmd.Parameters.AddWithValue("@id", clgtype.Id);
               cmd.Parameters.AddWithValue("@name", clgtype.Name);
               cmd.Parameters.AddWithValue("@description", clgtype.Description);
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
           var cmd = new SqlCommand("clgtypeSelectAll", con);
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

       public DataSet SelectById(int id)
       {
           var ds = new DataSet();

           var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
           con.Open();
           var cmd = new SqlCommand("clgtypeSelectbyId", con);
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
           var cmd = new SqlCommand("clgtypedelete", con);
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
