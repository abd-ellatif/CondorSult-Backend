namespace CondorSult_Backend.Models
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public string Marque { get; set; }
        public bool Visible { get; set; }

        public int CategorieID { get; set; }
        public virtual Categorie Categorie { get; set; }
    }
}
