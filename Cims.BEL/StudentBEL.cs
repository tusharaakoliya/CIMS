using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cims.BEL
{
    public class StudentBEL
    {
        private long studentId;
        private long userId;
        private int enrollmentid;
        private string firstname;
        private string middlename;
        private string lastname;
        private string email;
        private bool gender;
        private DateTime dob;
        private int state;
        private string _city;
        private string mobileno;
        private string _phoneno;
        private string _address;
        private DateTime createdDate;
        private DateTime updatedDate;

        public long StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public long UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public int EnrollmentId
        {
            get { return enrollmentid; }
            set { enrollmentid = value; }
        }

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string MiddleName
        {
            get { return middlename; }
            set { middlename = value; }
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public DateTime DOb
        {
            get { return dob; }
            set { dob = value; }
        }

        public int StateId
        {
            get { return state; }
            set { state = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string MOBILENO
        {
            get { return mobileno; }
            set { mobileno = value; }
        }
        public string phoneNo
        {
            get { return _phoneno; }
            set { _phoneno = value; }
        }
        public string address
        {
            get { return _address; }
            set { _address = value; }
        }
        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        public DateTime UpdatedDate
        {
            get { return updatedDate; }
            set { updatedDate = value; }
        }

        public string StateName { get; set; }
    }
}
