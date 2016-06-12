using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class GenderConfig : EntityBaseConfiguration<Gender>
    {
        public GenderConfig()
        {
            Property(p => p.Name).IsRequired().HasMaxLength(50);

            HasRequired(u => u.Creator)
                        .WithMany(t => t.GenderCreatorId)
                        .HasForeignKey(p => p.CreatorId)
                        .WillCascadeOnDelete(false);

            HasOptional(u => u.Updator)
                        .WithMany(t => t.GenderUpdatorId)
                        .HasForeignKey(p => p.UpdatorId)
                        .WillCascadeOnDelete(false);
        }
    }
}
