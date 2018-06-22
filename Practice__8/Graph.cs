using System;

namespace Practice__8
{
    class Graph
    {
        public int[,] Matrix { get; }
        public int Count { get; }
        public Graph(int count, string[] input)
        {
            Count = count;
            Matrix = new int[count, count];
            foreach (string edge in input)
            {
                Matrix[Convert.ToInt32(Char.ToString(edge[0])), Convert.ToInt32(Char.ToString(edge[1]))] = 1;
                Matrix[Convert.ToInt32(Char.ToString(edge[1])), Convert.ToInt32(Char.ToString(edge[0]))] = 1;
            }
        }
    }
}
