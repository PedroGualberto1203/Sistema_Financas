using Microsoft.EntityFrameworkCore;
using PraticarFluentMapping.Data;
using PraticarFluentMapping.Models;

namespace PraticarFluentMapping.Telas.TelaTransacao
{
    public static class TelaCreateTransacao
    {
        public static void Load()
        {
            Console.Clear();

            using var context = new PraticarDataContext();

            Console.WriteLine("Para realizar uma nova transação, preencha as informações a seguir:");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Descrição:\n(ex: Conta de internet, salario trabalho...)");
            var descricao = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Valor:\nObs: Valor NEGATIVO = Débito ----- Valor POSITIVO = Adição");
            var valor = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            var data = DateTime.Now;
            Console.WriteLine("Informe o Id da categoria desta transação:");
            var idCategoria = int.Parse(Console.ReadLine());

            var categoria = context
                .Categorias
                .FirstOrDefault(x => x.Id == idCategoria);

            Console.WriteLine();

            Console.WriteLine("Digite os IDs das Tags separadas por vírgula (ex: 1,3,5):");
            var tagInput = Console.ReadLine();

            var tagIds =
                tagInput.Split(',') // Separou eles pela virgula
                    .Select(x => int.Parse(x.Trim())) //Transformou eles em inteiro e esse TRIM tira os espaços
                    .ToList(); //Transformou em uma lista

            var tags = context.Tags
                  .Where(x => tagIds.Contains(x.Id)) // Busque no banco todas as Tags cujo Id está dentro da lista tagIds
                  .ToList(); // Transformou o nome das Tags encontradas pelos Ids, em uma lista

            var cofre = context
            .Cofres
            .FirstOrDefault(x => x.Id == 1);

            cofre.Saldo += valor; 

            var transacao = context.Transacoes.Add(new Transacao
            {
                Descricao = descricao,
                Valor = valor,
                Data = data,
                Categoria = categoria,
                Tags = tags
            });

            context.Cofres.Update(cofre);
            context.SaveChanges();
            Console.Clear();
            Console.WriteLine("Transação realizada com sucesso!");
            Console.ReadKey();

            TelaMenuTransacao.Load();
        }
    }
}