using Microsoft.EntityFrameworkCore;
using QuickBase.Business.Interfaces.SqliteData;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuickBase.SqliteData.Repositories
{
    /// <summary>The generic repository implementation.</summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public class GenericRepo<TEntity> : IGenericRepo<TEntity>
        where TEntity : class
    {
        protected readonly SqliteContext _context;

        /// <summary>Initializes a new instance of the <see cref="GenericRepo{TEntity}" /> class.</summary>
        /// <param name="context">The context.</param>
        public GenericRepo(SqliteContext context)
        {
            _context = context;
        }

        /// <summary>Gets all records of the entity type.</summary>
        /// <returns>All records of the entity type.</returns>
        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        /// <summary>Inserts the specified object.</summary>
        /// <param name="obj">The object.</param>
        public async Task Insert(TEntity obj)
        {
            await _context.Set<TEntity>().AddAsync(obj);
        }

        /// <summary>Updates the specified object.</summary>
        /// <param name="obj">The object.</param>
        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
        }

        /// <summary>Deletes the specified object.</summary>
        /// <param name="obj">The object.</param>
        /// <returns>The object.</returns>
        public TEntity Delete(TEntity obj)
        {
            return _context.Set<TEntity>().Remove(obj).Entity;
        }
    }
}
