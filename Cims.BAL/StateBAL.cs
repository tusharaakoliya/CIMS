using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cims.BEL;
using Cims.DAL;
using System.Data;

namespace Cims.BAL
{
   public class StateBAL
    {
       public void StateInsert(StateBEL statedetails) 
       {
           StateDAL objdal = new StateDAL();
           try
           {
               objdal.Insert(statedetails);

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
       
       public int StateUpdate(StateBEL statedetails)
       {
           StateDAL objUserDAL = new StateDAL();
           try
           {
               return objUserDAL.Update(statedetails);
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
           StateDAL objUserDal = new StateDAL();
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

       public DataSet SelectById(int stateid)
       {
           StateDAL objUserDal = new StateDAL();
           try
           {
               return objUserDal.SelectById(stateid);
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

       public void Delete(int stateid)
       {
           StateDAL objUserDal = new StateDAL();
           try
           {
               objUserDal.Deleteall(stateid);
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
 