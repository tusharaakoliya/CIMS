using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cims.BEL;

namespace Cias.DAL
{
   public class clglistDAL
    {
       public int Insert(clglistBEL clglist)
       {
           SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
           con.Open();
           SqlCommand cmd = new SqlCommand("collagelistInsert", con);
           cmd.CommandType = CommandType.StoredProcedure;
           try
           {
               cmd.Parameters.AddWithValue("@id", clglist.Id);
               cmd.Parameters.AddWithValue("@name", clglist.Name);
               cmd.Parameters.AddWithValue("@address", clglist.Address);
               cmd.Parameters.AddWithValue("@fax", clglist.Fax);
               cmd.Parameters.AddWithValue("@email", clglist.Email);
               cmd.Parameters.AddWithValue("@phoneno", clglist.Phoneno);
               cmd.Parameters.AddWithValue("@merit", clglist.Merit);
               cmd.Parameters.AddWithValue("@city", clglist.City);
               cmd.Parameters.AddWithValue("@zipcode", clglist.Zipcode);
               cmd.Parameters.AddWithValue("@createdby",clglist.Createdby);
               cmd.Parameters.AddWithValue("@updatedby",clglist.Updatedby);
                 if (clglist.Createddate != DateTime.MinValue)
                {
                    cmd.Parameters.AddWithValue("@createdDate", clglist.Createddate);
                }
                 if (clglist.Updateddate != DateTime.MinValue)
                     cmd.Parameters.AddWithValue("@UpdatedDate", clglist.Updateddate);
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

       public int Update(clglistBEL clglist)
       {
           SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
           con.Open();
           SqlCommand cmd = new SqlCommand("collagelistUpdate", con);
           cmd.CommandType = CommandType.StoredProcedure;
           try
           {
               cmd.Parameters.AddWithValue("@id", clglist.Id);
               cmd.Parameters.AddWithValue("@name", clglist.Name);
               cmd.Parameters.AddWithValue("@address", clglist.Address);
               cmd.Parameters.AddWithValue("@fax", clglist.Fax);
               cmd.Parameters.AddWithValue("@email", clglist.Email);
               cmd.Parameters.AddWithValue("@phoneno", clglist.Phoneno);
               cmd.Parameters.AddWithValue("@merit", clglist.Merit);
               cmd.Parameters.AddWithValue("@city", clglist.City);
               //cmd.Parameters.AddWithValue("@zipcode", clglist.Zipcode);
               cmd.Parameters.AddWithValue("@createdby", clglist.Createdby);
               cmd.Parameters.AddWithValue("@updatedby", clglist.Updatedby);
               
                if (clglist.Createddate != DateTime.MinValue)
               {
                   cmd.Parameters.AddWithValue("@createdDate", clglist.Createddate);
               }
               if (clglist.Updateddate != DateTime.MinValue)
                   cmd.Parameters.AddWithValue("@UpdatedDate", clglist.Updateddate);
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
           var cmd = new SqlCommand("collagelistSelectAll", con);
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
           var cmd = new SqlCommand("collagelistSelectbyId", con);
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
           var cmd = new SqlCommand("Collagelistdelete", con);
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

       public DataSet Search(string searchstring)
       {
           var ds = new DataSet();

           var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
           con.Open();
           var cmd = new SqlCommand("collagesearch", con);
           cmd.Parameters.AddWithValue("@Searchstring", searchstring);
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
