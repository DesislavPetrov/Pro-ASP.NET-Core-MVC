using System.Collections.Generic;
namespace LanguageApplications.Models
{
    public class ShoppingCart
    {
        public IEnumerable<Product> Products { get; set; }
    }
}