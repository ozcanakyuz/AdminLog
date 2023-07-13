using System.ComponentModel.DataAnnotations;

namespace PanelAdmin.Models
{
    public class AnaSayfa
    {
        [Key]
        public int Id { get; set; }
        public string Profil { get; set; }
        public string Isim { get; set; }
        public string Unvan { get; set; }
        public string Aciklama { get; set; }
        public string SocialMedia { get; set; }
    }
}