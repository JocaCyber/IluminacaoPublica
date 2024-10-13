namespace SistemaIluminacaoPublica.Models
{
    public class Sensor
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty; // Para evitar warnings de propriedade não anulável
        public string Localizacao { get; set; } = string.Empty; // Para evitar warnings de propriedade não anulável
        public bool Status { get; set; }
        public int Luminosidade { get; set; }
        public int ConsumoEnergia { get; set; }
    }
}
