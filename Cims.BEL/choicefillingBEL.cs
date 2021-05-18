using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cims.BEL
{
    public class choicefillingBEL
    {
        private int id;
        private int courseid;
        private int branchid;
        private long collageid;
        private long studentid;
        private DateTime createddate;
        private DateTime updatedate;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Courseid
        {
            get { return courseid; }
            set { courseid = value; }
        }
        public int BranchId
        {
            get { return branchid; }
            set { branchid = value; }
        }
        public long CollageId
        {
            get { return collageid; }
            set { collageid = value; }
        }
        public long StudentId
        {
            get { return studentid; }
            set { studentid = value; }
        }

        public DateTime Createdate
        {
            get { return createddate; }
            set { createddate = value; }
        }
        public DateTime Updatedate
        {
            get { return updatedate; }
            set { updatedate = value; }
        }
    }

}
