using CSharpInterface_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Using interface IVehicle as our variable type
                IVehicle myBike = new Bicycle();
                IVehicle myCar = new Car();
                IVehicle anotherCar = new Car();

                myBike.Make = "Giantt";
                myBike.Model = "XTC Advanced 29";
                myBike.ChangeGear(15); //Polymorphic call - at runtime it will determine which method to call based on the class in the variable
                myBike.SpeedUp(3); //Polymorphic

                myCar.Make = "Jeep";
                myCar.Model = "Wrangler";
                myCar.ChangeGear(2); //polymorphic
                myCar.SpeedUp(15); //polymorphic

                if(myBike is Bicycle)
                    ((Bicycle)myBike).DeployKickStand();

                List<IVehicle> myRides = new List<IVehicle>() { myBike, myCar, anotherCar };

                foreach (IVehicle v in myRides)
                {
                    P($"{v.Make} \t\t{v.Model}");
                    if (v is Car)
                        v.ChangeGear(0); //Polymorphic
                }

                foreach (IVehicle v in myRides.Where(r=>r is Car))
                {
                    P($"{v.Make} \t\t{v.Model}");
                }
            }
            catch (Exception ex)
            {
                P(ex.Message);                
            }

            Console.ReadLine();
        }


        static void P(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
