using System;


namespace R5T.Z0028
{
    public class ClassNames : IClassNames
    {
        #region Infrastructure

        public static IClassNames Instance { get; } = new ClassNames();


        private ClassNames()
        {
        }

        #endregion
    }
}
