using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Domain.Entities
{
    public class Product : Concept
    {
        public DateTime DateProd { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }

        public virtual Category Category { get; set; }
        public virtual IList <Provider> Providers { get; set; }

        public override string GetDetails()
        {

            return $"{Name} - {Description} - {Price} - {Quantity}";

        }

        public Product()
        {
            Category = new Category();
            Providers = new List<Provider>();
        }

        public virtual void GetMyType()
        {
            Console.WriteLine("i am an unknown product");
        }
    }
}
