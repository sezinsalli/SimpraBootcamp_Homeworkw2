﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpra_Homework_Core.UnitofWorks
{
    public interface IUnitofWork
    {
        Task CommitAsync();
        void Commit();
        

        
    }
}
