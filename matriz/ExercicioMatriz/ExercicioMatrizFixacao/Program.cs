namespace ExercicioMatrizFixacao {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantas linhas terá a matriz?");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas colunas terá a matriz?");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            for (int linha = 0; linha < m; linha++) {
                Console.WriteLine($"Digite os valores da {linha + 1}ª linha: ");
                string[] valores = Console.ReadLine().Split(" ");

                for (int coluna = 0; coluna < n; coluna++) {
                    matriz[linha, coluna] = int.Parse(valores[coluna]);
                }
            }

            Console.Write("Digite um valor existente na matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int linha = 0; linha < m; linha++) {
                for (int coluna = 0; coluna < n; coluna++) {
                    if (matriz[linha, coluna] == x) {

                        Console.WriteLine($"Posição: {linha},{coluna}");
                        if (coluna > 0) {
                            Console.WriteLine("Esquerda: " + matriz[linha, coluna - 1]);
                        }

                        if (linha > 0) {
                            Console.WriteLine("Cima: " + matriz[linha - 1, coluna]);
                        }

                        if (coluna + 1 < n) {
                            Console.WriteLine("Direita: " + matriz[linha, coluna + 1]);
                        }

                        if (linha + 1 < m) {
                            Console.WriteLine("Baixo: " + matriz[linha + 1, coluna]);
                        }
                    }
                }
            }
        }
    }
}
