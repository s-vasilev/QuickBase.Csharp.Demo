using System.Collections.Generic;
using System.Linq;

namespace QuickBase.Domain.Models
{
    /// <summary>The country domain model.</summary>
    public class Country
    {
        /// <summary>Gets or sets the country identifier.</summary>
        /// <value>The country identifier.</value>
        public int? CountryId { get; set; }

        /// <summary>Gets or sets the name of the country.</summary>
        /// <value>The name of the country.</value>
        public string CountryName { get; set; }

        /// <summary>Gets the population.</summary>
        /// <value>The population.</value>
        public int Population
        {
            get
            {
                return States != null ? (int)States.Sum(x => x.Population) : 0;
            }
        }

        /// <summary>Gets or sets the states.</summary>
        /// <value>The states.</value>
        public virtual ICollection<State> States { get; set; }


    }
}
