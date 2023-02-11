using System;

using R5T.T0131;


namespace R5T.Z0028
{
    /// <summary>
    /// Parameter names for use in code generation.
    /// </summary>
    [ValuesMarker]
    public partial interface IParameterNames : IValuesMarker
    {
        /// <summary>
        /// Underscore parameter name, useful for indicating dummy parameters (parameters required to meet a delegate or other method signature requirement, but that are not actually used).
        /// </summary>
        public string _ => "_";

        /// <summary>
        /// Services parameter name for use in service action run methods.
        /// </summary>
#pragma warning disable IDE1006 // Naming Styles
        public string services => "services";
#pragma warning restore IDE1006 // Naming Styles

        /// <summary>
        /// Same as <see cref="IParameterNames.services"/>, just an uppercase property name to allow following naming rules, in case you get upset when naming rules aren't followed.
        /// </summary>
        public string Services => this.services;

        /// <summary>
        /// Same as <see cref="IParameterNames._"/>, just using a word for the property name.
        /// </summary>
        public string Underscore => this._;
    }
}
