using System.Collections.Generic;
using System.Linq;

namespace QuickBase.Domain.Models
{
    /// <summary>The state domain model.</summary>
    public class State
    {
        /// <summary>Gets or sets the state identifier.</summary>
        /// <value>The state identifier.</value>
        public int StateId { get; set; }

        /// <summary>Gets or sets the name of the state.</summary>
        /// <value>The name of the state.</value>
        public string StateName { get; set; }

        /// <summary>Gets or sets the country identifier.</summary>
        /// <value>The country identifier.</value>
        public int CountryId { get; set; }

        /// <summary>Gets the population.</summary>
        /// <value>The population.</value>
        public int? Population
        {
            get
            {
                return Cities.Sum(x => x.Population);
            }
        }

        /// <summary>Gets or sets the country.</summary>
        /// <value>The country.</value>
        public virtual Country Country { get; set; }

        /// <summary>Gets or sets the cities.</summary>
        /// <value>The cities.</value>
        public virtual ICollection<City> Cities { get; set; }
    }
}
