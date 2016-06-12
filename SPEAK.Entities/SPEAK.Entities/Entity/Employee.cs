using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Entities.Entity
{
    public class Employee : IEntityBase
    {
        public Employee()
        {
            QuestionRatingId = new List<Rating>();
            CommentEmployeeId = new List<Comment>();
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
        
        public string Username { get; set; }
        public string Password { get; set; }
        public int LocationID { get; set; }
        public int DepartmentID { get; set; }
        public int GenderID { get; set; }
        public int NationalityID { get; set; }
        public int JoblevelID { get; set; }
        public int ServicelengthID { get; set; }
        public int? CurrentSectionID { get; set; }
        public bool IsRegistered { get; set; }
        public DateTime? RegistrationDatetime { get; set; }
        public bool IsDistributed { get; set; }
        public DateTime? DistributionDatetime { get; set; }
        public bool IsSurveyCompleted { get; set; }
        public int SurveyID { get; set; }

        public virtual User Creator { get; set; }
        public virtual User Updator { get; set; }

        public virtual Location Location { get; set; }
        public virtual Department Department { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Nationality Nationality { get; set; }
        public virtual Joblevel Joblevel { get; set; }
        public virtual Servicelength Servicelength { get; set; }
        public virtual SectionAssign CurrentSection { get; set; }
        public virtual Survey Survey { get; set; }

        public virtual ICollection<Rating> QuestionRatingId { get; set; }
        public virtual ICollection<Comment> CommentEmployeeId { get; set; }

    }
}
