using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {
            
        }

        public Product(int ProductID)
        {
            ProductId = ProductID;
            
        }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public int ProductId { get;private set; }

        public decimal? CurrentPrice { get; set; }


        //Validation
        public bool Validate()
        {
            var IsValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
                IsValid = false;

            if (CurrentPrice == null)
                IsValid = false;

            return IsValid;

        }


        //Retrieving one product.
        /*public Product Retrieve (int ProductId)
        {
            return new Product();   //Code thats retrieve a define product.
        }

        //For retrieving multiple productId's
        public List<Product> RetrieveAll ()
        {
            return new List<Product>();  //Code to retrieve multiple Id's.
        }

        //Save the current product.
        public bool Save()
        {
            return true;
        }*/

      

 
    
    
    
    
    
    
    
    
    
    
    
    }
}
