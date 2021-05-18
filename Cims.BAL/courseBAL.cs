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
   public class courseBAL
    {
        public void insert(courseBEL coursedetails)
       {
           courseDAL objdal = new courseDAL();
           try
           {
               objdal.insert(coursedetails);
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

        public int Update(courseBEL coursedetail)
        {
            courseDAL objUserDAL = new courseDAL();
            try
            {
                return objUserDAL.Update(coursedetail);
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
            courseDAL objUserDal = new courseDAL();
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

        public DataSet SelectById(int course_id)
        {
            courseDAL objUserDal = new courseDAL();
            try
            {
                return objUserDal.SelectById(course_id);
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

        public void Delete(int course_id)
        {
            courseDAL objUserDal = new courseDAL();
            try
            {
                objUserDal.Deleteall(course_id);
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
