using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NeoSocial.Database.Models.Mapping
{
    class ArticlePostMap : EntityTypeConfiguration<ArticlePost>
    {
        public ArticlePostMap()
        {
            //primary key
            this.HasKey(x => new { x.PostID,x.PostOwnerID,x.PostCommentID });

            //property
            this.Property(x => x.PostID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(x=> x.PostOwnerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.PostCommentID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.PostHeader)
                .IsOptional()
                .HasMaxLength(200);

            this.Property(x => x.PostContent)
                .IsRequired()
                .HasMaxLength(2000);

            this.Property(x => x.PostDate)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(x => x.PostLikeCount)
                .IsOptional();
                
            //table&column

            this.ToTable("Article_Post");
            this.Property(x => x.PostID).HasColumnName("PostID");
              this.Property(x => x.PostHeader).HasColumnName("PostHeader");
            this.Property(x => x.PostContent).HasColumnName("PostContent");
            this.Property(x => x.PostDate).HasColumnName("PostDate");
            this.Property(x => x.PostLikeCount).HasColumnName("PostLikeCount");
            this.Property(x => x.PostCommentID).HasColumnName("PostCommentID");
            this.Property(x => x.PostOwnerID).HasColumnName("PostOwnerID");
          


        }
    }
}
