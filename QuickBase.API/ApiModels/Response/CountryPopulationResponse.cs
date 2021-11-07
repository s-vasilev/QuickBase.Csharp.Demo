namespace QuickBase.API.ApiModels.Response
{
    /// <summary>Country Population Model.</summary>
    public class CountryPopulationResponse
    {
        /// <summary>Gets or sets the county identifier.</summary>
        /// <value>The country identifier.</value>
        public int Id { get; set; }

        /// <summary>Gets or sets the country name.</summary>
        /// <value>The country name.</value>
        public string Name { get; set; }

        /// <summary>Gets or sets the country population.</summary>
        /// <value>The country population.</value>
        public int Population { get; set; }
    }
}
