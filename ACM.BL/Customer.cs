using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
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
                if(!string.IsNullOrWhiteSpace(FirstName)) //If there is only a firstname, the fullname is initially null.
                                                          //So we set the fullname to the lastname.
                    if (!string.IsNullOrWhiteSpace(FullName))
                    {
                        FullName += ", ";
                    }
                FullName += FirstName; //Setting the fullname to the firstname.

                return FullName;
                
            }
            
        }

       /* public string LastName
        {
            get                            
            {
                return LastName;      //Use this syntax when there is a lot of logic.
            }
            set
            {
                LastName = value;
            }
        }*/


    }
}
