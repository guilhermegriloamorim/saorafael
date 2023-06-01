using AlmoxarifadoService.Dominio.DTO;
using AlmoxarifadoService.Interfaces;

namespace ApiAlmoxarifado.Controllers
{
    public class BarracaController : AlomoxarifadoBaseController<IServiceBarraca, BarracaDtoRead, BarracaDtoCreate, BarracaDtoUpdate>
    {
        public BarracaController(IServiceBarraca barracaService) : base(barracaService)
        {
        }
    }
    //[ApiController]
    //[Route("api/[controller]")]
    //public class BarracaController : Controller
    //{
    //    private IMapper _mapper;
    //    private AlmoxarifadoDbContext _context;

    //    public BarracaController(AlmoxarifadoDbContext context, IMapper mapper) : base()
    //    {
    //        _context = context;
    //        _mapper = mapper;
    //    }

    //    [HttpPost]
    //    public async Task<IActionResult> Create([FromBody] BarracaCreateDto dto)
    //    {
    //        try
    //        {
    //            var model = _mapper.Map<Barraca>(dto);
    //            await _context.AddRangeAsync(model);
    //            await _context.SaveChangesAsync();
    //            return Ok();
    //        }
    //        catch (Exception ex)
    //        {
    //            return NotFound(ex.Message);
    //        }
    //    }

    //    [HttpGet]
    //    public async Task<IActionResult> Read()
    //    {
    //        try
    //        {
    //            var model = await _context.Barracas.ToListAsync();
    //            var dtos = _mapper.Map<IList<BarracaReadDto>>(model);
    //            return Ok(dtos);
    //        }
    //        catch (Exception ex)
    //        {
    //            return NotFound(ex.Message);
    //        }
    //    }

    //    [HttpGet("Id")]
    //    public async Task<IActionResult> Read(int id)
    //    {
    //        try
    //        {

    //            var model = await _context.Barracas.FirstOrDefaultAsync(item => item.Id == id);
    //            if (model == null)
    //            {
    //                return NotFound();
    //            }
    //            return Ok(_mapper.Map<BarracaReadDto>(model));
    //        }
    //        catch (Exception ex)
    //        {
    //            return NotFound(ex.Message);
    //        }
    //    }

    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> Update(int id, [FromBody] BarracaUpdateDto dto)
    //    {
    //        try
    //        {
    //            var model = await _context.Barracas.FirstOrDefaultAsync(item => item.Id == id);
    //            if (model == null)
    //            {
    //                return NotFound();
    //            }
    //            _mapper.Map(dto, model);
    //            _context.SaveChanges();
    //            return NoContent();
    //        }
    //        catch (Exception ex)
    //        {
    //            return NotFound(ex.Message);
    //        }
    //    }

    //    [HttpDelete("{id}")]
    //    public async Task<IActionResult> Delete(int id)
    //    {
    //        try
    //        {
    //            var model = await _context.Barracas.FirstOrDefaultAsync(item => item.Id == id);
    //            if (model == null)
    //            {
    //                return NotFound();
    //            }
    //            _context.Remove(model);
    //            _context.SaveChanges();
    //            return NoContent();
    //        }
    //        catch (Exception ex)
    //        {
    //            return NotFound(ex.Message);
    //        }
    //    }

    //}


}
