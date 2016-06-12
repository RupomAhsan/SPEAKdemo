using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class QuestionOtherConfig : EntityBaseConfiguration<QuestionOther>
    {
        public QuestionOtherConfig()
        {
            HasRequired(u => u.Creator)
                        .WithMany(t => t.QuestionOtherCreatorId)
                        .HasForeignKey(p => p.CreatorId)
                        .WillCascadeOnDelete(false);

            HasOptional(u => u.Updator)
                        .WithMany(t => t.QuestionOtherUpdatorId)
                        .HasForeignKey(p => p.UpdatorId)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Language)
                        .WithMany(t => t.QuestionLanguageId)
                        .HasForeignKey(p => p.LanguageID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Question)
                        .WithMany(t => t.QuestionOtherId)
                        .HasForeignKey(p => p.QuestionID)
                        .WillCascadeOnDelete(false);
        }
    }
}
