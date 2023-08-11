internal class Program
{
    private static void Main()
    {
        Menu();
    }

    static void Menu()
    {

        var selector = new List<Action>()
        {
            Sum,
            Subtraction,
            Division,
            Multiplication
        };

        int operation = 1;
        while (operation >= 0)
        {
            Console.Clear();

            Console.WriteLine("Selecione o número da operação a ser realizada");
            Console.WriteLine("1 - Adição ");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão ");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5-  Sair");
            try
            {
                string input = Console.ReadLine()!;
                operation = int.Parse(input);

                if (operation == 5) break;

                if (operation < 1 || operation > selector.Count + 1)
                {
                    Console.WriteLine("Opção Invalída");

                }

                selector[operation - 1]();
            }
            catch (Exception ex)
            {

            }
        }
    }
    static void Sum()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor:  ");
        var v1 = Console.ReadLine();

        Console.WriteLine("Segundo valor: ");
        var v2 = Console.ReadLine();

        if (string.IsNullOrEmpty(v1) || string.IsNullOrEmpty(v2))
        {
            Console.WriteLine("Tipo de entrada inválida");
            return;
        }

        double n1 = double.Parse(v1);
        double n2 = double.Parse(v2);
        Console.WriteLine(" ");

        Console.WriteLine($"O resultado da soma é {n1 + n2}");
        Console.ReadKey();
    }

    static void Subtraction()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor:  ");
        var v1 = Console.ReadLine();

        Console.WriteLine("Segundo valor:  ");
        var v2 = Console.ReadLine();

        if (string.IsNullOrEmpty(v1) || string.IsNullOrEmpty(v2))
        {
            Console.WriteLine("Tipo de entrada inválida");
            return;
        }

        double n1 = double.Parse(v1);
        double n2 = double.Parse(v2);


        Console.WriteLine(" ");

        Console.WriteLine($"O resultado da subtração é {n1 - n2}");
        Console.ReadLine();
    }

    static void Division()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        var v1 = Console.ReadLine();

        Console.WriteLine("Segundo valor: ");
        var v2 = Console.ReadLine();

        if (string.IsNullOrEmpty(v1) || string.IsNullOrEmpty(v2))
        {
            Console.WriteLine("Tipo de entrada inválida");
            return;
        }

        double n1 = double.Parse(v1);
        double n2 = double.Parse(v2);

        Console.WriteLine(" ");

        Console.WriteLine($"O resultado da divisão é {n1 / n2}");
        Console.ReadKey();
    }

    static void Multiplication()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        var v1 = Console.ReadLine();

        Console.WriteLine("Segundo valor: ");
        var v2 = Console.ReadLine();

        if (string.IsNullOrEmpty(v1) || string.IsNullOrEmpty(v2))
        {
            Console.WriteLine("Tipo de entrada inválida");
            return;
        }

        double n1 = double.Parse(v1);
        double n2 = double.Parse(v2);

        Console.WriteLine(" ");

        Console.WriteLine($"O resultado da Multiplição é {n1 * n2}");
        Console.ReadKey();
    }


}
