using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmpList.Models;

namespace EmpList.Interfaces
{
    public interface IEmployeeService
    {
         Task<IEnumerable<Employee>> GetAllEmployees();
    }
}
