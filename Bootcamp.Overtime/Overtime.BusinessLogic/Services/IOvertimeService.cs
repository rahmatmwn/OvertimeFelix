﻿using Overtime.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.BussinessLogic.Services
{
    public interface IOvertimeService
    {
        List<Overtimes> Get();

        List<Overtimes> Get(int? Id);
    }
}
