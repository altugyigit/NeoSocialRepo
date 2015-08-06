using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using NeoSocial.Database.Models.Mapping;

namespace NeoSocial.Database.Models
{
    public partial class DB_9D589F_neosocialContext : DbContext
    {
        static DB_9D589F_neosocialContext()
        {
            System.Data.Entity.Database.SetInitializer<DB_9D589F_neosocialContext>(null);
        }

        public DB_9D589F_neosocialContext()
            : base("Name=DB_9D589F_neosocialContext")
        {
        }

        public DbSet<ArticlePost> ArticlePosts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArticlePostMap());
        }
    }
}
