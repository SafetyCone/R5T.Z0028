using System;

using R5T.T0131;


namespace R5T.Z0028
{
    /// <summary>
    /// Actual interface names for use when trying to find a type by name during reflection, or when generating code.
    /// </summary>
    [ValuesMarker]
    public partial interface IInterfaceNames : IValuesMarker
    {
        /// <summary>
        /// Interface for an aggregation for a service implementation.
        /// </summary>
        public string IServiceAggregation => "IServiceAggregation";

        /// <summary>
        /// Interface for an increment to a service aggregation for a service implementation.
        /// </summary>
        public string IServiceAggregationIncrement => "IServiceAggregationIncrement";
    }
}
