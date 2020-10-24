using WebApiForAngular.Entity.Interfaces;

namespace WebApiForAngular.Entity.Concrete
{
    public class Employee : ITable
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string DateOfJoining { get; set; }
        public string PhotoFileName { get; set; }
    }
}
