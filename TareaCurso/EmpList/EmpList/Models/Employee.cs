using Newtonsoft.Json;

namespace EmpList.Models
{
    public class Employee
    {
       // [JsonProperty("id")]
        public int? EmployeeId { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public decimal? Salary { get; set; }
    }
}
