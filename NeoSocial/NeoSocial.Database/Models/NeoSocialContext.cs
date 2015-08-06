using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using NeoSocial.Database.Models.Mapping;

namespace NeoSocial.Database.Models
{
    public partial class NeoSocialContext : DbContext
    {
        static NeoSocialContext()
        {
            System.Data.Entity.Database.SetInitializer<NeoSocialContext>(null);
        }

        public NeoSocialContext()
            : base("Name=NeoSocialContext")
        {
        }

        public DbSet<ArticlePost> ArticlePosts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArticlePostMap());
        }
    }
}
