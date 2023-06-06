using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebshopApp.Models;

namespace WebshopApp.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly ApplicationContext applicationContext;

        public EntityBaseRepository(ApplicationContext applicationContext)
        {
            this.applicationContext=applicationContext;
        }

        public async Task AddAsync(T entity)
        {
            await this.applicationContext.Set<T>().AddAsync(entity);
            await this.applicationContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
           var entity = await this.applicationContext.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entityEntry = this.applicationContext.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
            await this.applicationContext.SaveChangesAsync();

        }

        public async Task<IEnumerable<T>> GetAllAsync() => await this.applicationContext.Set<T>().ToListAsync();
        

        public async Task<T> GetByIdAsync(int id) => await this.applicationContext.Set<T>().FirstOrDefaultAsync(n => n.Id == id);

        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = this.applicationContext.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
            await this.applicationContext.SaveChangesAsync();

        }
    }
}
