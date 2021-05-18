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
   public class courseDAL
    {
       public void insert(courseBEL courser )
       {
           SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
           con.Open();
           SqlCommand cmd = new SqlCommand("courseInsert", con);
           cmd.CommandType = CommandType.StoredProcedure;
           try
           {
               cmd.Parameters.AddWithValue("@course_id", courser.Course_id);
               cmd.Parameters.AddWithValue("@shortname", courser.Shortname);
               cmd.Parameters.AddWithValue("@fullname", courser.Fullname);
               cmd.Parameters.AddWithValue("@createdby", courser.Createdby);
               cmd.Parameters.AddWithValue("@updatedby", courser.Updatedby);
               if (courser.CreatedDate != DateTime.MinValue)
               {
                   cmd.Parameters.AddWithValue("@createddate", courser.Createddate);
               }
               if(courser.Updateddate!=DateTime.MaxValue)
               {
                   cmd.Parameters.AddWithValue("@updateddate", courser.Updateddate);
               }
           }
           catch (Exception ex)
                {
                    throw ex; 
           }
           finally
           {
               con.Close();
               con.Dispose();
               cmd.Dispose();
           }
       }

       public int Update(courseBEL courser)
       {
           SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
           con.Open();
           SqlCommand cmd = new SqlCommand("courseupdate", con);
           cmd.CommandType = CommandType.StoredProcedure;
           try
           {
               cmd.Parameters.AddWithValue("@course_id", courser.Course_id);
               cmd.Parameters.AddWithValue("@fullname", courser.Fullname);
               cmd.Parameters.AddWithValue("@shortname", courser.Shortname);
               cmd.Parameters.AddWithValue("@createdby", courser.Createdby);
               cmd.Parameters.AddWithValue("@updatedby", courser.Updatedby);
              
               if (courser.CreatedDate != DateTime.MinValue)
               {
                   cmd.Parameters.AddWithValue("@createdDate", courser.CreatedDate);
               }
               if (courser.Updateddate != DateTime.MinValue)
                   cmd.Parameters.AddWithValue("@UpdatedDate", courser.Updateddate);
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
           var cmd = new SqlCommand("courseselectall", con);
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

       public DataSet SelectById(int course_id)
       {
           var ds = new DataSet();

           var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
           con.Open();
           var cmd = new SqlCommand("courseSelectbyId", con);
           cmd.Parameters.AddWithValue("@course_id", course_id);
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

       public void Deleteall(int course_id)
       {
           var con = new SqlConnection(ConfigurationManager.ConnectionStrings["CiasConnection"].ConnectionString);
           con.Open();
           var cmd = new SqlCommand("coursedelete", con);
           cmd.CommandType = CommandType.StoredProcedure;


           try
           {
               cmd.Parameters.AddWithValue("@course_id", course_id);
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
