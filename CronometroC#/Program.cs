using System.Threading;

namespace cronometro
{
    class Cronometragem
    {
        static void Main(string[] args)
        {
            MENU();
        }

        static void MENU(){

            Console.WriteLine("Digite o tempo desejado em Minutos Ou Segundos:");
            Console.WriteLine("M - Minutos => 3m ou 3M");
            Console.WriteLine("S - Segundos => 34s ou 23S");
            Console.WriteLine("0 para sair");

            var resposta = (Console.ReadLine()).ToLower();

            if(resposta == "0"){
                System.Environment.Exit(0);
            }

            char modo = char.Parse(resposta.Substring(resposta.Length - 1, 1));
            int tempo = int.Parse(resposta.Substring(0, resposta.Length - 1));

            if(modo == 'm'){
                Start(tempo*60);
            } else if(modo == 's'){
                Start(tempo);
            } else {
                Console.WriteLine("MODO INVÁLIDO");
            }
        }

        static void Start(int timeLimit)
        {
            int currentTime = 0;

            while (currentTime != timeLimit){
                currentTime++;
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Tempo atual: " + currentTime);
            }

            Console.WriteLine("TEMPO FINALIZADO: " + currentTime + "segundos.");
            Thread.Sleep(1500);
            MENU();
        }
    }


}