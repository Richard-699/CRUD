using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaFinal.DataAccess;
using PruebaFinal.DTOS;
using PruebaFinal.Models;
using System.Diagnostics;
using System.Net;

namespace PruebaFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ClienteDbContext _context;
        private readonly ILogger<HomeController> _logger;
        [BindProperty]
        public ClienteDTO clienteDTO { get; set; }

        public HomeController(ILogger<HomeController> logger, IMapper mapper, ClienteDbContext context)
        {
            _logger = logger;
            _mapper = mapper;
            _context = context;
            clienteDTO=new ClienteDTO();
        }
        [HttpGet]
        public async Task<ClienteDTO> Get()
        {
            var clientes = await _context.Cliente.ToListAsync();
            var Paises = await _context.Pais.ToListAsync();
            clienteDTO.Paises = Paises;
            clienteDTO.clientes = clientes;
            return clienteDTO;
        }

        public async Task<IActionResult> Index()
        {
            return View(await Get());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>Create(ClienteDTO clienteDto)
        {
            if (ModelState.IsValid)
            {
                var cliente=_mapper.Map<Cliente>(clienteDto);
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>Delete(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            _context.Cliente.Remove(cliente);
            await _context.SaveChangesAsync();
            return Content("1");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}