namespace CondorSult_Backend.Models
{
    public class DTOs
    {
        public class ArticleDto
        {
            public string Nom { get; set; }
            public string Description { get; set; }
            public string Marque { get; set; }
            public bool Visible { get; set; }
            public int CategorieID { get; set; }

        }

        public class VarianteDto
        {
            public string Nom { get; set; }
            public string Couleur { get; set; }
            public string Reference { get; set; }
            public bool Visible { get; set; }
            public decimal Prix { get; set; }
        }

        public class CommentaireDto
        {
            public string Contenu { get; set; }
            public int UserID { get; set; }
            public int ArticleID { get; set; }
        }

        public class CategorieDto
        {
            public string Designation { get; set; }
            public string Description { get; set; }
        }

        public class ImageDto
        {
            public string Url { get; set; }
        }

        public class CompositeArticleDto
        {
            public ArticleDto Article { get; set; }
            public List<ImageDto> Images { get; set; }
            public List<VarianteDto> Variantes { get; set; }
        }
    }
}
