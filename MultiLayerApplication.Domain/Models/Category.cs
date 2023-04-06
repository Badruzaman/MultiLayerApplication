
using System.ComponentModel.DataAnnotations;

namespace MultiLayerApplication.Domain.Models
{
    public class Category
    {
        public Category()
        {

        }
        public int CategoryID { get; set; }
        [Required]
        [MaxLength(10)]
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
