using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {
            
        }

        public Customer(int CoustomerId)
        {
            CustomerID = CoustomerId;  
        }


        public int CustomerID { get;private set; }

        public string EmailAddress { get; set; }

        public string LastName { get; set; }   //Use this when there is no logic required.

        public string FirstName { get; set; }

        public string FullNAme
        {
            get
            {
                return LastName + "," + FirstName;
            }
    
        }

        public string FullName
        {
            get
            {
                string FullName = LastName;    //If there is only a lastname define,
                                               //the fullname is the lastname with no commas.

                if(!string.IsNullOrWhiteSpace(FirstName))    //If there is only a firstname, the fullname is initially null.
                                                             //So we set the fullname to the lastname.
                    if (!string.IsNullOrWhiteSpace(FullName))
                    {
                        FullName += ", ";
                    }
                FullName += FirstName; //Setting the fullname to the firstname.

                return FullName;
                
            }
            
        }
        public static int IntanceCount { get; set; }

        public bool Validate()   //Method/function for validation.
        {
            var Isvalid = true;

            if (string.IsNullOrWhiteSpace(FirstName)) Isvalid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) Isvalid = false;

            return Isvalid;
        }   

        /*public List<Customer> RetrieveAll()   //Retrieve function for multiple customers data.
        { 
            return new List<Customer>();
        }*/

        



       




    }
}
