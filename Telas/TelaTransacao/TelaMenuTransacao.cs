using PraticarFluentMapping.Telas.TelaCategoria;

namespace PraticarFluentMapping.Telas.TelaTransacao
{
    public static class TelaMenuTransacao
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Transações");
            Console.WriteLine("-----------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Fazer uma transação");
            Console.WriteLine("2 - Visualizar suas últimas transações");

            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());
            Console.Clear();

            switch (option)
            {
                case 1:
                    TelaCreateTransacao.Load();
                    break;
                case 2:
                    TelaReadTransacao.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}