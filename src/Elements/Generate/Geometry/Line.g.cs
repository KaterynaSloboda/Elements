//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.0.24.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Elements.Geometry
{
    #pragma warning disable // Disable all warnings

    using Elements.Geometry;
    using Elements.Geometry.Solids;
    using Elements.Properties;
    using System.Collections.Generic;
    
    /// <summary>A linear curve between two points.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.24.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Line : Curve
    {
        /// <summary>The start of the line.</summary>
        [Newtonsoft.Json.JsonProperty("Start", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Vector3 Start { get; internal set; } = new Vector3();
    
        /// <summary>The end of the line.</summary>
        [Newtonsoft.Json.JsonProperty("End", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Vector3 End { get; internal set; } = new Vector3();
    
    
    }
}