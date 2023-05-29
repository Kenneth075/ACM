using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    internal class OrderItems
    {
        public OrderItems()
        {

        }

        public OrderItems(int OrderItemsID)
        {
            OrderItemsId=OrderItemsID;
        }
        
        public int OrderItemsId { get; set; }

        public int ProductId { get;private set; }

        public decimal? PurchasePrice { get; set; }

        public int Quantity { get; set; }


        //Validate
        public bool Validate()
        {
            var Isvalid = true;

            if(Quantity<=0)
                Isvalid= false;
            if(ProductId<=0) Isvalid= false;
            if(PurchasePrice==null) Isvalid= false;

            return Isvalid;
        }

        //Retrieve (Single)
        public OrderItems Retrieve(int OrderItemsId)
        {
            return new OrderItems(); 
        }

        //Retrieve Multiple ID.
        public List<OrderItems> RetrieveAll()
        {
            return new List<OrderItems>();
        }

        //Save.
        public bool Save()
        {
            return true;
        }
    }
}
