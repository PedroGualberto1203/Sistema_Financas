using PraticarFluentMapping.Data;
using PraticarFluentMapping.Models;

namespace PraticarFluentMapping.Telas.TelaCategoria
{
    public static class TelaCreateCategoria
    {
        public static void Load()
        {
            Console.Clear();

            using var context = new PraticarDataContext();

            Console.WriteLine("Para criar uma nova categoria, preencha as informações a seguir:");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Nome da categoria:");
            var novaCategoria = Console.ReadLine();
            Console.WriteLine();

            var categoria = context.Categorias.Add(new Categoria
            {
                Name = novaCategoria
            });

            context.SaveChanges();

            Console.Clear();
            Console.WriteLine("Categoria criada com sucesso!");
            Console.ReadKey();

            TelaMenuCategoria.Load();
            
        }
    }
}