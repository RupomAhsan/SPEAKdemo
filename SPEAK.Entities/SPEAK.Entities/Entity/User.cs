using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Entities.Entity
{
    public class User 
    {
        public User()
        {
            CountryCreatorId = new List<Country>();
            CountryUpdatorId = new List<Country>();

            DepartmentCreatorId = new List<Department>();
            DepartmentUpdatorId = new List<Department>();
            DepartmentOwnerId = new List<Department>();

            EmployeeCreatorId = new List<Employee>();
            EmployeeUpdatorId = new List<Employee>();

            GenderCreatorId = new List<Gender>();
            GenderUpdatorId = new List<Gender>();

            JoblevelCreatorId = new List<Joblevel>();
            JoblevelUpdatorId = new List<Joblevel>();

            LanguageCreatorId = new List<Language>();
            LanguageUpdatorId = new List<Language>();

            LocationCreatorId = new List<Location>();
            LocationUpdatorId = new List<Location>();

            NationalityCreatorId = new List<Nationality>();
            NationalityUpdatorId = new List<Nationality>();

            QuestionCreatorId = new List<Question>();
            QuestionUpdatorId = new List<Question>();

            QuestionAssignCreatorId = new List<QuestionAssign>();
            QuestionAssignUpdatorId = new List<QuestionAssign>();

            QuestionOtherCreatorId = new List<QuestionOther>();
            QuestionOtherUpdatorId = new List<QuestionOther>();

            RoleCreatorId = new List<Role>();
            RoleUpdatorId = new List<Role>();

            SectionCreatorId = new List<Section>();
            SectionUpdatorId = new List<Section>();

            SectionAssignCreatorId = new List<SectionAssign>();
            SectionAssignUpdatorId = new List<SectionAssign>();

            ServicelengthCreatorId = new List<Servicelength>();
            ServicelengthUpdatorId = new List<Servicelength>();

            SurveyCreatorId = new List<Survey>();
            SurveyUpdatorId = new List<Survey>();

            TotalGenderCreatorId = new List<TotalGender>();
            TotalGenderUpdatorId = new List<TotalGender>();

            TotalJoblevelCreatorId = new List<TotalJoblevel>();
            TotalJoblevelUpdatorId = new List<TotalJoblevel>();

            TotalNationalityCreatorId = new List<TotalNationality>();
            TotalNationalityUpdatorId = new List<TotalNationality>();

            TotalServicelengthCreatorId = new List<TotalServicelength>();
            TotalServicelengthUpdatorId = new List<TotalServicelength>();

            UserRoleCreatorId = new List<UserRole>();
            UserRoleUpdatorId = new List<UserRole>();

            UserRoleId = new List<UserRole>();
        }
        #region Implement IEntityBase Interface
        public int ID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatorId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatorId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        public string Username { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public bool IsLocked { get; set; }

        public virtual ICollection<Country> CountryCreatorId { get; set; }
        public virtual ICollection<Country> CountryUpdatorId { get; set; }

        public virtual ICollection<Department> DepartmentCreatorId { get; set; }
        public virtual ICollection<Department> DepartmentUpdatorId { get; set; }
        public virtual ICollection<Department> DepartmentOwnerId { get; set; }

        public virtual ICollection<Employee> EmployeeCreatorId { get; set; }
        public virtual ICollection<Employee> EmployeeUpdatorId { get; set; }

        public virtual ICollection<Gender> GenderCreatorId { get; set; }
        public virtual ICollection<Gender> GenderUpdatorId { get; set; }

        public virtual ICollection<Joblevel> JoblevelCreatorId { get; set; }
        public virtual ICollection<Joblevel> JoblevelUpdatorId { get; set; }

        public virtual ICollection<Language> LanguageCreatorId { get; set; }
        public virtual ICollection<Language> LanguageUpdatorId { get; set; }

        public virtual ICollection<Location> LocationCreatorId { get; set; }
        public virtual ICollection<Location> LocationUpdatorId { get; set; }

        public virtual ICollection<Nationality> NationalityCreatorId { get; set; }
        public virtual ICollection<Nationality> NationalityUpdatorId { get; set; }

        public virtual ICollection<Question> QuestionCreatorId { get; set; }
        public virtual ICollection<Question> QuestionUpdatorId { get; set; }

        public virtual ICollection<QuestionAssign> QuestionAssignCreatorId { get; set; }
        public virtual ICollection<QuestionAssign> QuestionAssignUpdatorId { get; set; }

        public virtual ICollection<QuestionOther> QuestionOtherCreatorId { get; set; }
        public virtual ICollection<QuestionOther> QuestionOtherUpdatorId { get; set; }

        public virtual ICollection<Role> RoleCreatorId { get; set; }
        public virtual ICollection<Role> RoleUpdatorId { get; set; }

        public virtual ICollection<Section> SectionCreatorId { get; set; }
        public virtual ICollection<Section> SectionUpdatorId { get; set; }

        public virtual ICollection<SectionAssign> SectionAssignCreatorId { get; set; }
        public virtual ICollection<SectionAssign> SectionAssignUpdatorId { get; set; }

        public virtual ICollection<Servicelength> ServicelengthCreatorId { get; set; }
        public virtual ICollection<Servicelength> ServicelengthUpdatorId { get; set; }

        public virtual ICollection<Survey> SurveyCreatorId { get; set; }
        public virtual ICollection<Survey> SurveyUpdatorId { get; set; }

        public virtual ICollection<TotalGender> TotalGenderCreatorId { get; set; }
        public virtual ICollection<TotalGender> TotalGenderUpdatorId { get; set; }

        public virtual ICollection<TotalJoblevel> TotalJoblevelCreatorId { get; set; }
        public virtual ICollection<TotalJoblevel> TotalJoblevelUpdatorId { get; set; }

        public virtual ICollection<TotalNationality> TotalNationalityCreatorId { get; set; }
        public virtual ICollection<TotalNationality> TotalNationalityUpdatorId { get; set; }

        public virtual ICollection<TotalServicelength> TotalServicelengthCreatorId { get; set; }
        public virtual ICollection<TotalServicelength> TotalServicelengthUpdatorId { get; set; }

        public virtual ICollection<UserRole> UserRoleUpdatorId { get; set; }
        public virtual ICollection<UserRole> UserRoleCreatorId { get; set; }
        public virtual ICollection<UserRole> UserRoleId { get; set; }

    }
}
