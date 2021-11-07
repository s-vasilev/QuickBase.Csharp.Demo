namespace QuickBase.Business.Dtos
{
    /// <summary>City Dto model.</summary>
    public class CityDto
    {
        /// <summary>Gets or sets the city identifier.</summary>
        /// <value>The city identifier.</value>
        public int Id { get; set; }

        /// <summary>Gets or sets the city name.</summary>
        /// <value>The city name.</value>
        public string Name { get; set; }

        /// <summary>Gets or sets the city population.</summary>
        /// <value>The city population.</value>
        public int Population { get; set; }
    }
}
