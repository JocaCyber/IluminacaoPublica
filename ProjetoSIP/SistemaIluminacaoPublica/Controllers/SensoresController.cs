using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SistemaIluminacaoPublica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensoresController : ControllerBase
    {
        private static List<Sensor> Sensores = new List<Sensor>
        {
            new Sensor { Id = 1, Nome = "Sensor 1", Localizacao = "Rua A", Status = true, Luminosidade = 100, ConsumoEnergia = 5 },
            new Sensor { Id = 2, Nome = "Sensor 2", Localizacao = "Rua B", Status = false, Luminosidade = 50, ConsumoEnergia = 3 },
            new Sensor { Id = 3, Nome = "Sensor 3", Localizacao = "Rua C", Status = true, Luminosidade = 80, ConsumoEnergia = 4 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Sensor>> GetSensores()
        {
            return Ok(Sensores);
        }

        // Novo método para responder à URL base
        [HttpGet("/")] // Mapeia a URL base
        public ActionResult<string> GetRoot()
        {
            return "Bem-vindo à API de Sensores. Use /api/sensores para acessar os sensores.";
        }
    }

    public class Sensor
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty; // Inicializa como vazio
        public string Localizacao { get; set; } = string.Empty; // Inicializa como vazio
        public bool Status { get; set; }
        public int Luminosidade { get; set; }
        public int ConsumoEnergia { get; set; }
    }
}
