using System.Text.Json.Serialization;

namespace VetTechApi.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Especie { get; set; }

        public int TutorId { get; set; }

        [JsonIgnore]
        public Tutor? Tutor { get; set; }

        public ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();
      
    }
}
