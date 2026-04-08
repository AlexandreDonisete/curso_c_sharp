namespace ExercicioMatriz {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantas linhas e colunas terá a matriz?");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int linha = 0; linha < n; linha++) {
                Console.Write($"Entre com os valores da {linha + 1} ª linha: ");
                string[] valores = Console.ReadLine().Split(" ");
                for (int coluna = 0; coluna < n; coluna++) {
                    matriz[linha, coluna] = int.Parse(valores[coluna]);
                }
            }

            Console.WriteLine("Diagonal Principal:");
            for (int i = 0; i < n; i++) {
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();

            int numerosNegativos = 0;

            foreach (var item in matriz) {
                if (item < 0) {
                    numerosNegativos++;
                }
            }

            Console.WriteLine("Números negativos = " + numerosNegativos);
        }
    }
}
