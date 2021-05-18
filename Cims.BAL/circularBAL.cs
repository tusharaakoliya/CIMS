using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cims.BEL;
using Cias.DAL;
using System.Data;

namespace Cims.BAL
{
   public class circularBAL
    {
       public void insert(circularBEL circular)
       {
           circularDAL objdal = new circularDAL();
           try
           {
               objdal.insert(circular);
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               objdal = null;
           }
       }

       public int Updateclglist(circularBEL circular)
       {
           circularDAL obj = new circularDAL();
           try
           {
               return obj.Update(circular);
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               obj = null;
           }
       }

       public DataSet SelectAll()
       {
           circularDAL obj = new circularDAL();
           try
           {
               return obj.SelectAll();
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               obj = null;
           }
       }

       public DataSet SelectById(int circular_id)
       {
           circularDAL obj = new circularDAL();
           try
           {
               return obj.SelectById(circular_id);
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               obj = null;
           }
       }

       public void Delete(int circular_id)
       {
           circularDAL obj = new circularDAL();
           try
           {
               obj.Deleteall(circular_id);
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               obj = null;
           }
       }
    }
}
