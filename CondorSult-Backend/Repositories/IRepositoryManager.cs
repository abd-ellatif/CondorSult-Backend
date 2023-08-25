namespace CondorSult_Backend.Repositories
{
    public interface IRepositoryManager
    {

        IUtilisateurRepository Utilisateur { get; }
        IArticleRepository Article { get; }
        IVarianteRepository Variante { get; }
        ICategorieRepository Categorie { get; }
        IImageRepository Image { get; }
        ICommentaireRepository Commentaire { get; }


        void SaveChanges();
    }
}
