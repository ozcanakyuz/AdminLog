
using System.Data.Entity;

namespace PanelAdmin.Models
{
    public class MyDbContext : DbContext
    {

        public DbSet<Admin> Admins { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<Ikonlar> Ikonlars { get; set; }
    }
}