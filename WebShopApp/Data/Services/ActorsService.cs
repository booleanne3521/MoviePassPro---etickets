using Microsoft.EntityFrameworkCore;
using WebshopApp.Data.Base;
using WebshopApp.Models;

namespace WebshopApp.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>,  IActorsService
    {
       public ActorsService(ApplicationContext applicationContext) : base (applicationContext) { }
    }
}
