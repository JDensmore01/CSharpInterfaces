using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterface_Lib
{
    /// <summary>
    /// This is the IVehicle Interface
    /// </summary>
    public interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        int Speed { get; set; }
        int Gear { get; set; }

        /// <summary>
        /// The ChangeGear contract method from IVehicle
        /// </summary>
        /// <param name="newGear">The gear we want to change to</param>
        void ChangeGear(int newGear);

        /// <summary>
        /// Speed up the vehicle to a defined number km/h
        /// </summary>
        /// <param name="increment">Increment increase in speed in km/h</param>
        void SpeedUp(int increment);

        /// <summary>
        /// Slow down the vehicle
        /// </summary>
        /// <param name="decrement">Decrement of km/h</param>
        void ApplyBrake(int decrement);
    }
}
