using Microsoft.EntityFrameworkCore;
using PrimeiraWebApi.Domain.Entities;

namespace PrimeiraWebApi.Infra.Data
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos {get; set;}

         
        
    }
}