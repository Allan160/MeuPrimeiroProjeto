# MeuPrimeiroProjet

![alt text](<execucao do jogo.png>)
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

Comandos basicos do git:

git config: entrar na nuvem

git clone: adicionar o repositorio criado no computador

git status: olhar se teve alteracao no arquivo

git add .: adicionar as mudancas feitas

git push : salvar do computador para nuvem

git log: exibir o historico do seu repositorio

git pull: subir arquivos da nuvem para outro computador

git commit: gravar as alteracoes

git init: inicializar o git