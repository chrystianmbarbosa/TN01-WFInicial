namespace CEx9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome do usuário:");
            string nomeUsuario = Console.ReadLine()!;
            Console.Write("\nInforme a senha do usuário:");
            string senhaUsuario = Console.ReadLine()!;

            while (nomeUsuario == senhaUsuario)
            {
                Console.Write("Senha inválida! Informe novamente a senha:");
                senhaUsuario = Console.ReadLine()!;
            }

            Console.WriteLine("Passou!");
        }
    }
}
