using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using InputOutputLib;

namespace Practice__8
{
    class Application
    {
        static void Main(string[] args)
        {
            Graph graph = MakeGraph(Get.Int32("Введите количество вершин графа (нумеруются с нуля): ", 1));
            string status = IsBipartite(graph) ? "является" : "не является";
            Console.WriteLine("Заданный граф {0} двудольным.", status);
            Console.ReadKey();
        }

        private static Graph MakeGraph(int count)
        {
            string[] edges = Get.String("Введите ребра в виде <начало><конец>, разделяя каждое пробелом: ").Split(' ');

            return new Graph(count, edges);
        }

        private static bool IsBipartite(Graph graph)
        {
            int[] marks = new int[graph.Count];

            for (int i = 0; i < graph.Count; i++)
            {
                for (int j = i + 1; j < graph.Count; j++)
                {
                    if (graph.Matrix[i, j] != 0)
                    {
                        if (marks[i] % 2 == marks[j] % 2 && marks[j] != 0)
                            return false;
                        marks[j] = marks[i] + 1;
                    }
                }
            }

            return true;
        }
    }
}
