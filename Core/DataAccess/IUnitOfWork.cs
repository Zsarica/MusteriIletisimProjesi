﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>()
           where T : class, new();
        int Save();
    }
}
