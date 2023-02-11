using System;


namespace R5T.Z0028
{
    public class RegionNames : IRegionNames
    {
        #region Infrastructure

        public static IRegionNames Instance { get; } = new RegionNames();


        private RegionNames()
        {
        }

        #endregion
    }
}
