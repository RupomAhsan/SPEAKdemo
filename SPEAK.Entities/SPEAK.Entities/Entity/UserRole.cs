using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Entities.Entity
{
    public class UserRole : IEntityBase
    {
        #region Implement IEntityBase Interface
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatorId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatorId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        public int UserID { get; set; }
        public int RoleID { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }

        public virtual User Creator { get; set; }
        public virtual User Updator { get; set; }
    }
}
