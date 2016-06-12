using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class UserRoleConfig : EntityTypeConfiguration<UserRole>
    {
        public UserRoleConfig()
        {
            Property(ur => ur.UserID).IsRequired();
            Property(ur => ur.RoleID).IsRequired();

            HasRequired(u => u.Creator)
                        .WithMany(t => t.UserRoleCreatorId)
                        .HasForeignKey(p => p.CreatorId)
                        .WillCascadeOnDelete(false);

            HasOptional(u => u.Updator)
                        .WithMany(t => t.UserRoleUpdatorId)
                        .HasForeignKey(p => p.UpdatorId)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Role)
                        .WithMany(t => t.UserRoleId)
                        .HasForeignKey(p => p.RoleID)
                        .WillCascadeOnDelete(false);
            HasRequired(u => u.User)
                        .WithMany(t => t.UserRoleId)
                        .HasForeignKey(p => p.UserID)
                        .WillCascadeOnDelete(false);


        }
    }
}
