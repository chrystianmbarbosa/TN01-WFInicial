namespace CEx8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string menu = @"
            --------------------------------------------
                1- Somar
                2- Subtrair
                3- Multiplicação
                4- Divisão
                5- Potenciação
                6- Radiciação
            --------------------------------------------
                Selecione uma opção: ";

            Console.Write(menu);
            byte opcao = Convert.ToByte(Console.ReadLine());

            double n1, n2, resultado = 0;
            switch (opcao)
            {
                case 1:
                    Console.Write("\nInforme o 1º Numero: ");
                    n1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nInforme o 2º Numero: ");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    resultado = n1 + n2;

                    Console.WriteLine($"A Soma de {n1} + {n2} = {resultado}");
                    break;

                case 2:
                    Console.Write("\nInforme o 1º Numero: ");
                    n1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nInforme o 2º Numero: ");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    resultado = n1 - n2;

                    Console.WriteLine($"A Subtração de {n1} - {n2} = {resultado}");
                    break;

                case 3:
                    Console.Write("\nInforme o 1º Numero: ");
                    n1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nInforme o 2º Numero: ");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    resultado = n1 * n2;

                    Console.WriteLine($"A Multiplicação de {n1} X {n2} = {resultado}");
                    break;

                case 4:
                    Console.Write("\nInforme o 1º Numero: ");
                    n1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nInforme o 2º Numero: ");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    while (n2 == 0)
                    {
                        Console.Clear();
                        Console.Write("\nInforme novamente o 2º Numero: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                    }

                    resultado = n1 / n2;

                    Console.WriteLine($"A Divisão de {n1} / {n2} = {resultado}");

                    break;

                case 5:
                    Console.Write("\nInforme o 1º Numero: ");
                    n1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nInforme o 2º Numero: ");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    resultado = Math.Pow(n1, n2);

                    Console.WriteLine($"A Potencia de {n1} elevado a {n2} = {resultado}");
                    break;

                case 6:
                    Console.Write("\nInforme o 1º Numero: ");
                    n1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nInforme o 2º Numero: ");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    if (n2 == 0)
                        resultado = 1;
                    else
                        resultado = Math.Pow(n1, (1 / n2));

                    Console.WriteLine($"A Raiz {n2} de {n1} = {resultado}");
                    break;

                default:
                    Console.WriteLine("Operação Inválida");
                    break;
            }
        }
    }
}
