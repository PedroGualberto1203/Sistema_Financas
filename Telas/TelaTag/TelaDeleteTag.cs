using PraticarFluentMapping.Data;
using PraticarFluentMapping.Models;

namespace PraticarFluentMapping.Telas.TelaTag
{
    public static class TelaDeleteTag
    {
        public static void Load()
        {
            Console.Clear();

            using var context = new PraticarDataContext();

            Console.WriteLine("Para deletar uma Tag, preencha as informações a seguir:");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("ID da Tag que deseja deletar:");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine();

            var tag = context
                .Tags
                .FirstOrDefault(x => x.Id == id);

            context.Tags.Remove(tag);
            context.SaveChanges();

            Console.Clear();
            Console.WriteLine("Tag deletada com sucesso!");
            Console.ReadKey();

            TelaMenuTag.Load();
            
        }
    }
}