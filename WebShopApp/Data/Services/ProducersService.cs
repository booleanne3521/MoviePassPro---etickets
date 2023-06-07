using Microsoft.EntityFrameworkCore;
using WebshopApp.Data.Base;
using WebshopApp.Models;

namespace WebshopApp.Data.Services
{
    public class ProducersService : EntityBaseRepository<Actor>
    {
       public ProducersService(ApplicationContext applicationContext) : base (applicationContext) { }
    }
}
