using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cias.DAL;
using Cims.BEL;
using System.Data;

namespace Cims.BAL
{
 public class choicefilingBAL
    {
     public void insert(choicefillingBEL choice)
     {

         choicefilingDAL objdal = new choicefilingDAL();
         try
         {
             objdal.insert(choice);
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

     public void Update(choicefillingBEL choice)
     {
         choicefilingDAL objdal = new choicefilingDAL();
         try
         {
             objdal.Update(choice);
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

     public DataSet SelectAll()
     {
         choicefilingDAL objBranchDal = new choicefilingDAL();
         try
         {
             return objBranchDal.SelectAll();
         }
         catch (Exception ex)
         {
             throw ex;
         }
         finally
         {
             objBranchDal = null;
         }
     }

     public DataSet SelectById(int id)
     {
         choicefilingDAL objBranchDal = new choicefilingDAL();
         try
         {
             return objBranchDal.SelectById(id);
         }
         catch (Exception ex)
         {
             throw ex;
         }
         finally
         {
             objBranchDal = null;
         }
     }

     public void Delete(int id)
     {
         choicefilingDAL objbranch = new choicefilingDAL();
         try
         {
             objbranch.Delete(id);
         }
         catch (Exception ex)
         {
             throw ex;
         }
         finally
         {
             objbranch = null;
         }
     }

     public DataSet SelectAllbyStudent(long studentId)
     {
         choicefilingDAL obj = new choicefilingDAL();
         try
         {
             return obj.SelectAllbyStudent(studentId);
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

     public DataSet SearchSelestedChoice(String searchString)
     {
         choicefilingDAL obj = new choicefilingDAL();
         try
         {
             return obj.SearchSelestedChoice(searchString);
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

     public DataSet Result(long studentId)
     {
         choicefilingDAL obj = new choicefilingDAL();
         try
         {
             return obj.Result(studentId);
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
