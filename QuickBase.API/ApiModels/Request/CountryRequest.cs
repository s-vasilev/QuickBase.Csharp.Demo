namespace QuickBase.API.ApiModels.Request
{
    /// <summary>Country request model.</summary>
    public class CountryRequest
    {

        /// <summary>Gets or sets the country identifier.</summary>
        /// <value>The country identifier.</value>
        public int Id { get; set; }


        /// <summary>Gets or sets the country name.</summary>
        /// <value>The county name.</value>
        public string Name { get; set; }
    }
}
