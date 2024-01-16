using System;
using System.IO;

namespace EditorTexto
{
    class Edicao
    {
        static void Main(string[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Escolha umas dessas opcoes: ");
            Console.WriteLine("0 - SAIR");
            Console.WriteLine("1 - CRIAR NOVO ARQUIVO");
            Console.WriteLine("2 - LER ARQUIVO EXISTENTE");

            short escolha = short.Parse(Console.ReadLine());

            switch (escolha){
                case 0: System.Environment.Exit(0); break;
                case 1: Novo(); break;
                case 2: Abrir(); break;
                default: Menu(); break;
            }

        }

        static void Novo(){
            Console.Clear();
            Console.WriteLine("DIGITE O NOVO TEXTO (ESC para FINALIZAR)");
            Console.WriteLine("---------------------");

            string text = "";

            do{
                text += Console.ReadLine();
                text += Environment.NewLine;
            }while(Console.ReadKey().Key != ConsoleKey.Escape);
            
            Salvar(text);

            Menu();
        }

        static void Abrir(){
            Console.Clear();
            Console.WriteLine("Digite o endereço do arquivo a ser lido: ");
            
            string? path = Console.ReadLine();

            using(var file = new StreamReader(path)){
                    string texto = file.ReadToEnd();
                    Console.WriteLine(texto);   
            }
            Console.ReadLine();
            Menu();
        }

        static void Salvar(string text){
            Console.Clear();
            Console.WriteLine("-Qual caminho para salvar?");
            string? path = Console.ReadLine();

            using(var file = new StreamWriter(path)){
                file.Write(text);
            }
        }

    }
}