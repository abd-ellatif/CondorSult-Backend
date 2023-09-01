using Microsoft.AspNetCore.Identity;


namespace CondorSult_Backend.Models
{
    public class Utilisateur : IdentityUser
    {
        public string? Addresse { get; set; }
        public int AnneeNaissance { get; set; }


        public ICollection<Commentaire>? Commentaires { get; set;}
        
    }
}
