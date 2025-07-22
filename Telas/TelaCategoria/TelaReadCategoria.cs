using Microsoft.EntityFrameworkCore;
using PraticarFluentMapping.Data;
using PraticarFluentMapping.Models;

namespace PraticarFluentMapping.Telas.TelaCategoria
{
    public static class TelaReadCategoria
    {
        public static void Load()
        {
            Console.Clear();

            using var context = new PraticarDataContext();

            Console.WriteLine("Segue abaixo as categorias existentes e seus respectivos IDs:");
            Console.WriteLine("ID -- Categoria");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();

            var categorias = context
                .Categorias
                .AsNoTracking()
                .OrderBy(x => x.Id)
                .ToList();

            foreach (var categoria in categorias)
            {
                Console.WriteLine($"{categoria.Id} -- {categoria.Name}");
                Console.WriteLine();
            }

            Console.ReadKey();

            TelaMenuCategoria.Load();
            
        }
    }
}