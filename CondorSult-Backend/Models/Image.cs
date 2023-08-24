namespace CondorSult_Backend.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string Url { get; set; }



        public int AricleID { get; set; }
        public Article Article { get; set; }
    }
}
