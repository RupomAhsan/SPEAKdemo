﻿using SPEAK.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Configurations
{
    public class LocationConfig : EntityBaseConfiguration<Location>
    {
        public LocationConfig()
        {
            Property(p => p.Name).IsRequired().HasMaxLength(50);
            Property(p => p.Code).HasMaxLength(3);

            HasRequired(u => u.Creator)
                        .WithMany(t => t.LocationCreatorId)
                        .HasForeignKey(p => p.CreatorId)
                        .WillCascadeOnDelete(false);

            HasOptional(u => u.Updator)
                        .WithMany(t => t.LocationUpdatorId)
                        .HasForeignKey(p => p.UpdatorId)
                        .WillCascadeOnDelete(false);

            HasRequired(u => u.Country)
                        .WithMany(t => t.LocationId)
                        .HasForeignKey(p => p.CountryId)
                        .WillCascadeOnDelete(false);
        }
    }
}
