﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Entities.Entity
{
    public class Language : IEntityBase
    {
        public Language()
        {
            QuestionLanguageId = new List<QuestionOther>();
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

        public string Code { get; set; }
        public string Name { get; set; }

        public virtual User Creator { get; set; }
        public virtual User Updator { get; set; }

        public virtual ICollection<QuestionOther> QuestionLanguageId { get; set; }
    }
}
