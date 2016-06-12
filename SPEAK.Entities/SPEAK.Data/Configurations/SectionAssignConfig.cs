using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class SectionAssignConfig : EntityBaseConfiguration<SectionAssign>
    {
        public SectionAssignConfig()
        {
            HasRequired(u => u.Creator)
                        .WithMany(t => t.SectionAssignCreatorId)
                        .HasForeignKey(p => p.CreatorId)
                        .WillCascadeOnDelete(false);

            HasOptional(u => u.Updator)
                        .WithMany(t => t.SectionAssignUpdatorId)
                        .HasForeignKey(p => p.UpdatorId)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Department)
                        .WithMany(t => t.SectionAssignId)
                        .HasForeignKey(p => p.DepartmentID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Location)
                        .WithMany(t => t.SectionAssignId)
                        .HasForeignKey(p => p.LocationID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Section)
                        .WithMany(t => t.SectionAssignId)
                        .HasForeignKey(p => p.SectionID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Survey)
                        .WithMany(t => t.SectionAssignId)
                        .HasForeignKey(p => p.SurveyID)
                        .WillCascadeOnDelete(false);
        }
    }
}
