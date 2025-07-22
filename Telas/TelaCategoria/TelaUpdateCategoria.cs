using PraticarFluentMapping.Data;
using PraticarFluentMapping.Models;

namespace PraticarFluentMapping.Telas.TelaCategoria
{
    public static class TelaUpdateCategoria
    {
        public static void Load()
        {
            Console.Clear();

            using var context = new PraticarDataContext();

            Console.WriteLine("Para atualizar uma categoria, preencha as informações a seguir:");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("ID da categoria que deseja atualizar:");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine();

            var categoria = context
                .Categorias
                .FirstOrDefault(x => x.Id == id);

            Console.WriteLine("Novo nome da categoria:");
            categoria.Name = Console.ReadLine();

            context.Categorias.Update(categoria);
            context.SaveChanges();

            Console.Clear();
            Console.WriteLine("Categoria atualizada com sucesso!");
            Console.ReadKey();

            TelaMenuCategoria.Load();
            
        }
    }
}