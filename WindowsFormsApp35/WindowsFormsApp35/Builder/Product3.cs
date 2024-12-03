using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp35
{
    public class Product3:Product
    {
        public Product3()
        {
        }
        public  Product3(Product p) : base(p) { }

        public override Product clone()
        {
            return new Product3(this);
        }
    }

}
