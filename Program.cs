namespace estudo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1 = "I";
            string num5 = "V";
            string num10 = "X";
            ConsoleKeyInfo denovo;

            do
            {
                Console.Write("Insira um número entre 1 a 10: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0 && numero < 5)
                {
                    Console.Write($"O número {numero} em romanos é: ");
                    for (int i = 0; i < numero; i++)
                    {
                        Console.Write(num1);

                        if (numero == 4)
                        {
                            Console.Write(num5);
                            break;
                        }
                    }
                    Console.Write(".");


                }

                if (numero > 4 && numero < 9)
                {
                    Console.Write($"O número {numero} em romanos é: {num5}");

                    if (numero == 5)
                    {
                        Console.Write(".");
                    }
                    else if (numero > 5 && numero < 9)
                    {
                        for (int j = 0; j < (numero - 5); j++)
                        {
                            Console.Write(num1);
                        }
                        Console.Write(".");
                    }
                }

                if (numero == 10)
                {
                    
                }

                Console.WriteLine();
                Console.WriteLine("Deseja tentar mais uma vez? Se sim, tecle Enter, senão, tecle qualquer outro botão!");
                denovo = Console.ReadKey();
                Console.WriteLine();

            }
            while (denovo.Key == ConsoleKey.Enter);
            
        }
    }
}
