using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Entities.Entity
{
    public class Joblevel : IEntityBase
    {
        public Joblevel()
        {
            EmployeeJoblevelId = new List<Employee>();
            TotalJoblevelId = new List<TotalJoblevel>();
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

        public virtual User Creator { get; set; }
        public virtual User Updator { get; set; }
        public virtual ICollection<Employee> EmployeeJoblevelId { get; set; }
        public virtual ICollection<TotalJoblevel> TotalJoblevelId { get; set; }
    }
}
