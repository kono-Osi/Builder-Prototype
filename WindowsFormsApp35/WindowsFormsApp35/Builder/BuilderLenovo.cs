using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp35
{
    public class BuilderLenovo:Builder
    {
        private Product p;
        void reset()
        {
            p = new Product2();
        }

        public override void createBattery()

        {
            p.battery = "15000";
        }

        public override void createRAM()
        {
            p.RAM = "16gb";
        }
        public override void createcorpus()
        {
            p.corpus = "light";
        }
        public override void createCP()
        {
            p.CP = "mid";
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
