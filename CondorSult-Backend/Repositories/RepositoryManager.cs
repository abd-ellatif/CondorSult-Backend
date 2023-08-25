using CondorSult_Backend.Data;
using CondorSult_Backend.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace CondorSult_Backend.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly CondorSultDbContext _context;
        private readonly Lazy<IUtilisateurRepository> _utilisateurRepository;
        private readonly Lazy<IArticleRepository> _articleRepository;
        private readonly Lazy<IVarianteRepository> _varianteRepository;
        private readonly Lazy<ICategorieRepository> _categorieRepository;
        private readonly Lazy<IImageRepository> _imageRepository;
        private readonly Lazy<ICommentaireRepository> _commentaireRepository;
        private readonly Lazy<IPointVenteRepository> _pointVenteRepository;
        private readonly Lazy<IAuthentication> _authentication;


        public RepositoryManager(CondorSultDbContext context, UserManager<Utilisateur> userManager,IConfiguration configuration)
        {
            _context = context;
            _utilisateurRepository = new Lazy<IUtilisateurRepository>(() => new
            UtilisateurRepository(context));

            _articleRepository = new Lazy<IArticleRepository>(() => new
            ArticleRepository(context));

            _varianteRepository = new Lazy<IVarianteRepository>(() => new
            VarianteRepository(context));

            _categorieRepository = new Lazy<ICategorieRepository>(() => new
            CategorieRepository(context));

            _imageRepository = new Lazy<IImageRepository>(() => new
            ImageRepository(context));

            _commentaireRepository = new Lazy<ICommentaireRepository>(() => new
            CommentaireRepository(context));

            _pointVenteRepository = new Lazy<IPointVenteRepository>(() => new
            PointVenteRepository(context));

            _authentication = new Lazy<IAuthentication>(() => new Authentication(userManager, configuration));
        }
        public IUtilisateurRepository Utilisateur => _utilisateurRepository.Value;
        public IArticleRepository Article => _articleRepository.Value;
        public IVarianteRepository Variante => _varianteRepository.Value;
        public ICategorieRepository Categorie => _categorieRepository.Value;
        public IImageRepository Image => _imageRepository.Value;
        public ICommentaireRepository Commentaire => _commentaireRepository.Value;
        public IPointVenteRepository PointVente => _pointVenteRepository.Value;
        public IAuthentication Authentication => _authentication.Value;

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
