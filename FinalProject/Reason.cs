using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{

  
    public class Reason
    {
        public string reasonName { get; set; }
        public double reasonPrice { get; set; }

        public Reason()
        { }

        public void addReason(string reasonName, double reasonPrice)
        {
            this.reasonName = reasonName;
            this.reasonPrice = reasonPrice;
        }
        public override string ToString()
        {
            return String.Format("{0}",reasonName);
        }


    }
}
