using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Business.Services.Base.Interface;

namespace CompanyManagementApplication.Controllers.Base
{
    public abstract class BaseCrudController<TResponseDto, TService> : BaseController where TService : IBaseService<TResponseDto>
    {
        protected readonly TService _service;

        protected BaseCrudController(TService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await _service.GetByIdAsync(id);
            return response != null ? Ok(response) : NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _service.GetAllAsync();
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TResponseDto dto)
        {
            await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(Get), new { id = dto.Id }, dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] TResponseDto dto)
        {
            await _service.UpdateAsync(id, dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
