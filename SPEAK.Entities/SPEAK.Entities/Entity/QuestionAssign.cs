using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Entities.Entity
{
    public class QuestionAssign : IEntityBase
    {
        public QuestionAssign()
        {
            QuestionRatingId = new List<Rating>();
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

        public int QuestionID { get; set; }
        public int SurveyID { get; set; }
        public int SectionAssignID { get; set; }
        public int LocationID { get; set; }
        public int DepartmentID { get; set; }
        public string Description { get; set; }

        public virtual User Creator { get; set; }
        public virtual User Updator { get; set; }

        public virtual Question Question { get; set; }
        public virtual Survey Survey { get; set; }
        public virtual SectionAssign SectionAssign { get; set; }
        public virtual Location Location { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<Rating> QuestionRatingId { get; set; }
    }
}
