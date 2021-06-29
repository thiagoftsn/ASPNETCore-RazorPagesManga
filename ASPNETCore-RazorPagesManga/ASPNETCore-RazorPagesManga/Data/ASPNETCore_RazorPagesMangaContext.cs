using Microsoft.EntityFrameworkCore;

namespace ASPNETCore_RazorPagesManga.Data
{
    public class ASPNETCore_RazorPagesMangaContext : DbContext
    {
        public ASPNETCore_RazorPagesMangaContext(DbContextOptions<ASPNETCore_RazorPagesMangaContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNETCore_RazorPagesManga.Models.Manga> Manga { get; set; }
    }
}
