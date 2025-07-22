using Microsoft.EntityFrameworkCore;
using PraticarFluentMapping.Data;
using PraticarFluentMapping.Models;
using PraticarFluentMapping.Telas.TelaTransacao;

namespace PraticarFluentMapping.Telas.TelaCategoria
{
    public static class TelaReadTransacao
    {
        public static void Load()
        {
            Console.Clear();

            using var context = new PraticarDataContext();

            Console.WriteLine("Segue abaixo as transações existentes:");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();

            var transacoes = context
                .Transacoes
                .AsNoTracking()
                .Include(x => x.Categoria)
                .Include(x=> x.Tags)
                .OrderBy(x => x.Id)
                .ToList();

            foreach (var transacao in transacoes)
            {
                Console.WriteLine($"-Descrição: {transacao.Descricao}\n-Valor: {transacao.Valor}\n-Data: {transacao.Data}\n-Categoria: {transacao.Categoria.Name}");
                Console.WriteLine("-Tags:");
                foreach (var tag in transacao.Tags)
                {
                    Console.WriteLine($".{tag.Name}");
                }
                Console.WriteLine("---------------------------------------");
            }

            Console.ReadKey();

            TelaMenuTransacao.Load();
            
        }
    }
}