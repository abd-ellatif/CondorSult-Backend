namespace CondorSult_Backend.Models
{
    public class PointVente
    {
        public int PointVenteId { get; set; }
        public string? Nom { get; set; }
        public string? Addresse { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
