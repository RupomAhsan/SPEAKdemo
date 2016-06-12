using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class TotalJoblevelConfig : EntityTypeConfiguration<TotalJoblevel>
    {
        public TotalJoblevelConfig()
        {
            HasRequired(u => u.Creator)
                       .WithMany(t => t.TotalJoblevelCreatorId)
                       .HasForeignKey(p => p.CreatorId)
                       .WillCascadeOnDelete(false);

            HasOptional(u => u.Updator)
                        .WithMany(t => t.TotalJoblevelUpdatorId)
                        .HasForeignKey(p => p.UpdatorId)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Department)
                        .WithMany(t => t.TotalJoblevelId)
                        .HasForeignKey(p => p.DepartmentID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Joblevel)
                        .WithMany(t => t.TotalJoblevelId)
                        .HasForeignKey(p => p.JoblevelID)
                        .WillCascadeOnDelete(false);
        }
    }
}
