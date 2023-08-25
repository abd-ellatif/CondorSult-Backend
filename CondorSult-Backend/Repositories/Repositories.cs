using CondorSult_Backend.Data;
using CondorSult_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace CondorSult_Backend.Repositories
{
    public class UtilisateurRepository : RepositoryBase<Utilisateur>, IUtilisateurRepository
    {
        public  UtilisateurRepository(CondorSultDbContext Context): base(Context)
        { }
    }

    public class ArticleRepository : RepositoryBase<Article>, IArticleRepository
    {
        public ArticleRepository(CondorSultDbContext Context) : base(Context)
        { }
        public IQueryable<Article> GetAllArticles()
        {
            return GetAll().Include(a => a.Variantes).Include(a => a.Images)
                .Include(a => a.Commentaires);
        }

        public void AddArticle(Article article)
        {
            Add(article);
        }
    }
 

    public class VarianteRepository : RepositoryBase<Variante>, IVarianteRepository
    {
        public VarianteRepository(CondorSultDbContext Context) : base(Context)
        { }

        public void AddVariantesRange(IEnumerable<Variante> variantes)
        {
            AddRange(variantes);
        }
    }

    public class CategorieRepository : RepositoryBase<Categorie>, ICategorieRepository
    {
        public CategorieRepository(CondorSultDbContext Context) : base(Context)
        { }
        public IEnumerable<Categorie> GetAllCategories()
        {
            return GetAll().ToList();
        }
    }

    public class ImageRepository : RepositoryBase<Image>, IImageRepository
    {
        public ImageRepository(CondorSultDbContext Context) : base(Context)
        { }
        public void AddImagesRange(IEnumerable<Image> images)
        {
            AddRange(images);
        }
    }

    public class CommentaireRepository : RepositoryBase<Commentaire>, ICommentaireRepository
    {
        public CommentaireRepository(CondorSultDbContext Context) : base(Context)
        { }
        public void AddCommentaire(Commentaire commentaire)
        {
            Add(commentaire);
        }
    }

    public class PointVenteRepository : RepositoryBase<PointVente>, IPointVenteRepository
    {
        public PointVenteRepository(CondorSultDbContext Context) : base(Context)
        { }

        public IEnumerable<PointVente> GetAllPointsVente()
        {
           return GetAll().ToList();
        }
    }
}
