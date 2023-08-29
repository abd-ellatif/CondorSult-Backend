using CondorSult_Backend.Models;
using CondorSult_Backend.Repositories.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CondorSult_Backend.Data
{
    public class CondorSultDbContext : IdentityDbContext<Utilisateur>
    {
        public CondorSultDbContext( DbContextOptions<CondorSultDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }

        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Variante> Variantes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Commentaire> Commentaires { get; set; }
        public DbSet<PointVente> PointsVente { get; set; }
        public DbSet<Blog> Blog { get; set; }
    }
}
