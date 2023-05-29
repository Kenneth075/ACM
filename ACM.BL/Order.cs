using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    internal class Order
    {
        public Order()
        {

        }

        public Order(int OrderID)
        {
            OrderId = OrderID;
        }
       
        public DateTimeOffset? OrderDate { get; set; }
        
        public int OrderId { get; set; }

        //Validate
        public bool Validate()
        {
            var IsValid = true;

            if(OrderDate == null)
                IsValid = false;

            return IsValid;
        }

        //Retrieve
        public Order Retrieve(int OrderID)
        {
            return new Order();
        }

        //Retrieve for multiple OrderID's
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        //Save
        public bool Save()
        {
            return true;
        }
 
    
    
    
    
    
    
    
    
    }
}
