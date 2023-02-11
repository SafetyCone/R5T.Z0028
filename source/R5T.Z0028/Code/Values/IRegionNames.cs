using System;

using R5T.T0131;


namespace R5T.Z0028
{
    /// <summary>
    /// Region names for use in code generation.
    /// </summary>
    [ValuesMarker]
    public partial interface IRegionNames : IValuesMarker
    {
        /// <summary>
        /// The region containing static properties and methods.
        /// </summary>
        public static string Static => "Static";
    }
}
