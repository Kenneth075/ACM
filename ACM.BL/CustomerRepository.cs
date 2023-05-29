using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        //Retrieve one customer.
        public Customer Retrieve(int customerId)
        {
            //Create the instance of a customer class. Pass in the required id.

            Customer customer = new Customer(customerId);

            //Code that retrieves the define customer.

            //Temporary hard-coded values to return a populated customer.

            if (customerId == 1)
            {
                customer.EmailAddress = "edoho@gmail.com";
                customer.FirstName = "Ken";
                customer.LastName = "Edoho";
            }
            return customer;
        }

        //Save the current customer.Code that save the pass in customer.
        public bool Save(Customer customer)
        {
            return true;
        }
        

    }
}
