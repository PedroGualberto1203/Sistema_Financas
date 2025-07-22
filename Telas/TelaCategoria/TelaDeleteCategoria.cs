using PraticarFluentMapping.Data;
using PraticarFluentMapping.Models;

namespace PraticarFluentMapping.Telas.TelaCategoria
{
    public static class TelaDeleteCategoria
    {
        public static void Load()
        {
            Console.Clear();

            using var context = new PraticarDataContext();

            Console.WriteLine("Para deletar uma categoria, preencha as informações a seguir:");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("ID da categoria que deseja deletar:");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine();

            var categoria = context
                .Categorias
                .FirstOrDefault(x => x.Id == id);

            context.Categorias.Remove(categoria);
            context.SaveChanges();

            Console.Clear();
            Console.WriteLine("Categoria deletada com sucesso!");
            Console.ReadKey();

            TelaMenuCategoria.Load();
            
        }
    }
}