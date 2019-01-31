﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;
using Overtime.Common.Interface.Master;

namespace Overtime.BusinessLogic.Master
{
    public class EmployeeService : iEmployeeService
    {
        iEmployeeRepository _employeeRepository = new EmployeeRepository();
        
        public bool Delete(int? id)
        {
            return _employeeRepository.Delete(id);
        }

        public List<Employees> Get()
        {
            return _employeeRepository.Get();
        }

        public Employees Get(int? id)
        {
            return _employeeRepository.Get(id);
        }

        public bool Insert(EmployeeParam employeeParam)
        {
            return _employeeRepository.Insert(employeeParam);
        }

        public List<Employees> Search(string search, string cmb)
        {
            return _employeeRepository.Search(search, cmb);
        }

        public bool Update(int? id, EmployeeParam employeeParam)
        {
            return _employeeRepository.Update(id, employeeParam);
        }
    }
}
