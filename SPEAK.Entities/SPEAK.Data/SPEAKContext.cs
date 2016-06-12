using SPEAK.Data.Configurations;
using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data
{
    public class SPEAKContext : DbContext
    {
        public SPEAKContext()
            : base("SPEAKdemo")
        {
            Database.SetInitializer<SPEAKContext>(null);
        }

        #region Entity Sets
        public IDbSet<User> UserSet { get; set; }
        public IDbSet<Role> RoleSet { get; set; }
        public IDbSet<UserRole> UserRoleSet { get; set; }
        public IDbSet<Comment> CommentSet { get; set; }
        public IDbSet<Country> CountrySet { get; set; }
        public IDbSet<Department> DepartmentSet { get; set; }
        public IDbSet<Employee> EmployeeSet { get; set; }
        public IDbSet<Error> ErrorSet { get; set; }
        public IDbSet<Gender> GenderSet { get; set; }
        public IDbSet<Joblevel> JoblevelSet { get; set; }
        public IDbSet<Language> LanguageSet { get; set; }
        public IDbSet<Location> LocationSet { get; set; }
        public IDbSet<Nationality> NationalitySet { get; set; }
        public IDbSet<Question> QuestionSet { get; set; }
        public IDbSet<QuestionAssign> QuestionAssignSet { get; set; }
        public IDbSet<QuestionOther> QuestionOtherSet { get; set; }
        public IDbSet<Rating> RatingSet { get; set; }
        public IDbSet<Section> SectionSet { get; set; }
        public IDbSet<SectionAssign> SectionAssignSet { get; set; }
        public IDbSet<Servicelength> ServicelengthSet { get; set; }
        public IDbSet<Survey> SurveySet { get; set; }
        public IDbSet<TotalGender> TotalGenderSet { get; set; }
        public IDbSet<TotalJoblevel> TotalJoblevelSet { get; set; }
        public IDbSet<TotalNationality> TotalNationalitySet { get; set; }
        public IDbSet<TotalServicelength> TotalServicelengthSet { get; set; }

        
        #endregion

        public virtual void Commit()
        {
            base.SaveChanges();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new UserRoleConfig());
            modelBuilder.Configurations.Add(new RoleConfig());
            modelBuilder.Configurations.Add(new CommentConfig());
            modelBuilder.Configurations.Add(new CountryConfig());
            modelBuilder.Configurations.Add(new DepartmentConfig());
            modelBuilder.Configurations.Add(new EmployeeConfig());
            modelBuilder.Configurations.Add(new GenderConfig());
            modelBuilder.Configurations.Add(new JoblevelConfig());
            modelBuilder.Configurations.Add(new LanguageConfig());
            modelBuilder.Configurations.Add(new LocationConfig());
            modelBuilder.Configurations.Add(new NationalityConfig());
            modelBuilder.Configurations.Add(new QuestionConfig());
            modelBuilder.Configurations.Add(new QuestionAssignConfig());
            modelBuilder.Configurations.Add(new QuestionOtherConfig());
            modelBuilder.Configurations.Add(new RatingConfig());
            modelBuilder.Configurations.Add(new SectionConfig());
            modelBuilder.Configurations.Add(new SectionAssignConfig());
            modelBuilder.Configurations.Add(new ServicelengthConfig());
            modelBuilder.Configurations.Add(new SurveyConfig());
            modelBuilder.Configurations.Add(new TotalGenderConfig());
            modelBuilder.Configurations.Add(new TotalJoblevelConfig());
            modelBuilder.Configurations.Add(new TotalNationalityConfig());
            modelBuilder.Configurations.Add(new TotalServicelengthConfig());



        }
    }
}
