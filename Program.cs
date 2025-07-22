using Microsoft.EntityFrameworkCore;
using PraticarFluentMapping.Data;
using PraticarFluentMapping.Telas.TelaCategoria;
using PraticarFluentMapping.Telas.TelaTag;
using PraticarFluentMapping.Telas.TelaTransacao;

namespace PraticarFluentMapping
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();

        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Sistema para Controle de Finanças");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            // Console.WriteLine("1 - Fazer uma transação");
            // Console.WriteLine("2 - Visualizar suas últimas transações");
            Console.WriteLine("1 - Gestão de Transações");
            Console.WriteLine("2 - Gestão de categorias");
            Console.WriteLine("3 - Gestão de tags");
            Console.WriteLine("-------------------------------");
            ReadCofre();
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    TelaMenuTransacao.Load();
                    break;
                case 2:
                    TelaMenuCategoria.Load();
                    break;
                case 3:
                    TelaMenuTag.Load();
                    break;
                default: Menu(); break;
            }
        }


        public static void ReadCofre()
        {
            using var context = new PraticarDataContext();

            var cofre = context
            .Cofres
            .AsNoTracking()
            .OrderBy(x=> x.Id)
            .ToList();

            foreach (var item in cofre)
            {
                Console.WriteLine($"Cofre: {item.Saldo}");
            }
        }

    }
}