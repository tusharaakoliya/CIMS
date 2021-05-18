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
    public class clglistBAL
    {
        public int Insertclglist(clglistBEL clgdetail)
        {
            clglistDAL obj = new clglistDAL();
            try
            {
                return obj.Insert(clgdetail);
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

        public int Updateclglist(clglistBEL clgdetail)
        {
            clglistDAL obj = new clglistDAL();
            try
            {
                return obj.Update(clgdetail);
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

        public DataSet SelectAll()
        {
            clglistDAL obj = new clglistDAL();
            try
            {
                return obj.SelectAll();
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

        public DataSet SelectById(int ID)
        {
            clglistDAL obj = new clglistDAL();
            try
            {
                return obj.SelectById(ID);
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

        public void Delete(int ID)
        {
            clglistDAL obj = new clglistDAL();
            try
            {
                obj.Deleteall(ID);
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

        public DataSet Search(string searchstring)
        {
            clglistDAL obj = new clglistDAL();
            try
            {
                return obj.Search(searchstring);
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
