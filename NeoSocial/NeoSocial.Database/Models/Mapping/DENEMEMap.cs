using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NeoSocial.Database.Models.Mapping
{
    public class DENEMEMap : EntityTypeConfiguration<DENEME>
    {
        public DENEMEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("DENEME");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
