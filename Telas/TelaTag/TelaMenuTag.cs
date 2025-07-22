using PraticarFluentMapping.Telas.TelaCategoria;

namespace PraticarFluentMapping.Telas.TelaTag
{
    public static class TelaMenuTag
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Tags");
            Console.WriteLine("-----------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Visualizar Tags");
            Console.WriteLine("2 - Cadastrar Tag");
            Console.WriteLine("3 - Atualizar Tag");
            Console.WriteLine("4 - Excluir Tag");

            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());
            Console.Clear();

            switch (option)
            {
                case 1:
                    TelaReadTag.Load();
                    break;
                case 2:
                    TelaCreateTag.Load();
                    break;
                case 3:
                    TelaUpdateTag.Load();
                    break;
                case 4:
                    TelaDeleteTag.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}