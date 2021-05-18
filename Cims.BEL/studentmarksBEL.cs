using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cims.BEL
{
   public class studentmarksBEL
    {
       private int id;
       private long studentid;
       private string marks;
       private int subjectid;

       public int Id
       {
           get { return id;}
           set { id = value; }
       }
       
       public long StudentId
       {
           get { return studentid; }
           set { studentid = value; }
       }

       public string Marks
       {
           get { return marks; }
           set { marks = value; }
       }

       public int SubjectId
       {
           get { return subjectid; }
           set { subjectid = value; }
       }

       
    }
}
