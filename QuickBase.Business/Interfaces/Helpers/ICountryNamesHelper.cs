using System.Collections.Generic;

namespace QuickBase.Business.Interfaces.Helpers
{
    /// <summary>Interface for country names helper class.</summary>
    public interface ICountryNamesHelper
    {
        /// <summary>Gets the country aliases.</summary>
        /// <param name="dbCountryName">Name of the database country.</param>
        /// <returns>The country aliases.</returns>
        List<string> GetCountryAliases(string dbCountryName);

        /// <summary>Gets all country aliases.</summary>
        /// <returns>The country aliases.</returns>
        Dictionary<string, List<string>> GetAllAliases();
    }
}
