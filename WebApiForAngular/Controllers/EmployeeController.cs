using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApiForAngular.Business.Interfaces;
using WebApiForAngular.Entity.Concrete;
using WebApiForAngular.Entity.Dtos;

namespace WebApiForAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IGenericService<Employee> _genericService;
        private readonly IMapper _mapper;
        public EmployeeController(IGenericService<Employee> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employee = await _genericService.GetAll();
            return Ok(employee);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await _genericService.GetById(id);
            return Ok(employee);
        }
        [HttpPost]
        public async Task<IActionResult> Add(EmployeeAddDto employeeAddDto)
        {
            await _genericService.Add(_mapper.Map<Employee>(employeeAddDto));
            return Created("", employeeAddDto);
        }
        [HttpPut]
        public async Task<IActionResult> Update(EmployeeUpdateDto employeeUpdateDto)
        {
            await _genericService.Update(_mapper.Map<Employee>(employeeUpdateDto));
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _genericService.Remove(new Employee() { EmployeeId = id });
            return NoContent();
        }
    }
}
