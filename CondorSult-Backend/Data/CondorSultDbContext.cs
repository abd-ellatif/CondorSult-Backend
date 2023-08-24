using CondorSult_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CondorSult_Backend.Data
{
    public class CondorSultDbContext : DbContext
    {
        public CondorSultDbContext( DbContextOptions<CondorSultDbContext> options) : base(options)
        {
        }


        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Variante> Variantes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Commentaire> Commentaires { get; set; }
    }
}
