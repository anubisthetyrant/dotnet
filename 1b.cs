using System;
namespace arithematicoperationsonmatrices
{
    class ADWIN
    {
        public static void Main()
        {
            Console.Write("Enter the number of rows for matrix 1: ");
            int rows1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns for matrix 1: ");
            int cols1 = Convert.ToInt32(Console.ReadLine());
            int[,] matrix1 = new int[rows1, cols1];
            Console.WriteLine("Enter elements of matrix 1:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write("Element [{0},{1}]: ", i, j);
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Enter the number of rows for matrix 2: ");
            int rows2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns for matrix 2: ");
            int cols2 = Convert.ToInt32(Console.ReadLine());
            if (rows1 != rows2 || cols1 != cols2)
            {
                Console.WriteLine("Matrices are not compatible for addition and subtraction.");
                return;
            }
            int[,] matrix2 = new int[rows2, cols2];
            Console.WriteLine("Enter elements of matrix 2:");
            for (int i = 0; i < rows2; i++)

            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write("Element [{0},{1}]: ", i, j);
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddMatrices(matrix1, matrix2, rows1, cols1);
                    break;
                case 2:
                    SubtractMatrices(matrix1, matrix2, rows1, cols1);
                    break;
                case 3:
                    if (cols1 != rows2)
                    {
                        Console.WriteLine("Matrices are not compatible for multiplication.");
                        return;
                    }
                    MultiplyMatrices(matrix1, matrix2, rows1, cols1, cols2);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        static void AddMatrices(int[,] matrix1, int[,] matrix2, int rows, int cols)
        {
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            Console.WriteLine("Result of addition:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void SubtractMatrices(int[,] matrix1, int[,] matrix2, int rows, int cols)
        {
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            Console.WriteLine("Result of subtraction:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void MultiplyMatrices(int[,] matrix1, int[,] matrix2, int rows1, int cols1, int cols2)
        {
            int[,] result = new int[rows1, cols2];
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            Console.WriteLine("Result of multiplication:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}