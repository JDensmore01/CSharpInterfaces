using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterface_Lib
{
    /// <summary>
    /// An interface that an object will be defining print function
    /// </summary>
    public interface IPrintable
    {
        /// <summary>
        /// Print the details of an object
        /// </summary>
        /// <returns>The object details as a string.</returns>
        string Print();
    }
}
