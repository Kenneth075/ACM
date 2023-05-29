using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        //Retrieve one product.
        public Product Retrieve(int ProductId)
        {
            //Create the instance of a product class. Pass in the required id.

            Product product = new Product(ProductId);

            //Code that retrieves the define customer.

            //Temporary hard-coded values to return a populated customer.

            if (ProductId == 2)
            {
                product.ProductName = "Sunflower";
                product.ProductDescription = "Sunflower Big Size";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }
        //Save the current product.

        public bool Save(Product product)
        {
            return true;
        }
 
    
    
    
    
    }
}
