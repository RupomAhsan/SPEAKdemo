using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class TotalNationalityConfig : EntityTypeConfiguration<TotalNationality>
    {
        public TotalNationalityConfig()
        {
            HasRequired(u => u.Creator)
                       .WithMany(t => t.TotalNationalityCreatorId)
                       .HasForeignKey(p => p.CreatorId)
                       .WillCascadeOnDelete(false);

            HasOptional(u => u.Updator)
                        .WithMany(t => t.TotalNationalityUpdatorId)
                        .HasForeignKey(p => p.UpdatorId)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Department)
                        .WithMany(t => t.TotalNationalityId)
                        .HasForeignKey(p => p.DepartmentID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Nationality)
                        .WithMany(t => t.TotalNationalityId)
                        .HasForeignKey(p => p.NationalityID)
                        .WillCascadeOnDelete(false);
        }
    }
}
