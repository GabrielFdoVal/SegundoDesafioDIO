using SegundoDesafioDIO;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string op = OpcaoUsuario();

            while (op != "X")
            {
                switch (op)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(op, "Opção Inválida!");
                }
                op = OpcaoUsuario();
            }
        }

        private static void ListarSeries(){
            Console.WriteLine("Listar Séries");
            Console.WriteLine();
            var lista = repositorio.Lista();
            if(lista.Count == 0){
                Console.Write("Nenhuma série cadastrada");
                
            }
            else{
                foreach(var serie in lista){
                    if(!serie.estaExcluida()){
                        Console.WriteLine($"|#ID {serie.getID()}\n|Título {serie.getTitulo()}\n");
                    }                    
                }
            }       
            Console.WriteLine();
            return;
        }

        private static void InserirSerie(){
            Console.WriteLine("Inserir nova série");

            Console.Write("Digite o título da série: ");
            string titulo = Console.ReadLine();

            foreach(int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine($"{i} {Enum.GetName(typeof(Genero),i)}");
            }
            Console.Write("Digite o código do genêro entre as opções acima: ");
            int genero = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string descricao = Console.ReadLine();

            Console.Write("Digite o ano da série: ");
            int ano = int.Parse(Console.ReadLine());

            Serie s = new Serie(repositorio.ProximoId(), titulo, descricao, ano, (Genero) genero);

            repositorio.Insere(s);
            return;
        }

        private static void AtualizarSerie(){
            Console.WriteLine("Atualizar série");

            Console.Write("Digite o #ID da série: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            string titulo = Console.ReadLine();

            foreach(int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine($"{i} {Enum.GetName(typeof(Genero),i)}");
            }
            Console.Write("Digite o código do genêro entre as opções acima: ");
            int genero = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string descricao = Console.ReadLine();

            Console.Write("Digite o ano da série: ");
            int ano = int.Parse(Console.ReadLine());

            Serie s = new Serie(repositorio.ProximoId(), titulo, descricao, ano, (Genero) genero);

            repositorio.Atualiza(id, s);
            return;
        }

        private static void ExcluirSerie(){
            Console.Write("Digite o #ID da série: ");
            int id = int.Parse(Console.ReadLine());

            repositorio.Exclui(id);
            return;
        }

        private static void VisualizarSerie(){
            Console.Write("Digite o #ID da série: ");
            int id = int.Parse(Console.ReadLine());

            Serie serie = repositorio.RetornaPorId(id);
            if(!serie.estaExcluida()){
                Console.WriteLine(serie);
            }
            return;
        }

        private static string OpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("<- Informe a opção desejada ->");
            Console.WriteLine("|1- Listar séries");
            Console.WriteLine("|2- Inserir nova série");
            Console.WriteLine("|3- Atualizar série");
            Console.WriteLine("|4- Excluir série");
            Console.WriteLine("|5- Visualizar série");
            Console.WriteLine("|C- Limpar Tela");
            Console.WriteLine("|X- Sair");
            Console.WriteLine();

            string op = Console.ReadLine().ToUpper().Trim();
            Console.WriteLine();
            return op;
        }
    }
}