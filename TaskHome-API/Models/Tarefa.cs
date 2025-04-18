namespace TaskHome_API.Models
{
    public class Tarefa
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataAgendada { get; set; }
        public bool StatusDeConclusao { get; set; }
        public DateTime DataCriada { get; set; } = DateTime.Now;
    }
}
