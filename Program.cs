using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] container = new int[4, 4];
        int value = 1;

        Console.WriteLine("0 = Espaço vazio");
        Console.WriteLine("1 = Alimentos");
        Console.WriteLine("2 = Eletrônicos");
        Console.WriteLine("3 = Produtos Orgânicos");
        Console.WriteLine("4 = Maquinários");
        Console.WriteLine();

        // Preenchendo o pátio dos contêineres
        for (int i = 0; i < 4; i += 2)
        {
            for (int j = 0; j < 4; j += 2)
            {
                for (int k = 0; k < 2; k++)
                {
                    for (int l = 0; l < 2; l++)
                    {
                        if (i + k < 4 && j + l < 4)
                        {
                            container[i + k, j + l] = value;
                        }
                    }
                }
                value++;
            }
        }

        // Zerando a última linha
        for (int j = 0; j < 4; j++)
        {
            container[3, j] = 0;
        }

        Console.WriteLine("Pátio dos contêineres:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(container[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Identificando blocos
        bool[,] visited = new bool[4, 4];
        int blockNumber = 1;

        Console.WriteLine();

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (container[i, j] != 0 && !visited[i, j])
                {
                    int type = container[i, j];
                    List<(int, int)> coordinates = new List<(int, int)>();
                    Queue<(int, int)> queue = new Queue<(int, int)>();

                    queue.Enqueue((i, j));
                    visited[i, j] = true;

                    while (queue.Count > 0)
                    {
                        var (x, y) = queue.Dequeue();
                        coordinates.Add((x, y));

                        for (int dx = -1; dx <= 1; dx++)
                        {
                            for (int dy = -1; dy <= 1; dy++)
                            {
                                if ((dx == 0 || dy == 0) && (dx != 0 || dy != 0))
                                {
                                    int newX = x + dx;
                                    int newY = y + dy;

                                    if (newX >= 0 && newX < 4 && newY >= 0 && newY < 4 &&
                                        !visited[newX, newY] && container[newX, newY] == type)
                                    {
                                        visited[newX, newY] = true;
                                        queue.Enqueue((newX, newY));
                                    }
                                }
                            }
                        }
                    }

                    Console.WriteLine($"Bloco {blockNumber}: Tipo {type}, Coordenadas: [{string.Join(", ", coordinates)}], Quantidade: {coordinates.Count}");

                    blockNumber++;
                }
            }
        }

        Console.WriteLine();

        // Contando o total de contêineres
        int totalContainers = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (container[i, j] != 0)
                {
                    totalContainers++;
                }
            }
        }

        Console.WriteLine($"A quantidade de contêineres totais no pátio é de: {totalContainers}");
    }
}
