using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cims.BEL
{
    public class branchBEL
    {
        private int id;
        private string branchname;
        private string description;
        private int branchid;
        private int _courseId;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Branchname
        {
            get { return branchname; }
            set { branchname = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Branchid
        {
            get { return branchid; }
            set { branchid = value; }
        }

        public int CourseId
        {
            get { return _courseId; }
            set { _courseId = value; }
        }

    }
}
