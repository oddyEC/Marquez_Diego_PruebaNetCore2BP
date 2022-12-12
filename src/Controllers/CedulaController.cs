using Microsoft.AspNetCore.Mvc;

namespace src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CedulaController : ControllerBase
    {
        private static readonly List<Usuario> usuarios = new List<Usuario>(){
        new Usuario(){Cedula="1724956672",Nombre="Diego Marquez"},
        new Usuario(){Cedula="1724343449",Nombre="Jose Jose"},
        new Usuario(){Cedula="1724911325",Nombre="Nath Vill"},
        new Usuario(){Cedula="1724934222",Nombre="For Form"},
        new Usuario(){Cedula="1724954654",Nombre="Joe Joe"},
        new Usuario(){Cedula="1724973434",Nombre="Joe Casx"},
        new Usuario(){Cedula="1724916565",Nombre="Mike"},
        };

        public readonly ILogger<CedulaController> _logger;

        public CedulaController(ILogger<CedulaController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "GetCedula")]
        public string Get([FromHeader] string cedula)
        {
            if (usuarios.Any(x => x.Cedula.Equals(cedula)))
            {
                var encryptedCedula = System.Text.Encoding.UTF8.GetBytes(cedula);
                var encodingCedula = System.Convert.ToBase64String(encryptedCedula);
                var status = Response.StatusCode;
                _logger.LogWarning($"||METODO GET||cedula:{encodingCedula}||CODIGO {status}");
                return $"||METODO GET||{encodingCedula}||CODIGO {status}||";
            }
            else
            {
                throw new ArgumentException($"No hay la {cedula} que solicita");
            }
        }
    }
}