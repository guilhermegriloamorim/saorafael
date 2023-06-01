using Almoxarifado.Dominio.Model;
using AlmoxarifadoRepositories.Data;
using AlmoxarifadoService.Dominio.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiAlmoxarifado.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : Controller
    {
        private IMapper _mapper;
        private AlmoxarifadoDbContext _context;

        public ItemController(AlmoxarifadoDbContext context, IMapper mapper) : base()
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] IList<ItemCreateDto> dto)
        {
            try
            {
                var model = _mapper.Map<IList<Item>>(dto);
                await _context.AddRangeAsync(model);
                await _context.SaveChangesAsync();
                return Ok(_mapper.Map<IList<ItemReadDto>>(model));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Read()
        {
            try
            {
                var model = await _context.Itens.OrderBy(e => e.Codigo).ToListAsync();
                return Ok(_mapper.Map<IList<ItemReadDto>>(model));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("Id")]
        public async Task<IActionResult> Read(int id)
        {
            try
            {

                var model = await _context.Itens.FirstOrDefaultAsync(item => item.Id == id);
                if (model == null)
                {
                    return NotFound();
                }
                return Ok(_mapper.Map<ItemReadDto>(model));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ItemUpdateDto dto)
        {
            try
            {

                var model = await _context.Itens.FirstOrDefaultAsync(item => item.Id == id);
                if (model == null)
                {
                    return NotFound();
                }
                _mapper.Map(dto, model);
                _context.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var model = await _context.Itens.FirstOrDefaultAsync(item => item.Id == id);
                if (model == null)
                {
                    return NotFound();
                }
                _context.Remove(model);
                _context.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        //[HttpPost]
        //public async Task<IActionResult> Add([FromBody] ItemDto dto)
        //{
        //    try
        //    {
        //        var model = _mapper.Map<Item>(dto);
        //        await _context.AddAsync(model);
        //        await _context.SaveChangesAsync();
        //        return Ok(_mapper.Map<ItemDto>(model));
        //    }
        //    catch
        //    {
        //        return BadRequest();
        //    }
        //}
    }
}
