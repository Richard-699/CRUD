using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public HomeController(ILogger<HomeController> logger, IMapper mapper, ClienteDbContext context)
        {
            _logger = logger;
            _mapper = mapper;
            _context = context;
        }
        [HttpGet]
        public async Task<List<ClienteDTO>> Get()
        {
            var cliente = await _context.Cliente.ToListAsync();
            return _mapper.Map<List<ClienteDTO>>(cliente);
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
        public async Task<IActionResult>Create([Bind("Id_Cliente,Nombre,Tipo_Identidad,Id_Pais")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
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