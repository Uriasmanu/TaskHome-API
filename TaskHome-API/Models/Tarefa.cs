namespace TaskHome_API.Models
{
    public class Tarefa
    {
        public Guid Id { get; set; } 
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public DiaAgendamento Dia { get; set; }
        public PrioridadeTarefa Propriedade { get; set; }
        public bool RepetirSemanalmente { get; set; }
        public bool Concluida { get; set; }
        public DateTime DataCriada { get; set; }
    }

    public enum PrioridadeTarefa
    {
        Baixa,
        Media,
        Alta
    }

    public enum DiaAgendamento
    {
        Segunda,
        Terca,
        Quarta,
        Quinta,
        Sexta,
        Sabado,
        Domingo
    }
}
