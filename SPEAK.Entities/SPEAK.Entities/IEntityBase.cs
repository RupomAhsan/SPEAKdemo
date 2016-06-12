using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Entities
{
   public interface IEntityBase
    {
        int ID { get; set; }
        DateTime CreatedDate { get; set; }
        int CreatorId { get; set; }
        DateTime? UpdatedDate { get; set; }
        int? UpdatorId { get; set; }
        bool IsActive { get; set; }
        bool IsDeleted { get; set; }
    }
}
