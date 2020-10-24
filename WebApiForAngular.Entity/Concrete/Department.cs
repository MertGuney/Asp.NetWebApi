using WebApiForAngular.Entity.Interfaces;

namespace WebApiForAngular.Entity.Concrete
{
    public class Department : ITable
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }
}
