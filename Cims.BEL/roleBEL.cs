using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;

namespace Cims.BEL
{
   public class roleBEL
    {
       private int id;
       private string name;
       private string description;

       public int Id
   {
         get{return id;}
            set{id=value;}
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
    }
}
