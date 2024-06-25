// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Linq;

Console.WriteLine("Hello, World!");

while(true)
{
    Console.WriteLine("\nOlá, seja bem vindo ao jogo de adivinhação de palavras de nomes de frutas\n");
    Console.Write("\nEscola uma opção:\n [1] Novo Jogo\n [2] Sair\n=> ");
    string option = Console.ReadLine();
    if (option == "2")
    {
        Console.WriteLine("\nFim de jogo");
        break;
    }else if(option == "1")
    {
        Console.WriteLine("\nVamos começar o jogo:");
        List<string> palavras = new List<string>{"abacate", "uva", "mamao", "caju", "laranja", "melancia", "coco", "morango", "pessego"};
        Random random = new Random();
        int index = random.Next(palavras.Count);
        string palavra = palavras[index];
        char[] arrayDeLetras = palavra.ToCharArray();
        int letrasRestantes = palavra.Length;
        char[] PalavraAoSeDesvendar = new char[palavra.Length];
        for(int a = 0; a < palavra.Length; a++)
        {
            PalavraAoSeDesvendar[a] = '_';
        }
        
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
                break;
            }
            else
            {
                Console.WriteLine("\n Tente adivinhar uma letra\n=> ");
                string letra = Console.ReadLine();

                int quantasLetrasAcertou = 0;


                if (arrayDeLetras.Contains(char.Parse(letra)))
                {
                    for (int i = 0; i < palavra.Length; i++)
                    {
                        if (arrayDeLetras[i] == char.Parse(letra))
                        {
                            PalavraAoSeDesvendar[i] = char.Parse(letra);
                            letrasRestantes--;
                            quantasLetrasAcertou++;

                        }
                    }
                    Console.WriteLine("Parabéns, você acertou, a letra " + letra + " aparece: " + quantasLetrasAcertou + " vezes");
                    Console.WriteLine(PalavraAoSeDesvendar);
                    quantasLetrasAcertou = 0;

                    Console.WriteLine("Letras restantes: " + letrasRestantes);
                }
                else
                {
                    Console.WriteLine("Você errou, não tem " + letra + " na palavra, tente novamente");
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
