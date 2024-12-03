using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp35
{
    public abstract class Product
    {
        public string battery;
        public string RAM;
        public string corpus;
        public string CP;
        public string VideoCard;

        public Product()
        {
        }
        public Product(Product p) 
        { 
            battery = p.battery;    
            RAM = p.RAM;
            corpus = p.corpus;
            CP = p.CP;
            VideoCard = p.VideoCard;
        }

        abstract public Product clone();
      public string Tostring()
        {
            return "battery="+battery+ ", RAM="+RAM+ ", corpus=" + corpus + ", CP= "+CP+", VideoCard=" + VideoCard ;
        }
    }
    
}
