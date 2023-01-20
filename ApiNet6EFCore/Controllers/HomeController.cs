using Microsoft.AspNetCore.Mvc;

namespace ApiNet6EFCore.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly CepDbContext _context;

        public HomeController()
        {
            _context = new CepDbContext();

            // salva no banco de dados
            _context.Add(new Cep("01122000"));
            _context.Add(new Cep("15566000"));
            _context.Add(new Cep("21122000"));
            _context.SaveChanges();
        }

        [HttpGet("obter-cep")]
        public IActionResult ObterCep()
        {
            // retorna um valor aleatório entre 0 e 2
            var indiceAleatorio = new Random().Next(0, 3);

            // obtém um cep do banco de dados
            var cep = _context.Ceps.ToList()[indiceAleatorio];

            return Ok(cep);
        }

        [HttpGet("obter-estado")]
        public IActionResult AtivarConta(string numeroCep)
        {
            return Ok(new Cep(numeroCep).ObterEstado());
        }
    }
}