using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    class Car
    {
        int numberOfGallons;
        string name;
        int CFP;
        //CarbonSource source;

        public Car()
        {
            numberOfGallons = 0;
            name = "";
            CFP = 0;
            //source = CarbonSource.Cars;


        }
        public Car(int g)
        {
            numberOfGallons = g;
            name = "";
            CFP = 20 * g;
            //source = CarbonSource.Cars;

        }

        public int getCFP()
        {
            return CFP;
        }

        public void setName(string N)
        {
            name = N;
        }

        public void setNumberofGallons(int numberOfGallons)
        {
            this.numberOfGallons = numberOfGallons;
        }




        public string getName()
        {
            return name;
        }

        public int getNumberofGallons()
        {
            return numberOfGallons;
        }


        public int calulateCFP()
        {
            CFP = numberOfGallons * 20;
            return CFP;
        }




    
}
}
