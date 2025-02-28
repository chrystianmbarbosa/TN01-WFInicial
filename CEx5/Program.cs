namespace CEx5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o 1º Número: ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.Write("\nDigite o 2º Número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nDigite o 3º Número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int maior = Math.Max(num1, num2);
            maior = Math.Max(maior, num3);

            int menor = Math.Min(num1, num2);
            menor = Math.Min(menor, num3);

            Console.WriteLine($"\nO Numero {maior} é o maior valor!");
            Console.WriteLine($"\nO Numero {menor} é o menor valor!");
        }
    }
}
