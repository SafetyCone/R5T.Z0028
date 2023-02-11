using System;

using R5T.T0131;


namespace R5T.Z0028
{
    /// <summary>
    /// Actual class names for use when trying to find a type by name during reflection, or when generating code.
    /// </summary>
    [ValuesMarker]
    public partial interface IClassNames : IValuesMarker
    {
        /// <summary>
        /// Each project is generated with a documentation class.
        /// </summary>
        public string Documentation => "Documentation";

        /// <summary>
        /// Used for service-based programs, to contain methods specifying how to configure an application host.
        /// </summary>
        public string HostStartup => "HostStartup";

        /// <summary>
        /// Used for service aggregation implementation classes.
        /// </summary>
        public string ServiceAggregation => "ServiceAggregation";
    }
}
