using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class RoleConfig : EntityBaseConfiguration<Role>
    {
        public RoleConfig()
        {
            Property(ur => ur.Name).IsRequired().HasMaxLength(50);

        }
    }
}
