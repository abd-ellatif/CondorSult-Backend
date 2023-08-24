namespace CondorSult_Backend.Models
{
    public class Commentaire
    {
        public int CommentaireID { get; set; }
        public string Contenu { get; set; }
     
        

        public int UserID { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }

        public int ArticleID { get; set; }
        public virtual Article Article { get; set; }
    }
}
