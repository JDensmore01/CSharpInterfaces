using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterface_Lib
{
    public class Bicycle : IVehicle
    {
        private string make;

        public string Make 
        { 
            get { return make; }
            set 
            {
                if (!String.IsNullOrEmpty(value) && value.Length > 3)
                {
                    make = value;
                }
                else
                {
                    throw new ArgumentException("Bicycle make must be 4 characters or more.");
                }
                
            }
        }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int Gear { get; set; }

        /// <summary>
        /// Bicycle specific property
        /// </summary>
        public bool KickStandDown { get; private set; }

        /// <summary>
        /// Bicycle specific method
        /// </summary>
        public void DeployKickStand()
        {
            KickStandDown = true;
        }

        /// <summary>
        /// Bicycle specific method
        /// </summary>
        public void UndeployKickStand()
        {
            KickStandDown = false;
        }

        /// <summary>
        /// Bicycle apply break
        /// </summary>
        /// <param name="decrement"></param>
        public void ApplyBrake(int decrement)
        {
            Speed -= decrement;
        }

        /// <summary>
        /// Bicycle change gear
        /// </summary>
        /// <param name="newGear"></param>
        public void ChangeGear(int newGear)
        {  
            if (newGear > 18)
                throw new ArgumentException("Bike only has 18 gears");

            if (newGear == 0)
                throw new ArgumentException("Oops! Th Chain fell off!");

            if (newGear < 0)
                throw new ArgumentException("Reverse not supported in bikesd");

            Gear = newGear;
        }

        /// <summary>
        /// Bicycle Speed up
        /// </summary>
        /// <param name="increment">The amount to speed up</param>
        public void SpeedUp(int increment)
        {
            Speed += increment;
        }
    }
}
