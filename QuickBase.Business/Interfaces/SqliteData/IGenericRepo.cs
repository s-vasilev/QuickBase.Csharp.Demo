using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickBase.Business.Interfaces.SqliteData
{
    /// <summary>Inteface for the generic repository class.</summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface IGenericRepo<TEntity> 
        where TEntity : class
    {
        /// <summary>Gets all records of the entity type.</summary>
        /// <returns>All records of the entity type.</returns>
        Task<IEnumerable<TEntity>> GetAll();

        /// <summary>Inserts the specified object.</summary>
        /// <param name="obj">The object.</param>
        Task Insert(TEntity obj);

        /// <summary>Updates the specified object.</summary>
        /// <param name="obj">The object.</param>
        void Update(TEntity obj);

        /// <summary>Deletes the specified object.</summary>
        /// <param name="obj">The object.</param>
        /// <returns>The object.</returns>
        TEntity Delete(TEntity obj);
    }
}
