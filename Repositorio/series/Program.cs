using System; 
using System.Collections.Generic; 

namespace projeto 
{
    public class cadastro 
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        
        static void Main (string [] args) 
        {
            string OpcaoUsuario = ObterOpcaoUsuario();
            
            while (OpcaoUsuario.ToUpper() != "X")
            {
                switch (OpcaoUsuario)
                {
                    case "1":
                    ListarSeries();
                    break;
                    case "2":
                    InserirSeries();
                    break;
                    case "3":
                    AtualizarSeries();
                    break;
                    case "4":
                    // ExcluirSeries();
                    break;
                    case "5":
                    // VisualizarSerie();
                    break;
                    case "C":
                    Console.Clear();
                    break;

                        default:
                            throw new ArgumentOutOfRangeException();
                }

                OpcaoUsuario = ObterOpcaoUsuario();
                Console.ReadLine();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Insira a opção desejada: ");
            System.Console.WriteLine();
            System.Console.WriteLine("1- Listar séries");
            System.Console.WriteLine("2 - Adicionar séries");
            System.Console.WriteLine("3 - Atualizar série");
            System.Console.WriteLine("4 - Excluir série");
            System.Console.WriteLine("5 - Visualizar série");
            System.Console.WriteLine("C - Limpar tela");
            System.Console.WriteLine("X - Sair");
            System.Console.WriteLine();

            string OpcaoUsuario = Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return OpcaoUsuario;

        }
        private static void ListarSeries()
        {
            Console.WriteLine("Listar Séries: ");

            var lista = repositorio.Lista();

            if (lista.Count == 0) 
            {
                Console.WriteLine("Nenhuma série cadastrada");
                return;
            }
            foreach (var serie in lista)
            {
                var excluido = serie.RetornaExcluido();
                
                System.Console.WriteLine($"#ID {serie.retornaId()}: -> {serie.retornaTitulo()}");
            }
        }
        private static void InserirSeries()
        {
            System.Console.WriteLine("Inserir série: ");

                foreach (int i in Enum.GetValues(typeof(Genero)))
                {
                    System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
                }

                System.Console.WriteLine("Digite o número do gênero listado dentre as opções acima: ");
                int EntradaGenero = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Digite o título da série: ");
                string? EntradaTitulo = Console.ReadLine();

                System.Console.WriteLine("Digite o ano da série: ");
                int EntradaAno = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Digite a descrição da série: ");
                string? EntradaDescricao = Console.ReadLine();
        }
        private static void AtualizarSeries()
        {
            Console.Write("Digite o id da série: ");
            int IndiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero a partir das opções acima: ");
            int EntradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o título da série: ");
            string EntradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Insira a descrição da série: ");
            string EntradaDescricao = Console.ReadLine();

            System.Console.WriteLine("Insira o ano da série: ");
            int EntradaAno = int.Parse(Console.ReadLine());

            series atualizaSerie = new series(id: IndiceSerie,
										genero: (Genero)EntradaGenero,
										titulo: EntradaTitulo,
										ano: EntradaAno,
										descricao: EntradaDescricao);

			repositorio.Atualiza(IndiceSerie, atualizaSerie);
        }
        private static void ExcluirSeries()
        {
            System.Console.WriteLine("Insira o índice da série: ");
            int IndiceSerie = int.Parse(Console.ReadLine());

            repositorio.Excluir(IndiceSerie);
        }
        private static void VisualizarSerie()
        {
            System.Console.WriteLine("Digite o ID da série: ");
            int IndiceSerie = int.Parse(Console.ReadLine());

            repositorio.RetornaPorID(IndiceSerie); 
        }
    }
}