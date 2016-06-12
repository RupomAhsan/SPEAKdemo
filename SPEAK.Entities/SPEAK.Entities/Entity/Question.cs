using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Entities.Entity
{
    public class Question : IEntityBase
    {
        public Question()
        {
            QuestionOtherId = new List<QuestionOther>();
            QuestionAssignId = new List<QuestionAssign>();
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

        public string Name { get; set; }
        public string Description { get; set; }

        public virtual User Creator { get; set; }
        public virtual User Updator { get; set; }

        public virtual ICollection<QuestionOther> QuestionOtherId { get; set; }
        public virtual ICollection<QuestionAssign> QuestionAssignId { get; set; }


    }
}
