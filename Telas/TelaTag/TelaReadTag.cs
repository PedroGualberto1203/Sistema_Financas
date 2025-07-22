using Microsoft.EntityFrameworkCore;
using PraticarFluentMapping.Data;
using PraticarFluentMapping.Models;
using PraticarFluentMapping.Telas.TelaTag;

namespace PraticarFluentMapping.Telas.TelaTag
{
    public static class TelaReadTag
    {
        public static void Load()
        {
            Console.Clear();

            using var context = new PraticarDataContext();

            Console.WriteLine("Segue abaixo as Tags existentes e seus respectivos IDs:");
            Console.WriteLine("ID -- Tag");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();

            var tags = context
                .Tags
                .AsNoTracking()
                .OrderBy(x => x.Id)
                .ToList();

            foreach (var tag in tags)
            {
                Console.WriteLine($"{tag.Id} -- {tag.Name}");
                Console.WriteLine();
            }

            Console.ReadKey();

            TelaMenuTag.Load();
            
        }
    }
}