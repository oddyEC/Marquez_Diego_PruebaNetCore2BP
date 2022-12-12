using Microsoft.AspNetCore.Mvc;

namespace src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CedulaController : ControllerBase
    {

        public readonly ILogger<CedulaController> _logger;

        public CedulaController(ILogger<CedulaController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "GetCedula")]
        public string Get()
        {
            var diego = new Usuario(1724975386, "Diego");
            var encryptedCedula = System.Text.Encoding.UTF8.GetBytes(diego.Cedula.ToString());
            var encodingCedula = System.Convert.ToBase64String(encryptedCedula);
            var status = Response.StatusCode;
            _logger.LogWarning($"||METODO GET||cedula:{encodingCedula}||CODIGO {status}");
            return $"||METODO GET||{encodingCedula}||CODIGO {status}||";
        }
    }
}