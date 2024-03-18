using Microsoft.EntityFrameworkCore;
using WebAMVC.Models;

namespace Web_Crud_SqlServer.Models
{

    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Produto>Produto {get; set;}
    }
}
