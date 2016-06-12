using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class TotalGenderConfig : EntityTypeConfiguration<TotalGender>
    {
        public TotalGenderConfig()
        {
            HasRequired(u => u.Creator)
                       .WithMany(t => t.TotalGenderCreatorId)
                       .HasForeignKey(p => p.CreatorId)
                       .WillCascadeOnDelete(false);

            HasOptional(u => u.Updator)
                        .WithMany(t => t.TotalGenderUpdatorId)
                        .HasForeignKey(p => p.UpdatorId)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Department)
                        .WithMany(t => t.TotalGenderId)
                        .HasForeignKey(p => p.DepartmentID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Gender)
                        .WithMany(t => t.TotalGenderId)
                        .HasForeignKey(p => p.GenderID)
                        .WillCascadeOnDelete(false);
        }
    }
}
