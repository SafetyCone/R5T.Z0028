using System;

using R5T.T0131;


namespace R5T.Z0028
{
    /// <summary>
    /// Actual method names for use in code generation or reflection.
    /// </summary>
    [ValuesMarker]
    public partial interface IMethodNames : IValuesMarker
    {
        /// <summary>
        /// Allows filling mutable properties on an instance from another instance.
        /// Example: Used in service aggregation copying.
        /// </summary>
        public string FillFrom => "FillFrom";

        /// <summary>
        /// Name for a construction method that provides a new instance.
        /// Note: different from the C# constructor method keyword "new", in that this method is capitalized.
        /// </summary>
        public string New => "New";

        /// <summary>
        /// Name for a method that runs something.
        /// Example: used in service implementation ActionX method implementation.
        /// </summary>
        public string Run => "Run";
    }
}
