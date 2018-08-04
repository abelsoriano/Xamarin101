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

                //var response = await client.GetAsync("https://listxamplefromapirestapi.azurewebsites.net/api/Employees");

                //if (!response.IsSuccessStatusCode)
                //{
                //    return result;
                //}

                // var resultStr = await response.Content.ReadAsStringAsync();
                //result = JsonConvert.DeserializeObject<List<Employee>>(resultStr);
                var response = await client.GetStringAsync("https://listxamplefromapirestapi.azurewebsites.net/api/Employees");
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
