using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cims.BEL
{
    public class StateBEL
    {
        private long StateId;
        private string StateName;

        public long stateid
        {
            get{return StateId;}
            set{StateId=value;}
        }
        public string statename
        {
            get{return StateName;}
            set{StateName=value;}
        }
    }
}
