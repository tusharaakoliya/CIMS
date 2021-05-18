using Cias.DAL;
using Cims.BEL;
using System;
using System.Data;

namespace Cims.BAL
{
    public class StudentBAL
    {
        public int InsertStudent(StudentBEL studentDetails)
        {
            StudentDAL objUserDAL = new StudentDAL();
            try
            {
                return objUserDAL.Insert(studentDetails);
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

        public int UpdateStudent(StudentBEL studentDetails)
        {
            StudentDAL objUserDAL = new StudentDAL();
            try
            {
                return objUserDAL.Update(studentDetails);
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
            StudentDAL objUserDal = new StudentDAL();
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

        public DataSet SelectById(int studentId)
        {
            StudentDAL objUserDal = new StudentDAL();
            try
            {
                return objUserDal.SelectById(studentId);
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

        public void Delete(int studentId)
        {
            StudentDAL objUserDal = new StudentDAL();
            try
            {
                 objUserDal.Deleteall(studentId);
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

        public DataSet SelectByuser(int userid)
        {
            StudentDAL objUserDal = new StudentDAL();
            try
            {
                return objUserDal.SelectByUser(userid);
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
