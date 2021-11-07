namespace QuickBase.Domain.Models
{
    /// <summary>The city domain model.</summary>
    public class City
    {
        /// <summary>Gets or sets the city identifier.</summary>
        /// <value>The city identifier.</value>
        public int CityId { get; set; }

        /// <summary>Gets or sets the name of the city.</summary>
        /// <value>The name of the city.</value>
        public string CityName { get; set; }

        /// <summary>Gets or sets the state identifier.</summary>
        /// <value>The state identifier.</value>
        public int? StateId { get; set; }

        /// <summary>Gets or sets the population.</summary>
        /// <value>The population.</value>
        public int? Population { get; set; }

        /// <summary>Gets or sets the state.</summary>
        /// <value>The state.</value>
        public virtual State State { get; set; }
    }
}
