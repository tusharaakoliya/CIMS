using Cias.DAL;
using Cims.BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cims.BAL
{
    class clgtypeBAL
    {
        public int clgInsert(clgtypeBEL clgdetail)
        {
            clgtypeDAL objUserDAL = new clgtypeDAL();
            try
            {
                return objUserDAL.insert(clgdetail);
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

        public int clgupdate(clgtypeBEL clgDetails)
        {
            clgtypeDAL objUserDAL = new clgtypeDAL();
            try
            {
                return objUserDAL.Update(clgDetails);
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
            clgtypeDAL objUserDal = new clgtypeDAL();
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
            clgtypeDAL objUserDal = new clgtypeDAL();
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
            clgtypeDAL objUserDal = new clgtypeDAL();
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
