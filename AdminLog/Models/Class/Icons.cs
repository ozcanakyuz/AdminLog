using System.ComponentModel.DataAnnotations;


namespace AdminLog.Models.Class
{
    public class Icons
    {
        [Key]
        public int Id { get; set; }
        public string Ikon { get; set; }
        public string Link { get; set; }
    }
}