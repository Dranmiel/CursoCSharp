using System;

namespace Decimoquarto {
    class Program {
        static void Main(string[] args) {

            string[] line = Console.ReadLine().Split(' ');
            int linhas = int.Parse(line[0]);
            int colunas = int.Parse(line[1]);

            int[,] mat = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++) {
                string[] leitura = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++) {
                    mat[i, j] = int.Parse(leitura[j]);
                }
            }

            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++) {
                    if (mat[i,j] == numero) {
                        Console.WriteLine("Position {0},{1}:",i,j);
                        if (j>0) {
                            Console.WriteLine("Left: "+ mat[i,j-1]);
                        }
                        if (i>0) {
                            Console.WriteLine("Up: "+mat[i-1,j]);
                        }
                        if (j<colunas-1) {
                            Console.WriteLine("Right: "+mat[i,j+1]);
                        }
                        if (i<linhas-1) {
                            Console.WriteLine("Down: "+mat[i+1,j]);
                        }
                    }
                }
            }

        }
    }
}
