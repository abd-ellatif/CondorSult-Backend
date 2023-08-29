namespace CondorSult_Backend.Models
{
    public class DTOs
    {
        public record ArticleDto
        {
            public string Nom { get; set; }
            public string Description { get; set; }
            public string Marque { get; set; }
            public bool Visible { get; set; }
            public int CategorieID { get; set; }

        }

        public record VarianteDto
        {
            public string Nom { get; set; }
            public string Couleur { get; set; }
            public string Reference { get; set; }
            public bool Visible { get; set; }
            public decimal Prix { get; set; }
        }

        public record CommentaireDto
        {
            public string Contenu { get; set; }
            public string UserID { get; set; }
            public int ArticleID { get; set; }
        }

        public record CategorieDto
        {
            public string Designation { get; set; }
            public string Description { get; set; }
            public bool Visible { get; set; }

        }

        public record ImageDto
        {
            public string Url { get; set; }
        }

        public record CompositeArticleDto
        {
            public ArticleDto Article { get; set; }
            public List<ImageDto> Images { get; set; }
            public List<VarianteDto> Variantes { get; set; }
        }

        public record UserRegisterDto
        {

            public string? UserName { get; init; }
            public string? Password { get; init; }
            public string? Email { get; init; }
            public string? PhoneNumber { get; init; }
            public string? Addresse { get; set; }
            public int AnneeNaissance { get; set; }

            public ICollection<string>? Roles { get; set; }
        }

        public record UserAuthDto
        {
            public string? UserName { get; set; }
            public string? Password { get; set; }
        }

        public record UserToSend
        {
            public string userId { get; set; }
            public string userName { get; set; }
            public string token { get; set; }
            public IList<string> roles { get; set; }
        }
    }
}
