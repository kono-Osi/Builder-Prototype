using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp35
{
    public class BuilderDell: Builder
    {
        private Product p;
        void reset()
        {
            p = new Product3();
        }

        public override void createBattery()

        {
            p.battery = "2000";
        }

        public override void createRAM()
        {
            p.RAM = "8gb";
        }
        public override void createcorpus()
        {
            p.corpus = "mid";
        }
        public override void createCP()
        {
            p.CP = "weak";
        }
        public override void createVideoCard()
        {
            p.VideoCard = "mid";
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
