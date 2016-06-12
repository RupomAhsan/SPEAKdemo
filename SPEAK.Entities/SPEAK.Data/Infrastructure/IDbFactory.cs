﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPEAK.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        SPEAKContext Init();
    }
}
