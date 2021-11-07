using QuickBase.Business.Configurations;
using QuickBase.Business.Interfaces.Helpers;
using System;
using System.Collections.Generic;

namespace QuickBase.Business.Helpers
{
    /// <summary>Country names helper.</summary>
    public class CountryNamesHelper : ICountryNamesHelper
    {
        private readonly CountryNamesConfiguration _countryNamesConfig;

        /// <summary>Initializes a new instance of the <see cref="CountryNamesHelper" /> class.</summary>
        /// <param name="countryNamesConfig">The country names configuration.</param>
        /// <exception cref="System.Exception">The configuration for country names could not be loaded</exception>
        public CountryNamesHelper(CountryNamesConfiguration countryNamesConfig)
        {
            _countryNamesConfig = countryNamesConfig;

            if (_countryNamesConfig == null)
            {
                //TODO: new ConfigurationException
                throw new Exception("The configuration for country names could not be loaded");
            }
        }

        /// <summary>Gets the country aliases.</summary>
        /// <param name="countryName">Name of the country.</param>
        /// <returns>The country aliases.</returns>
        public List<string> GetCountryAliases(string countryName) 
        {
            if (_countryNamesConfig.CountriesNames.ContainsKey(countryName))
            {
                return _countryNamesConfig.CountriesNames[countryName];
            }
            return new List<string>();
        }

        /// <summary>Gets all country aliases.</summary>
        /// <returns>The country aliases.</returns>
        public Dictionary<string,List<string>> GetAllAliases()
        {
            return _countryNamesConfig.CountriesNames;
        }
    }
}
