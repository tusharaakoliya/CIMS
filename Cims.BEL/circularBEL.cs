using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cims.BEL
{
    public class circularBEL
    {
        private int id;
        private string name;
        private string description;
        private string status;
        private DateTime cdate;
        private DateTime createddate;
        private DateTime upadateddate;
        private long createdby;
        private long upadatedby;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public DateTime Cdate
        {
            get { return cdate; }
            set { cdate = value; }
        }
        public DateTime Createddate
        {
            get { return createddate; }
            set { createddate = value; }
        }
        public DateTime Updateddate
        {
            get { return Updateddate; }
            set { Updateddate = value; }
        }
        public long Createdby
        {
            get { return createdby; }
            set { createdby = value; }
        }
        public long Updatedby
        {
            get { return upadatedby; }
            set { upadatedby = value; }
        }
    }
}
