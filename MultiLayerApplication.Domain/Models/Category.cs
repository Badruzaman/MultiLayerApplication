using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayerApplication.Domain.Models
{
    public class Category
    {
        public Category()
        {

        }

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }
        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
