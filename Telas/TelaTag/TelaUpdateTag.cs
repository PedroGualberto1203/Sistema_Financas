using PraticarFluentMapping.Data;
using PraticarFluentMapping.Models;
using PraticarFluentMapping.Telas.TelaTag;

namespace PraticarFluentMapping.Telas.TelaTag
{
    public static class TelaUpdateTag
    {
        public static void Load()
        {
            Console.Clear();

            using var context = new PraticarDataContext();

            Console.WriteLine("Para atualizar uma Tag, preencha as informações a seguir:");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("ID da Tag que deseja atualizar:");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine();

            var tag = context
                .Tags
                .FirstOrDefault(x => x.Id == id);

            Console.WriteLine("Novo nome da Tag:");
            tag.Name = Console.ReadLine();

            context.Tags.Update(tag);
            context.SaveChanges();

            Console.Clear();
            Console.WriteLine("Tag atualizada com sucesso!");
            Console.ReadKey();

            TelaMenuTag.Load();
            
        }
    }
}