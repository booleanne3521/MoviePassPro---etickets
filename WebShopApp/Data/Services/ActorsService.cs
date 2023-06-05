using Microsoft.EntityFrameworkCore;
using WebshopApp.Models;

namespace WebshopApp.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly ApplicationContext applicationContext;

        public ActorsService(ApplicationContext applicationContext)
        {
            this.applicationContext=applicationContext;
        }

        public async Task AddAsync(Actor actor)
        {
           await this.applicationContext.Actors.AddAsync(actor);
           await this.applicationContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await this.applicationContext.Actors.FirstOrDefaultAsync(n => n.Id == id);
            this.applicationContext.Actors.Remove(result);
            await this.applicationContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await this.applicationContext.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await this.applicationContext.Actors.FirstOrDefaultAsync(n=> n.Id == id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            this.applicationContext.Update(newActor);
            await this.applicationContext.SaveChangesAsync();
            return newActor;
        }
    }
}
