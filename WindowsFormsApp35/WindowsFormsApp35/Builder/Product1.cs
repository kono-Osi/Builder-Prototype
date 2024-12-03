using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp35
{
    public class Product1:Product
    {
        public Product1()
        { 
        }
        public Product1(Product p):base(p){}
      
        public override Product clone()
        {
        return new Product1(this);
        }
    }
}
