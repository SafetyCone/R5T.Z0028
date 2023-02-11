using System;


namespace R5T.Z0028
{
    public class VariableNames : IVariableNames
    {
        #region Infrastructure

        public static IVariableNames Instance { get; } = new VariableNames();


        private VariableNames()
        {
        }

        #endregion
    }
}
