using CondorSult_Backend.Data;
using CondorSult_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace CondorSult_Backend.Repositories
{
    public class UtilisateurRepository : RepositoryBase<Utilisateur>, IUtilisateurRepository

    {
        private readonly DbContext _dbContext;
        private readonly DbSet<Utilisateur> _dbSet;
        public  UtilisateurRepository(CondorSultDbContext Context): base(Context)
        {
            _dbContext = Context ?? throw new ArgumentNullException(nameof(Context));
            _dbSet = _dbContext.Set<Utilisateur>();
        }

        public Utilisateur getUserById(string id)
        {
            return _dbSet.Find(id);
        }
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

        public void AddCategory(Categorie categorie)
        {
            Add(categorie);
        }

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

    public class BlogRepository : RepositoryBase<Blog>, IBlogRepository
    {
        public BlogRepository(CondorSultDbContext Context) : base(Context)
        { }

        public void AddBlog(Blog blog)
        {
            Add(blog);
        } 

        public IEnumerable<Blog> GetAllBlogs()
        {
            return GetAll().ToList();
        }

        public void RemoveBlog(int id)
        {
            var blog = GetById(id);
            if (blog != null)
            {
                Delete(blog);
            } 
        }
    }

}
