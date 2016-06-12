using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Entities.Entity
{
    public class Location : IEntityBase
    {
        public Location()
        {
            DepartmentLocationId = new List<Department>();
            EmployeeLocationId = new List<Employee>();
            QuestionAssignId = new List<QuestionAssign>();
            SectionAssignId = new List<SectionAssign>();
            SurveyId = new List<Survey>();
        }
        #region Implement IEntityBase Interface
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatorId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatorId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        public string Code { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public virtual User Creator { get; set; }
        public virtual User Updator { get; set; }
        public virtual Country Country { get; set; }

        public virtual ICollection<Department> DepartmentLocationId { get; set; }
        public virtual ICollection<Employee> EmployeeLocationId { get; set; }
        public virtual ICollection<QuestionAssign> QuestionAssignId { get; set; }
        public virtual ICollection<SectionAssign> SectionAssignId { get; set; }
        public virtual ICollection<Survey> SurveyId { get; set; }
    }
}
