using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp35
{
    abstract public class Builder
    {

        public abstract void createBattery();
        public abstract void createRAM();
        public abstract void createcorpus();
        public abstract void createCP();
        public abstract void createVideoCard();

        public abstract Product getResult();
    }
}
