using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cims.BEL
{
    public class CollageBranchBEL
    {
        private int id;
        private long collageid;
        private int branchid;
        private string seat;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public long CollageId
        {
            get { return collageid; }
            set { collageid = value; }
        }
        public int BranchId
        {
            get { return branchid; }
            set { branchid = value; }
        }
        public string Seat
        {
            get { return seat; }
            set { seat = value; }
        }
    }
}