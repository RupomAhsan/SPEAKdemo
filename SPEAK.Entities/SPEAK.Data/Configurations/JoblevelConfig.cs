using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class JoblevelConfig : EntityBaseConfiguration<Joblevel>
    {
        public JoblevelConfig()
        {
            Property(p => p.Name).IsRequired().HasMaxLength(50);

            HasRequired(u => u.Creator)
                        .WithMany(t => t.JoblevelCreatorId)
                        .HasForeignKey(p => p.CreatorId)
                        .WillCascadeOnDelete(false);

            HasOptional(u => u.Updator)
                        .WithMany(t => t.JoblevelUpdatorId)
                        .HasForeignKey(p => p.UpdatorId)
                        .WillCascadeOnDelete(false);
        }
    }
}
