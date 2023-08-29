namespace CondorSult_Backend.Models
{
    public class Commentaire
    {
        public int CommentaireID { get; set; }
        public string Contenu { get; set; }



        public string UserID { get; set; }
        public Utilisateur User { get; set; }

        public int ArticleID { get; set; }
        public virtual Article Article { get; set; }
    }
}
