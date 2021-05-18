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
    public class branchBAL
    {
        public void insert(branchBEL branch)
        {
            branchDAL objdal = new branchDAL();
            try
            {
                objdal.insert(branch);
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

        public void Update(branchBEL branch)
        {
            branchDAL objdal = new branchDAL();
            try
            {
                objdal.Update(branch);
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
            branchDAL objBranchDal = new branchDAL();
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

        public DataSet SelectById(int branchId)
        {
            branchDAL objBranchDal = new branchDAL();
            try
            {
                return objBranchDal.SelectById(branchId);
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

        public void Delete(int branchId)
        {
            branchDAL objbranch = new branchDAL();
            try
            {
                objbranch.Delete(branchId);
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

        public DataSet Search(string branchname)
        {
            branchDAL objBranchDal = new branchDAL();
            try
            {
                return objBranchDal.Search(branchname);
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

       
    }


}
