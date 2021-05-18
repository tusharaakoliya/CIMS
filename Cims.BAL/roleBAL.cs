using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cims.BEL;
using Cias.DAL;
using System;
using System.Data;
using Cims.DAL;
namespace Cims.BAL
{
   public class roleBAL
    {
       public void roleinsert(roleBEL roledetail)
       {
           roleDAL objdal = new roleDAL();
           try
           {
               objdal.Insert(roledetail);

           }

           catch (Exception EX)
           {
               throw EX;
           }
           finally
           {
               objdal = null;
           }
       }

       public int roleUpdate(roleBEL roledetail)
       {
           roleDAL objUserDAL = new roleDAL();
           try
           {
               return objUserDAL.Update(roledetail);
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               objUserDAL = null;
           }
       }

       public DataSet SelectAll()
       {
           roleDAL objUserDal = new roleDAL();
           try
           {
               return objUserDal.SelectAll();
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               objUserDal = null;
           }
       }

       public DataSet SelectById(int id)
       {
           roleDAL objUserDal = new roleDAL();
           try
           {
               return objUserDal.SelectById(id);
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               objUserDal = null;
           }
       }

       public void Delete(int id)
       {
           roleDAL objUserDal = new roleDAL();
           try
           {
               objUserDal.Deleteall(id);
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               objUserDal = null;
           }
       }
   }
}
