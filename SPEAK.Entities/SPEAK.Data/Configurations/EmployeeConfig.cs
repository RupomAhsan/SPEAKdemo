using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class EmployeeConfig : EntityBaseConfiguration<Employee>
    {
        public EmployeeConfig()
        {
            Property(p => p.Username).IsRequired().HasMaxLength(50);
            Property(p => p.Password).IsRequired().HasMaxLength(50);

            HasRequired(u => u.Creator)
                        .WithMany(t => t.EmployeeCreatorId)
                        .HasForeignKey(p => p.CreatorId)
                        .WillCascadeOnDelete(false);

            HasOptional(u => u.Updator)
                        .WithMany(t => t.EmployeeUpdatorId)
                        .HasForeignKey(p => p.UpdatorId)
                        .WillCascadeOnDelete(false);

            HasOptional(u => u.CurrentSection)
                        .WithMany(t => t.EmployeeCurrentSectionId)
                        .HasForeignKey(p => p.CurrentSectionID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Location)
                        .WithMany(t => t.EmployeeLocationId)
                        .HasForeignKey(p => p.LocationID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Gender)
                        .WithMany(t => t.EmployeeGenderId)
                        .HasForeignKey(p => p.GenderID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Nationality)
                        .WithMany(t => t.EmployeeNationalityId)
                        .HasForeignKey(p => p.NationalityID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Joblevel)
                        .WithMany(t => t.EmployeeJoblevelId)
                        .HasForeignKey(p => p.JoblevelID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Servicelength)
                        .WithMany(t => t.EmployeeServicelengthId)
                        .HasForeignKey(p => p.ServicelengthID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Department)
                        .WithMany(t => t.EmployeeDepartmentId)
                        .HasForeignKey(p => p.DepartmentID)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Survey)
                        .WithMany(t => t.EmployeeSurveyId)
                        .HasForeignKey(p => p.SurveyID)
                        .WillCascadeOnDelete(false);
        }
    }
}
