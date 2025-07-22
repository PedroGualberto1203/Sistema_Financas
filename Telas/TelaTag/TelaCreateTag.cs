using PraticarFluentMapping.Data;
using PraticarFluentMapping.Models;

namespace PraticarFluentMapping.Telas.TelaTag
{
    public static class TelaCreateTag
    {
        public static void Load()
        {
            Console.Clear();

            using var context = new PraticarDataContext();

            Console.WriteLine("Para criar uma nova tag, preencha as informações a seguir:");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Nome da Tag:");
            var novaTag = Console.ReadLine();
            Console.WriteLine();

            var tag = context.Tags.Add(new Tag
            {
                Name = novaTag
            });

            context.SaveChanges();

            Console.Clear();
            Console.WriteLine("Tag criada com sucesso!");
            Console.ReadKey();

            TelaMenuTag.Load();
            
        }
    }
}