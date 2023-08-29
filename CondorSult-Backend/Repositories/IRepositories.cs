using CondorSult_Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace CondorSult_Backend.Repositories
{
    public interface IUtilisateurRepository
    {
        public Utilisateur getUserById(string id);
    }

    public interface IArticleRepository
    {
        public IQueryable<Article> GetAllArticles();
        public void AddArticle(Article article);
    }

    public interface IVarianteRepository
    {
        public void AddVariantesRange(IEnumerable<Variante> variantes);

    }

    public interface ICategorieRepository
    {
        public IEnumerable<Categorie> GetAllCategories();
        public void AddCategory(Categorie categorie);
    }

    public interface IImageRepository
    {
        public void AddImagesRange(IEnumerable<Image> images);
    }

    public interface ICommentaireRepository
    {
        public void AddCommentaire(Commentaire commentaire);
    } 
    public interface IPointVenteRepository
    {
        public IEnumerable<PointVente> GetAllPointsVente();
    }
    public interface IBlogRepository
    {
        public void AddBlog(Blog blog);
        public void RemoveBlog(int id);
        public IEnumerable<Blog> GetAllBlogs();
    }
}
