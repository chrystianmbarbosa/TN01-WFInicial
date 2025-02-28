namespace CEx6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um formulário que solicite o nome do usuário,
            //o quanto ganha por hora e o número de horas trabalhadas no mês.
            //Calcule o resultado e mostre o nome e o total da renda recebida no mês.

            Console.Write("Informe o seu nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("\nInforme o numero de horas trabalhadas: ");
            int quantidadeHoras = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInforme o valor da hora: ");
            double valorHora = Convert.ToDouble(Console.ReadLine());

            double resultado = valorHora * quantidadeHoras;

            Console.WriteLine($"A renda total de {nome} é R$ {resultado:F2}");

        }
    }
}
