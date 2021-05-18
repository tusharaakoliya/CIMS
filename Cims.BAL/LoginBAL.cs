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
    public class LoginBAL
    {
        public DataTable Login(string loginId, string password)
        {
            LoginDAL objLogindal = new LoginDAL();
            try
            {
                return objLogindal.Login(loginId,password).Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objLogindal = null;
            }
        }

        public int Insert(LoginBEL login)
        {
            LoginDAL objdal = new LoginDAL();
            try
            {
                return objdal.Insert(login);
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

        public int UpdateStudent(LoginBEL studentDetails)
        {
            LoginDAL objUserDAL = new LoginDAL();
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
            LoginDAL objUserDal = new LoginDAL();
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

        public DataSet SelectById(int Userid)
        {
            LoginDAL objUserDal = new LoginDAL();
            try
            {
                return objUserDal.SelectById(Userid);
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

        public void Delete(int Userid)
        {
            LoginDAL objUserDal = new LoginDAL();
            try
            {
                objUserDal.Deleteall(Userid);
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
