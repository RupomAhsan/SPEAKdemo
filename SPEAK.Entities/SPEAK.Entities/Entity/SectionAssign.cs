using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Entities.Entity
{
    public class SectionAssign : IEntityBase
    {
        public SectionAssign()
        {
            EmployeeCurrentSectionId = new List<Employee>();
            QuestionAssignId = new List<QuestionAssign>();
            CommentSectionAssignId = new List<Comment>();
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

        public int SectionID { get; set; }
        public int SurveyID { get; set; }
        public int LocationID { get; set; }
        public int DepartmentID { get; set; }
        public string Description { get; set; }

        public virtual User Creator { get; set; }
        public virtual User Updator { get; set; }

        public virtual Section Section { get; set; }
        public virtual Survey Survey { get; set; }
        public virtual Location Location { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<Employee> EmployeeCurrentSectionId { get; set; }
        public virtual ICollection<QuestionAssign> QuestionAssignId { get; set; }
        public virtual ICollection<Comment> CommentSectionAssignId { get; set; }
    }
}
