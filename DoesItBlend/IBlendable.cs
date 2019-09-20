using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// Interface for items that can be blended
    /// </summary>
    interface IBlendable
    {
        /// <summary>
        /// blends the object
        /// </summary>
        /// <returns>a string describing the blended object.</returns>
        string Blend();
    }
}
