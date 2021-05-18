using Cias.DAL;
using Cims.BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Cims.BAL
{
    public class studentmarksBAL
    {
        public void insert(studentmarksBEL studentmarks)
        {
            studentmarksDAL objdal = new studentmarksDAL();
            try
            {
                objdal.Insert(studentmarks);
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

        public void Update(studentmarksBEL studentmarks)
        {
            studentmarksDAL objdal = new studentmarksDAL();
            try
            {
                objdal.Update(studentmarks);
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
            studentmarksDAL objStudentMarksDal = new studentmarksDAL();
            try
            {
                return objStudentMarksDal.SelectAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objStudentMarksDal = null;
            }
        }

        public DataSet Select(int studentId)
        {
            studentmarksDAL objUserDal = new studentmarksDAL();
            try
            {
                return objUserDal.Select(studentId);
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

        public DataSet MeritList()
        {
            studentmarksDAL objStudentMarksDal = new studentmarksDAL();
            try
            {
                return objStudentMarksDal.MeritList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objStudentMarksDal = null;
            }
       
        }
    }
}
