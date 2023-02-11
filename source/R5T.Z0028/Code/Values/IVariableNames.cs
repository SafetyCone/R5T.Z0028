using System;

using R5T.T0131;


namespace R5T.Z0028
{
    /// <summary>
    /// Variable names for use in code generation.
    /// </summary>
    [ValuesMarker]
    public partial interface IVariableNames : IValuesMarker
    {
        /// <summary>
        /// The service action variable name for use in generating service implementation AddXAction methods.
        /// </summary>
        public string ServiceAction => "serviceAction";
    }
}
