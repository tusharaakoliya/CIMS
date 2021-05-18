using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cims.BEL
{
   public class clglistBEL
    {

       private long id;
       private string name;
       private string address;
       private string fax;
       private string email;
       private string code;
       private int phoneno;
       private string merit;
       private string city;
       private int zipcode;
       private long createdby;
       private long updatedby;
       private DateTime createddate;
       private DateTime updateddate;

       public long Id
       {
           get { return id; }
           set { id = value; }
       }
       public string Name
       {
           get { return name; }
           set { name = value; }
       }
       public string Address
       {
           get { return address; }
           set { address = value; }
       }
       public string Fax
       {
           get { return fax; }
           set { fax = value; }
       }
       public string Email
       {
           get { return email; }
           set { email = value; }
       }
       public string Code
       {
           get { return code; }
           set { code = value; }
       }
       public int Phoneno
       {
           get { return phoneno; }
           set { phoneno = value; }
       }
       public string Merit
       {
           get { return merit; }
           set { merit = value; }
       }
       public string City
       {
           get { return city; }
           set { city = value; }
       }
       public int Zipcode
       {
           get { return zipcode;}
           set { zipcode = value; }
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
           set { updateddate = value; }
       }
    }
}
