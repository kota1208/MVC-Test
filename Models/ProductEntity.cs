using System.ComponentModel.DataAnnotations;

namespace MVC_Test.Models
{
    public class ProductEntity
    {

        public int ProductID { get; set; }

        [Display(Name = "商品名")]
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }


       
    }
}
