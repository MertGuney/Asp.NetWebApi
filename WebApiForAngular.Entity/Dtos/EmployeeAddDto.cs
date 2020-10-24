using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiForAngular.Entity.Dtos
{
    public class EmployeeAddDto 
    {
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string DateOfJoining { get; set; }
        public string PhotoFileName { get; set; }
    }
}
