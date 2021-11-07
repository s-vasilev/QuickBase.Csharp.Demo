namespace QuickBase.Business.Dtos
{
    /// <summary>Country Dto model.</summary>
    public class CountryDto
    {
        /// <summary>Gets or sets the country identifier.</summary>
        /// <value>The country identifier.</value>
        public int Id { get; set; }

        /// <summary>Gets or sets the country name.</summary>
        /// <value>The country name.</value>
        public string Name { get; set; }

        /// <summary>Gets or sets the country population.</summary>
        /// <value>The country population.</value>
        public int? Population { get; set; }
    }
}
