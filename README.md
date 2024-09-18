# MeuPrimeiroProjet

![alt text](<Print do jogo em execucao.png>)

O que e? Jogo de multiplha escolha 

Como funciona? Voce escolhe entre; pedra, papel ou tesoura. Em seguida o computador tambem escolhera uma opcao. 
Pedra quebra tesoura 
Pepel ebrulha pedra
Tesoura corta papel 

Como construir o jogo? 
No site https://dotnetfiddle.net/ use o seguinte codigo c#:

```
using System;

namespace PedraPapelTesoura
{
    class Program
    {
        static void Main(string[] args) // Corrigido 'sting' para 'string'
        {
            Random random = new Random();
            string[] opcoes = { "pedra", "papel", "tesoura" };
            string escolhaUsuario;
            string continuar;

            do
            {
                Console.WriteLine("Escolha uma opcao: pedra, papel ou tesoura");
                escolhaUsuario = Console.ReadLine().ToLower(); // Corrigido 'escolaUsuario' para 'escolhaUsuario'

                if (Array.Exists(opcoes, opcao => opcao == escolhaUsuario))
                {
                    int escolhaComputadorIndex = random.Next(0, 3); // Corrigido 'escolhaCompuradorIdex' para 'escolhaComputadorIndex'
                    string escolhaComputador = opcoes[escolhaComputadorIndex];

                    Console.WriteLine($"O computador escolheu: {escolhaComputador}"); // Corrigido 'escolhaCoputador' para 'escolhaComputador'

                    if (escolhaUsuario == escolhaComputador)
                    {
                        Console.WriteLine("Empate!");
                    }
                    else if ((escolhaUsuario == "pedra" && escolhaComputador == "tesoura") || 
                             (escolhaUsuario == "papel" && escolhaComputador == "pedra") || // Corrigido para 'papel' ganha de 'pedra'
                             (escolhaUsuario == "tesoura" && escolhaComputador == "papel")) // Adicionado caso para 'tesoura'
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
                    Console.WriteLine("Opcao invalida! Tente novamente!"); // Corrigido a estrutura 'else'
                }

                Console.WriteLine("Deseja jogar novamente? (s/n)");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "s");

            Console.WriteLine("Obrigado por jogar!");
        }
    }
}
```