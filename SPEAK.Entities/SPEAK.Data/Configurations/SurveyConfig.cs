using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class SurveyConfig : EntityBaseConfiguration<Survey>
    {
        public SurveyConfig()
        {
            Property(p => p.Year).IsRequired();

            HasRequired(u => u.Creator)
                        .WithMany(t => t.SurveyCreatorId)
                        .HasForeignKey(p => p.CreatorId)
                        .WillCascadeOnDelete(false);

            HasOptional(u => u.Updator)
                        .WithMany(t => t.SurveyUpdatorId)
                        .HasForeignKey(p => p.UpdatorId)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Location)
                        .WithMany(t => t.SurveyId)
                        .HasForeignKey(p => p.LocationID)
                        .WillCascadeOnDelete(false);
        }
    }
}
