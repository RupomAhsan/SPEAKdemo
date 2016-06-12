using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class SectionConfig : EntityBaseConfiguration<Section>
    {
        public SectionConfig()
        {
            Property(p => p.Name).IsRequired().HasMaxLength(100);

            HasRequired(u => u.Creator)
                        .WithMany(t => t.SectionCreatorId)
                        .HasForeignKey(p => p.CreatorId)
                        .WillCascadeOnDelete(false);

            HasOptional(u => u.Updator)
                        .WithMany(t => t.SectionUpdatorId)
                        .HasForeignKey(p => p.UpdatorId)
                        .WillCascadeOnDelete(false);
        }
    }
}
