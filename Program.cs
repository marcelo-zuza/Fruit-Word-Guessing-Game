using System.Diagnostics;
using System.Linq;


while(true)
{
    Console.WriteLine("\nHello, welcome to the fruit name guessing game\n");
    Console.Write("\nChoose an option:\n [1] New Game\n [2] Exit\n=> ");
    string option = Console.ReadLine();
    if (option == "2")
    {
        Console.WriteLine("\nGame Over");
        break;
    }else if(option == "1")
    {
        Console.WriteLine("\nLet's start the game:");
        List<string> palavras = new List<string>{"avocado", "grape", "papaya", "cashew", "orange", "watermelon", "coconut", "strawberry", "peach"};
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
        Console.WriteLine("The word has: " + palavra.Length + " letters");

        while(true)
        {
            if(tentativas == 0)
            {
                Console.WriteLine("\nYour attempts are over, GAME OVER\n");
                break;
            }
            else if(letrasRestantes == 0)
            {
                Console.WriteLine("\nCONGRATULATIONS you won! The word is: " + palavra);
                break;
            }
            else
            {
                Console.WriteLine("\n Try to guess a letter\n=> ");
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
                    Console.WriteLine("Congratulations, you got it right! The letter " + letra + " appears " + quantasLetrasAcertou + " times");
                    Console.WriteLine(PalavraAoSeDesvendar);
                    quantasLetrasAcertou = 0;

                    Console.WriteLine("Letras restantes: " + letrasRestantes);
                }
                else
                {
                    Console.WriteLine("You missed, there's no" + letra + " in the word, try again");
                    tentativas--;
                    Console.WriteLine("Remaining attempts: " + tentativas);
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid option, please try again");
    }
}
