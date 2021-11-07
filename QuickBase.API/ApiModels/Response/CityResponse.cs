namespace QuickBase.API.ApiModels.Response
{
    /// <summary>City Response Model.</summary>
    public class CityResponse
    {
        /// <summary>Gets or sets the city name.</summary>
        /// <value>The city name.</value>
        public string Name { get; set; }

        /// <summary>Gets or sets the city population.</summary>
        /// <value>The city population.</value>
        public int? Population { get; set; }
    }
}
