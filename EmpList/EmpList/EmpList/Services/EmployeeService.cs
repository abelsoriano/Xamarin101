using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using EmpList.Interfaces;
using EmpList.Models;
using Newtonsoft.Json;

namespace EmpList.Services
{
    public class EmployeeService : IEmployeeService
    {
        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            var result = new List<Employee>();

            try
            {
                var client = new HttpClient();

                var response = await client.GetStringAsync("https://listxamplefromapirestapi.azurewebsites.net/api/GetEmployees");
                result = JsonConvert.DeserializeObject<List<Employee>>(response);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return result;
        }
    }
}
