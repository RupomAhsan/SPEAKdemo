using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class QuestionConfig : EntityBaseConfiguration<Question>
    {
        public QuestionConfig()
        {
            Property(p => p.Name).IsRequired().HasMaxLength(250);

            HasRequired(u => u.Creator)
                        .WithMany(t => t.QuestionCreatorId)
                        .HasForeignKey(p => p.CreatorId)
                        .WillCascadeOnDelete(false);

            HasOptional(u => u.Updator)
                        .WithMany(t => t.QuestionUpdatorId)
                        .HasForeignKey(p => p.UpdatorId)
                        .WillCascadeOnDelete(false);
        }
    }
}
