using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NeoSocial.Database.Models.Mapping
{
    public class IconMap : EntityTypeConfiguration<Icon>
    {
        public IconMap()
        {
            // Primary Key
            this.HasKey(t => t.IconID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Icon");
            this.Property(t => t.IconID).HasColumnName("IconID");
            this.Property(t => t.Icon1).HasColumnName("Icon");
        }
    }
}
