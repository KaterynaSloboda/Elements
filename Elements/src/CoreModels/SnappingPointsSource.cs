using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elements
{
    /// <summary>
    /// The source of snapping points
    /// </summary>
    public enum SnappingPointsSource
    {
        /// <summary>
        /// Elements doesn't have snapping points
        /// </summary>
        None,
        /// <summary>
        /// The ElementRepresentation.
        /// </summary>
        ElementRepresentation,
        //TODO: add glb source
        // Glb
    }
}