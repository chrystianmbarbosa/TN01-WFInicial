namespace CEx7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = new string[6];
            double[] precos = new double[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Informe o Nome do {i + 1}º Produto: ");
                produtos[i] = Console.ReadLine()!;
                Console.Write($"Informe o Preço do {i + 1}º Produto: ");
                precos[i] = Convert.ToDouble(Console.ReadLine());
            }

            //Busca o menor preço do vetor
            double precoMaisBarato = precos.Min();
            //Busca o índice do valor do vetor
            int posicaoMaisBarato = Array.IndexOf(precos, precoMaisBarato);
            //Traz o produto pelo indice do valor do produto mais barato
            string produtoMaisBarato = produtos[posicaoMaisBarato];

            Console.WriteLine($@"
                O Produto mais barato é: {produtoMaisBarato}.
                O Valor desse produto é: R$ {precoMaisBarato:F2}
             ");
        }
    }
}
