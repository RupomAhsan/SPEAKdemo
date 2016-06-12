using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Entities.Entity
{
    public class Rating
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public int QuestionAssignID { get; set; }
        public int EmployeeID { get; set; }
        public int Rate { get; set; }

        public virtual QuestionAssign QuestionAssign { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
