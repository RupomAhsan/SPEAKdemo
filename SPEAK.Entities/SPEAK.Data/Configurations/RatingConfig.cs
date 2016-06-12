using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class RatingConfig : EntityTypeConfiguration<Rating>
    {
        public RatingConfig()
        {
            HasRequired(u => u.QuestionAssign)
                        .WithMany(t => t.QuestionRatingId)
                        .HasForeignKey(p => p.QuestionAssignID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Employee)
                        .WithMany(t => t.QuestionRatingId)
                        .HasForeignKey(p => p.EmployeeID)
                        .WillCascadeOnDelete(false);
        }
    }
}
