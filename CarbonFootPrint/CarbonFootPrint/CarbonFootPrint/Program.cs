using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    class Program
    { enum CarbonSource
        {
            None,
            Cars,
            Bike,
            Building
        }
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Buildings b = new Buildings();
            Bike bike = new Bike();
            string N;
            int gallons;

            ArrayList carbonsourceList = new ArrayList();
            //Car c2 = new Car (15);

            int mc = 0;

            while (mc != 4)
            {

                Console.WriteLine("Hello, Please choose one of the oprions 1.car 2.buildings 3.bike & 4. exit");
                N = Console.ReadLine();
                mc = Convert.ToInt32(N);
                //mc = Int32.Parse (Console.Read(N));

                // this block processses entering Car items to th list 
                if (mc == 1)
                {
                    Console.WriteLine("Type the car name");

                    N = Console.ReadLine();
                    c1.setName(N);
                    Console.WriteLine("Type number of Gallons");
                    N = Console.ReadLine();
                    gallons = Int32.Parse(N);
                    c1.setNumberofGallons(gallons);
                    //Console.WriteLine (" number of gallons"+c1.getNumberofGallons() );
                    // Console.WriteLine ("Carbon prin of c2 " + c2.getCFP() );
                    c1.calulateCFP();


                    Console.WriteLine("Carbon print" + c1.getName() + " number of gallons" + c1.getNumberofGallons() + " CFP = " + c1.getCFP());
                    // Console.WriteLine ("Carbon prin of c2 " + c2.getCFP() );
                    carbonsourceList.Add(c1);
                    Console.WriteLine("there are " + carbonsourceList.Count + " array items");
                }
                else if (mc == 2)
                {
                    Console.WriteLine("Type the Building name");

                    N = Console.ReadLine();
                    b.setName(N);
                    Console.WriteLine("Type Square feet");
                    N = Console.ReadLine();
                    gallons = Int32.Parse(N);
                    b.setNumberofGallons(gallons);
                    //Console.WriteLine (" number of gallons"+c1.getNumberofGallons() );
                    // Console.WriteLine ("Carbon prin of c2 " + c2.getCFP() );
                    b.calulateCFP();


                    Console.WriteLine("Carbon print" + b.getName() + " Square feet" + b.getNumberofGallons() + " CFP = " + b.getCFP());
                    // Console.WriteLine ("Carbon prin of c2 " + c2.getCFP() );
                    carbonsourceList.Add(b);
                    Console.WriteLine("there are " + carbonsourceList.Count + " array items");

                }
                else if (mc == 3)
                {
                    Console.WriteLine("Type the Bike name");

                    N = Console.ReadLine();
                    bike.setName(N);
                    Console.WriteLine("Your Bike has no carbon emission");
                    //N = Console.ReadLine ();
                    //gallons = Int32.Parse (N);
                    //bike.setNumberofGallons (gallons);
                    //Console.WriteLine (" number of gallons"+c1.getNumberofGallons() );
                    // Console.WriteLine ("Carbon prin of c2 " + c2.getCFP() );
                    //bike.calulateCFP ();


                    //Console.WriteLine ("Carbon print" + b.getName () + " Square feet" + b.getNumberofGallons () + " CFP = " + b.getCFP ());
                    // Console.WriteLine ("Carbon prin of c2 " + c2.getCFP() );
                    carbonsourceList.Add(bike);
                    Console.WriteLine("there are " + carbonsourceList.Count + " array items");


                }
            }
        }
    }
}

