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
    public class DepartmentController : ControllerBase
    {
        private readonly IGenericService<Department> _genericService;
        private readonly IMapper _mapper;
        public DepartmentController(IGenericService<Department> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var department = await _genericService.GetAll();
            return Ok(department);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var department = await _genericService.GetById(id);
            return Ok(department);
        }
        [HttpPost]
        public async Task<IActionResult> Add(DepartmentAddDto departmentAddDto)
        {
            await _genericService.Add(_mapper.Map<Department>(departmentAddDto));
            return Created("", departmentAddDto);
        }
        [HttpPut]
        public async Task<IActionResult> Update(DepartmentUpdateDto departmentUpdateDto)
        {
            await _genericService.Update(_mapper.Map<Department>(departmentUpdateDto));
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _genericService.Remove(new Department() { DepartmentID = id });
            return NoContent();
        }
        [Route("/Error")]
        public IActionResult Error()
        {
            //var errorInfo = HttpContext.Features.Get<IExceptionHandlerFeature>();
            //NLog Loglama yapılacak!!!
            return Problem(detail: "Api'de bir hata oluştu.");
        }
    }
}
