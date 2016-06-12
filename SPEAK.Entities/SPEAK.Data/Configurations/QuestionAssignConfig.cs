using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class QuestionAssignConfig : EntityBaseConfiguration<QuestionAssign>
    {
        public QuestionAssignConfig()
        {
            HasRequired(u => u.Creator)
                        .WithMany(t => t.QuestionAssignCreatorId)
                        .HasForeignKey(p => p.CreatorId)
                        .WillCascadeOnDelete(false);

            HasOptional(u => u.Updator)
                        .WithMany(t => t.QuestionAssignUpdatorId)
                        .HasForeignKey(p => p.UpdatorId)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Department)
                        .WithMany(t => t.QuestionAssignId)
                        .HasForeignKey(p => p.DepartmentID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Location)
                        .WithMany(t => t.QuestionAssignId)
                        .HasForeignKey(p => p.LocationID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Question)
                        .WithMany(t => t.QuestionAssignId)
                        .HasForeignKey(p => p.QuestionID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.SectionAssign)
                        .WithMany(t => t.QuestionAssignId)
                        .HasForeignKey(p => p.SectionAssignID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Survey)
                        .WithMany(t => t.QuestionAssignId)
                        .HasForeignKey(p => p.SurveyID)
                        .WillCascadeOnDelete(false);
        }
    }
}
