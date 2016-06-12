using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class DepartmentConfig : EntityBaseConfiguration<Department>
    {
        public DepartmentConfig()
        {
            Property(p => p.Name).IsRequired().HasMaxLength(50);
            Property(p => p.Code).HasMaxLength(3);

            HasRequired(u => u.Creator)
                        .WithMany(t => t.DepartmentCreatorId)
                        .HasForeignKey(p => p.CreatorId)
                        .WillCascadeOnDelete(false);

            HasOptional(u => u.Updator)
                        .WithMany(t => t.DepartmentUpdatorId)
                        .HasForeignKey(p => p.UpdatorId)
                        .WillCascadeOnDelete(false);

            HasOptional(u => u.Owner)
                        .WithMany(t => t.DepartmentOwnerId)
                        .HasForeignKey(p => p.OwnerID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Location)
                        .WithMany(t => t.DepartmentLocationId)
                        .HasForeignKey(p => p.LocationID)
                        .WillCascadeOnDelete(false);

            HasOptional(u => u.Parent)
                        .WithMany(t => t.DepartmentParentId)
                        .HasForeignKey(p => p.ParentID)
                        .WillCascadeOnDelete(false);
        }
    }
}
