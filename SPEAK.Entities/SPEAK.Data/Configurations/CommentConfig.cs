using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class CommentConfig: EntityTypeConfiguration<Comment>
    {
        public CommentConfig()
        {
            Property(p => p.Description).IsRequired().HasMaxLength(250);
            HasRequired(u => u.SectionAssign)
                        .WithMany(t => t.CommentSectionAssignId)
                        .HasForeignKey(p => p.SectionAssignID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Employee)
                        .WithMany(t => t.CommentEmployeeId)
                        .HasForeignKey(p => p.EmployeeID)
                        .WillCascadeOnDelete(false);
        }
    }
}
