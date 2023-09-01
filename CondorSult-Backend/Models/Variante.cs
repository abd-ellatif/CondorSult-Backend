namespace CondorSult_Backend.Models
{
    public class Variante
    {
        public int VarianteID { get; set; }
        public string Nom { get; set; }
        public string Couleur { get; set;}
        public string Reference { get; set;}
        public bool Visible { get; set; }
        public decimal Prix { get; set; }



        public int ArticleID { get; set; }
        public Article Article { get; set; }

    }
}
