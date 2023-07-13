using System.ComponentModel.DataAnnotations;


namespace PanelAdmin.Models
{
    public class Ikonlar
    {
        [Key]
        public int Id { get; set; }
        public string Ikon { get; set; }
        public string Link { get; set; }
    }
}