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

        public void Add(Actor actor)
        {
            this.applicationContext.Actors.Add(actor);
            this.applicationContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await this.applicationContext.Actors.ToListAsync();
            return result;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
