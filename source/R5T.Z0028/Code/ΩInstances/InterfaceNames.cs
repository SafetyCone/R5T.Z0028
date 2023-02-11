using System;


namespace R5T.Z0028
{
    public class InterfaceNames : IInterfaceNames
    {
        #region Infrastructure

        public static IInterfaceNames Instance { get; } = new InterfaceNames();


        private InterfaceNames()
        {
        }

        #endregion
    }
}
