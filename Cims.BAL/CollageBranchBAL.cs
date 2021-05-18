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
    public class CollageBranchBAL
    {
        public DataSet SelectAll(long studentId)
        {
            CollageBranchDAL obj = new CollageBranchDAL();
            try
            {
                return obj.SelectAll(studentId);
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

        public DataSet SearchClgBranch(String searchString)
        {
            CollageBranchDAL obj = new CollageBranchDAL();
            try
            {
                return obj.SearchClgBranch(searchString);
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

        public void insert(CollageBranchBEL clgbranchdetail)
        {
            CollageBranchDAL objdal = new CollageBranchDAL();
            try
            {
                objdal.Insert(clgbranchdetail);
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

        public void Update(CollageBranchBEL clgbranchdetail)
        {
            CollageBranchDAL objdal = new CollageBranchDAL();
            try
            {
                objdal.Update(clgbranchdetail);
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

        public void Delete(int id)
        {
            CollageBranchDAL objclgbranch = new CollageBranchDAL();
            try
            {
                objclgbranch.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objclgbranch = null;
            }
        }
        
        public void SelectbyId(int id)
        {
            CollageBranchDAL objclgBranch = new CollageBranchDAL();
            try
            {
                 objclgBranch.SelectById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objclgBranch = null;
            }
        }

        public DataSet AdminSelectAll()
        {
            CollageBranchDAL obj = new CollageBranchDAL();
            try
            {
                return obj.AdminSelectAll();
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
