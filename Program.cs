// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Linq;

Console.WriteLine("Hello, World!");

while(true)
{
    Console.WriteLine("\nOlá, seja bem vindo ao jogo de adivinhação de palavras\n");
    Console.Write("\nEscola uma opção:\n [1] Novo Jogo\n[2] Sair");
    string option = Console.ReadLine();
    if (option == "2")
    {
        Console.WriteLine("\nFim de jogo");
        break;
    }else if(option == "1")
    {
        Console.WriteLine("\nVamos começar o jogo:");
        string palavra = "banana";
        char[] arrayDeLetras = palavra.ToCharArray();
        int letrasRestantes = palavra.Length;
        
        int tentativas = 5;
        Console.WriteLine("A palavra tem: " + palavra.Length + " Letras");

        while(true)
        {
            if(tentativas == 0)
            {
                Console.WriteLine("\nSua tentativas acabaram, GAME OVER\n");
                break;
            }
            else if(letrasRestantes == 0)
            {
                Console.WriteLine("\nPARABÉNS você venceu! A palavra é: " + palavra);
            }
            else
            {
                Console.WriteLine("\n Tente adivinhar uma letra\n");
                string letra = Console.ReadLine();
                char[] PalavraAoSeDesvendar = new char[palavra.Length];
                for(int a = 0; a < palavra.Length; a++)
                {
                    PalavraAoSeDesvendar[a] = '_';
                }

                if(arrayDeLetras.Contains(char.Parse(letra)))
                {
                    arrayDeLetras.ToList().ForEach(letraDaPalavra =>
                    {
                        if(letraDaPalavra == char.Parse(letra))
                        {
                            int index = palavra.IndexOf(letraDaPalavra);
                            PalavraAoSeDesvendar[index] = letraDaPalavra;
                        }
                    });
                    Console.WriteLine("Parabéns, você acertou uma letra");
                    Console.WriteLine(PalavraAoSeDesvendar);

                    letrasRestantes--;
                    Console.WriteLine("Letras restantes: " + letrasRestantes);
                }
                else
                {
                    Console.WriteLine("Você errou, tente novamente");
                    tentativas--;
                    Console.WriteLine("Tentativas restantes: " + tentativas);
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Opção inválida, tente novamente");
    }
}
