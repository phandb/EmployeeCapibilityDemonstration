using EmployeeCapibilityDemonstration.Data;
using EmployeeCapibilityDemonstration.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCapibilityDemonstration.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        // Inject the DbContext
        private readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        // Implementation of the interface
        public async Task<T> AddAsync(T entity)
        {

          
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

       

        public async Task DeleteAsync(string id)
        {
            var entity = await GetByIdAsync(id);
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<bool> Exists(string id)
        {
            var entity = await GetByIdAsync(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(string? id)
        {
            if (id == null)
            {
                return null;    
            }
            return await context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            //context.Entry(entity).State = EntityState.Modified;
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
