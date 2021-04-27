using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterface_Lib
{
    public class Car : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int Gear { get; set; }

        /// <summary>
        /// Car specific property
        /// </summary>
        public double FuelLevel { get; set; }

        /// <summary>
        /// Specific car method
        /// </summary>
        /// <param name="litres">Number of litres to add to the FuelLevel</param>
        public void FillUp(double litres)
        {
            if (litres < 0)
            {
                throw new ArgumentException("Don't siphon gas");
            }                       
            
            FuelLevel += litres;             
        }

        /// <summary>
        /// Apply brake of car
        /// </summary>
        /// <param name="decrement">The speed decrement in km/h</param>
        public void ApplyBrake(int decrement)
        {
            Speed -= decrement;
        }

        /// <summary>
        /// Car change of gear
        /// </summary>
        /// <param name="newGear">The new gear to change to</param>
        public void ChangeGear(int newGear)
        {
            if(newGear > 6)
            {
                throw new ArgumentException("That's some REAL SPEED. But this car maxes out at 6 gears.");
            }

            Gear += newGear;
        }

        /// <summary>
        /// Car speed up
        /// </summary>
        /// <param name="increment">Amount to increase speed in km/h</param>
        public void SpeedUp(int increment)
        {
            Speed += increment;

            if (Speed < 0)
            {
                Gear = -1;
            }
        }
    }
}
