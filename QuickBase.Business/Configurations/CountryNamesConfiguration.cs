using System.Collections.Generic;

namespace QuickBase.Business.Configurations
{
    /// <summary>Country names configuration model.</summary>
    public class CountryNamesConfiguration
    {
        /// <summary>Gets the countries names.</summary>
        /// <value>The countries names.</value>
        public Dictionary<string, List<string>> CountriesNames { get; private set; }
    }
}
