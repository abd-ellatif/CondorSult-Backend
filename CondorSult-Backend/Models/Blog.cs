namespace CondorSult_Backend.Models
{
    public class Blog
    {
        public int BlogId { get; set; } 
        public string Titre { get; set; }
        public string Contenu { get; set; }
        public string Auteur { get; set; }
        public string DatePublication { get; set; }
        public string ImageUrl { get; set; }
    }
}
