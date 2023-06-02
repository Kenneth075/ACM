using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order(): this(0)
        {

        }

        public Order(int OrderID)
        {
            OrderId = OrderID;
            OrderItems = new List<OrderItems>();
        }
        public int CustomerId { get; set; }
        public int ShippingAddressID { get; set; }
        public List<OrderItems> OrderItems { get; set; }

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

       
        /*Retrieve for multiple OrderID's
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }*/

        
 
    
    
    
    
    
    
    
    
    }
}
