using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Cias.DAL
{
    public class Login
    {
        public static Guid Insert(string firstName, string middleName, string lastName, bool gender, string emailId, string address, string city, string state, string country, string mobileNo, string phoneNo, int zipCode, double salary, string designation, DateTime hireDate, string skills, bool status, string loginId, string password, DateTime birthDate, int shiftID, string photograph, Guid reportsto, string bloodGroup, int cardNo, string bankName, string bankAccoNo, string branchName, Guid departmentID, Guid createdBy, DateTime createdDate, Guid updatedBy, DateTime updatedDate)
        {
            Database db = null;
            DbCommand dbCommand = null;
            try
            {
                db = DatabaseFactory.CreateDatabase();
                dbCommand = db.GetStoredProcCommand("EmployeeInsert");
                db.AddInParameter(dbCommand, "FirstName", DbType.String, firstName);
                db.AddInParameter(dbCommand, "MiddleName", DbType.String, middleName);
                db.AddInParameter(dbCommand, "LastName", DbType.String, lastName);
                db.AddInParameter(dbCommand, "Gender", DbType.Boolean, gender);
                db.AddInParameter(dbCommand, "EmailId", DbType.String, emailId);
                db.AddInParameter(dbCommand, "Address", DbType.String, address);
                db.AddInParameter(dbCommand, "City", DbType.String, city);
                db.AddInParameter(dbCommand, "State", DbType.String, state);
                db.AddInParameter(dbCommand, "Country", DbType.String, country);

                db.AddInParameter(dbCommand, "MobileNo", DbType.String, mobileNo);
                db.AddInParameter(dbCommand, "PhoneNo", DbType.String, phoneNo);
                db.AddInParameter(dbCommand, "ZipCode", DbType.Int32, zipCode);
                db.AddInParameter(dbCommand, "Salary", DbType.Double, salary);
                db.AddInParameter(dbCommand, "Designation", DbType.String, designation);
                if (hireDate != DateTime.MinValue)
                    db.AddInParameter(dbCommand, "HireDate", DbType.DateTime, hireDate);
                db.AddInParameter(dbCommand, "Skills", DbType.String, skills);
                db.AddInParameter(dbCommand, "Status", DbType.Boolean, status);
                db.AddInParameter(dbCommand, "LoginId", DbType.String, loginId);
                db.AddInParameter(dbCommand, "Password", DbType.String, password);
                if (birthDate != DateTime.MinValue)
                    db.AddInParameter(dbCommand, "BirthDate", DbType.DateTime, birthDate);
                db.AddInParameter(dbCommand, "ShiftID", DbType.Int32, shiftID);
                db.AddInParameter(dbCommand, "Photograph", DbType.String, photograph);
                db.AddInParameter(dbCommand, "Reportsto", DbType.Guid, reportsto);
                db.AddInParameter(dbCommand, "BloodGroup", DbType.String, bloodGroup);
                db.AddInParameter(dbCommand, "CardNo", DbType.Int32, cardNo);
                db.AddInParameter(dbCommand, "BankName", DbType.String, bankName);
                db.AddInParameter(dbCommand, "BankAccoNo", DbType.String, bankAccoNo);
                db.AddInParameter(dbCommand, "BranchName", DbType.String, branchName);
                db.AddInParameter(dbCommand, "DepartmentID", DbType.Guid, departmentID);
                db.AddInParameter(dbCommand, "CreatedBy", DbType.Guid, createdBy);
                db.AddInParameter(dbCommand, "CreatedDate", DbType.DateTime, DateTime.Now);
                db.AddInParameter(dbCommand, "UpdatedBy", DbType.Guid, updatedBy);
                if (updatedDate != DateTime.MinValue)
                    db.AddInParameter(dbCommand, "UpdatedDate", DbType.DateTime, updatedDate);

                return Guid.Parse(Convert.ToString(db.ExecuteScalar(dbCommand)));
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (dbCommand != null)
                {
                    dbCommand.Dispose();
                    dbCommand = null;
                }
                if (db != null)
                    db = null;
            }
        }
    }
}
