namespace VetTechApi.Models
{
    public class Veterinario
    {
        public int Id { get; set; }

        public int Nome { get; set; }
        public string CRMV { get; set; }
        public string Especialidade { get; set; }

        public ICollection<Consulta> Consulta { get; set; } = new List<Consulta>();
    }
}
