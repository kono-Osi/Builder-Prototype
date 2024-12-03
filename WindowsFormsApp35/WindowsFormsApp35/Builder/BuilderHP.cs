using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp35
{
    public class BuilderHP:Builder
    {
        private Product p;
        void reset()
        { 
        p = new Product1();  
        }

        public override void createBattery()
        
        {
            p.battery = "18000";
        }

        public override void createRAM() 
        {
            p.RAM = "16gb";
        }
        public override void createcorpus() 
        {
            p.corpus = "big";
        }
        public override void createCP() 
        {
            p.CP = "strog";
        }
        public override void createVideoCard()
        {
            p.VideoCard = "strong";
        }

        public override Product getResult()
        {
            reset();
            createBattery();
            createRAM();
            createcorpus();
            createCP();
            createVideoCard();
            return p;
        }

    }
}
