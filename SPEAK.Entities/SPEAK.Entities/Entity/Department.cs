using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Entities.Entity
{
    public class Department : IEntityBase
    {
        public Department()
        {
            DepartmentParentId = new List<Department>();
            EmployeeDepartmentId = new List<Employee>();
            QuestionAssignId = new List<QuestionAssign>();
            SectionAssignId = new List<SectionAssign>();

            TotalJoblevelId = new List<TotalJoblevel>();
            TotalNationalityId = new List<TotalNationality>();
            TotalServicelengthId = new List<TotalServicelength>();
            TotalGenderId = new List<TotalGender>();
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
        public string Description { get; set; }
        public int LocationID { get; set; }
        public int? OwnerID { get; set; }
        public bool IsParent { get; set; }
        public int? ParentID { get; set; }

        public virtual User Creator { get; set; }
        public virtual User Updator { get; set; }
        public virtual Department Parent { get; set; }
        public virtual User Owner { get; set; }
        public virtual Location Location { get; set; }

        public virtual ICollection<Department> DepartmentParentId { get; set; }
        public virtual ICollection<Employee> EmployeeDepartmentId { get; set; }
        public virtual ICollection<QuestionAssign> QuestionAssignId { get; set; }
        public virtual ICollection<SectionAssign> SectionAssignId { get; set; }

        public virtual ICollection<TotalGender> TotalGenderId { get; set; }
        public virtual ICollection<TotalJoblevel> TotalJoblevelId { get; set; }
        public virtual ICollection<TotalNationality> TotalNationalityId { get; set; }
        public virtual ICollection<TotalServicelength> TotalServicelengthId { get; set; }


    }
}
