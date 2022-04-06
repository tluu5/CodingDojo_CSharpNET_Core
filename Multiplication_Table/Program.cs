using System;
using System.Text;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var table = BuildTable(10);
            RenderTable(table);
        }
        public static int[,] BuildTable(int size)
        {
            int[,] table = new int[size, size];
            for (var row = 0; row < size; row++)
                for (var col = 0; col < size; col++)
                    table[row, col] = (row + 1) * (col + 1);
            return table;
        }
        public static void RenderTable(int[,] multiArray)
        {
            // StringBuilder class good for mutating strings
            StringBuilder sb = new StringBuilder();

            // gets length of specified dimention of multi array
            int size = multiArray.GetLength(0);

            for (var row = 0; row < size; row++)
            {
                sb.Append("[");
                for (var col = 0; col < size; col++)
                {
                    sb.Append($"{multiArray[row, col]}, ");
                }
                sb.Append("]\n");
            }
            Console.WriteLine(sb);
        }
    }
}
