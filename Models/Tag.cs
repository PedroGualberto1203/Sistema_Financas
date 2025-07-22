namespace PraticarFluentMapping.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Transacao> Transacoes { get; set; }
    }
}