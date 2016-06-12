using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class TotalServicelengthConfig : EntityTypeConfiguration<TotalServicelength>
    {
        public TotalServicelengthConfig()
        {
            HasRequired(u => u.Creator)
                       .WithMany(t => t.TotalServicelengthCreatorId)
                       .HasForeignKey(p => p.CreatorId)
                       .WillCascadeOnDelete(false);

            HasOptional(u => u.Updator)
                        .WithMany(t => t.TotalServicelengthUpdatorId)
                        .HasForeignKey(p => p.UpdatorId)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Department)
                        .WithMany(t => t.TotalServicelengthId)
                        .HasForeignKey(p => p.DepartmentID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Servicelength)
                        .WithMany(t => t.TotalServicelengthId)
                        .HasForeignKey(p => p.ServicelengthID)
                        .WillCascadeOnDelete(false);
        }
    }
}
