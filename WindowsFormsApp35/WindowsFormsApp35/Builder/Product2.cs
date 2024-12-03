using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp35
{
    public class Product2: Product
    {
        public Product2()
        {
        }
        public Product2(Product p) : base(p) { }

        public override Product clone()
        {
            return new Product2(this);
        }
    }
}
