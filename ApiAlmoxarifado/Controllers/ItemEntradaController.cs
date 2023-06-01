using AlmoxarifadoService.Dominio.DTO;
using AlmoxarifadoService.Interfaces;
namespace ApiAlmoxarifado.Controllers
{
    public class ItemEntradaController : AlomoxarifadoBaseController<IServiceItemEntrada, ItemEntradaDtoRead, ItemEntradaDtoCreate, ItemEntradaDtoUpdate>
    {
        public ItemEntradaController(IServiceItemEntrada service) : base(service)
        {
        }
    }
//    [ApiController]
//    [Route("api/[controller]")]
//    public class ItemEntradaController : Controller
//    {
//        private IMapper _mapper;
//        private AlmoxarifadoDbContext _context;

//        public ItemEntradaController(AlmoxarifadoDbContext context, IMapper mapper) : base()
//        {
//            _context = context;
//            _mapper = mapper;
//        }

//        [HttpPost]
//        public async Task<IActionResult> Create([FromBody] IList<ItemEntradaCreateDto> dto)
//        {
//            try
//            {
//                var model = _mapper.Map<IList<ItemEntrada>>(dto);
//                await _context.AddRangeAsync(model);
//                await _context.SaveChangesAsync();
//                return Ok(_mapper.Map<IList<ItemEntradaReadDto>>(model));
//            }
//            catch (Exception ex)
//            {
//                return NotFound(ex.Message);
//            }
//        }

//        [HttpGet]
//        public async Task<IActionResult> Read()
//        {
//            try
//            {
//                var model = await _context.ItensEntrada.ToListAsync();
//                return Ok(_mapper.Map<IList<ItemEntradaReadDto>>(model));
//            }
//            catch (Exception ex)
//            {
//                return NotFound(ex.Message);
//            }
//        }

//        [HttpGet("Id")]
//        public async Task<IActionResult> Read(int id)
//        {
//            try
//            {
//                var model = await _context.ItensEntrada.FirstOrDefaultAsync(item => item.Id == id);
//                if (model == null)
//                {
//                    return NotFound();
//                }
//                return Ok(_mapper.Map<ItemEntradaReadDto>(model));
//            }
//            catch (Exception ex)
//            {
//                return NotFound(ex.Message);
//            }
//        }

//        [HttpPut("{id}")]
//        public async Task<IActionResult> Update(int id, [FromBody] ItemEntradaUpdateDto dto)
//        {
//            try
//            {
//                var model = await _context.ItensEntrada.FirstOrDefaultAsync(item => item.Id == id);
//                if (model == null)
//                {
//                    return NotFound();
//                }
//                _mapper.Map(dto, model);
//                _context.SaveChanges();
//                return NoContent();
//            }
//            catch (Exception ex)
//            {
//                return NotFound(ex.Message);
//            }
//        }

//        [HttpDelete("{id}")]
//        public async Task<IActionResult> Delete(int id)
//        {
//            try
//            {
//                var model = await _context.ItensEntrada.FirstOrDefaultAsync(item => item.Id == id);
//                if (model == null)
//                {
//                    return NotFound();
//                }
//                _context.Remove(model);
//                _context.SaveChanges();
//                return NoContent();
//            }
//            catch (Exception ex)
//            {
//                return NotFound(ex.Message);
//            }
//        }

//    }
}
