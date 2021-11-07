using QuickBase.Business.Interfaces.Repositories;
using System;
using System.Threading.Tasks;

namespace QuickBase.Business.Interfaces.SqliteData
{
    /// <summary>Interface for the unit of work class.</summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>Gets the cities.</summary>
        /// <value>The cities.</value>
        ICityRepository Cities { get; }

        /// <summary>Gets the states.</summary>
        /// <value>The states.</value>
        IStateRepository States { get; }

        /// <summary>Gets the countries.</summary>
        /// <value>The countries.</value>
        ICountryRepository Countries { get; }

        /// <summary>Saves this changes to the database.</summary>
        /// <returns>The result of the operation.</returns>
        Task<bool> Save();
    }
}
