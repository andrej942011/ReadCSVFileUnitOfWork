﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCSVFileADO.UnitOfWorkSQLServer.Interface
{
    public interface IUnitOfWork
    {
        IUnitOfWorkAdapter Create();
    }
}
