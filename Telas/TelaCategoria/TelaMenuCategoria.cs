namespace PraticarFluentMapping.Telas.TelaCategoria
{
    public static class TelaMenuCategoria
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Categoria");
            Console.WriteLine("-----------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Visualizar Categorias");
            Console.WriteLine("2 - Cadastrar Categoria");
            Console.WriteLine("3 - Atualizar Categoria");
            Console.WriteLine("4 - Excluir Categoria");

            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());
            Console.Clear();

            switch (option)
            {
                case 1:
                    TelaReadCategoria.Load();
                    break;
                case 2:
                    TelaCreateCategoria.Load();
                    break;
                case 3:
                    TelaUpdateCategoria.Load();
                    break;
                case 4:
                    TelaDeleteCategoria.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}