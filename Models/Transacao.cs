namespace PraticarFluentMapping.Models
{
    public class Transacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public Categoria Categoria { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}