using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Entities.Entity
{
    public class Comment
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public int SectionAssignID { get; set; }
        public int EmployeeID { get; set; }
        public string Description { get; set; }

        public virtual SectionAssign SectionAssign { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
