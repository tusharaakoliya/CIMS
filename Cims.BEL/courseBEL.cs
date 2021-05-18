using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cims.BEL
{
   public class courseBEL
    {
       private int course_id;
       private string shortname;
       private string fullname;
       private long createdby;
       private long updatedby;
       private DateTime createddate;
       private DateTime updateddate;

       public int Course_id
       {
           get { return course_id; }
           set { course_id = value; }
       }
       public string Shortname
       {
           get { return shortname;}
           set { shortname = value; }
       }
       public string Fullname
       {
           get { return fullname; }
           set { fullname = value; }
       }
       public long Createdby
       {
           get { return createdby; }
           set { createdby = value; }
       }
       public long Updatedby
       {
           get { return updatedby; }
           set { updatedby = value; }
       }
       public DateTime Createddate
       {
           get { return createddate; }
           set { createddate = value; }
       }
       public DateTime Updateddate
       {
           get { return updateddate; }
           set { Updateddate = value; }
       }

       public DateTime CreatedDate { get; set; }
    }  
}
