using System;

namespace PedraPapelTesoura
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] opcoes = { "pedra", "papel", "tesoura" };
            string escolhaUsuario;
            string continuar;

            do
            {
                Console.WriteLine("Escolha uma opcao: pedra, papel ou tesoura");
                escolhaUsuario = Console.ReadLine().ToLower();

                if (Array.Exists(opcoes, opcao => opcao == escolhaUsuario))
                {
                    int escolhaComputadorIndex = random.Next(0, 3);
                    string escolhaComputador = opcoes[escolhaComputadorIndex];

                    Console.WriteLine($"O computador escolheu: {escolhaComputador}");

                    if (escolhaUsuario == escolhaComputador)
                    {
                        Console.WriteLine("Empate!");
                    }
                    else if ((escolhaUsuario == "pedra" && escolhaComputador == "tesoura") || 
                             (escolhaUsuario == "papel" && escolhaComputador == "pedra") ||
                             (escolhaUsuario == "tesoura" && escolhaComputador == "papel")) 
                    {
                        Console.WriteLine("Voce ganhou!");
                    }
                    else
                    {
                        Console.WriteLine("Voce perdeu!");
                    }
                }
                else
                {
                    Console.WriteLine("Opcao invalida! Tente novamente!");
                }

                Console.WriteLine("Deseja jogar novamente? (s/n)");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "s");

            Console.WriteLine("Obrigado por jogar!");
        }
    }
}
