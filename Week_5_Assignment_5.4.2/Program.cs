using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace Week_5_Assignment_5._4._2
{
    internal class Program
    {
        //Write a C# Sharp program to find the sum of the right diagonals of a matrix.
        //Test Data :
        //Input the size of the square matrix : 2
        //Input elements in the first matrix :
        //element - [0],[0] : 1
        //element - [0],[1] : 2
        //element - [1],[0] : 3
        //element - [1],[1] : 4
        //Expected Output :
        //The matrix is :
        //1 2
        //3 4
        //Addition of the right Diagonal elements is :5


        static void Main(string[] args)
        {
            int size = 2;
            int[,] matrix = new int[size, size];

            // Input elements of the matrix
            Console.WriteLine("Input elements in the first matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Display the matrix
            Console.WriteLine("The matrix is:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Calculate right diagonal sum
            int rightDiagonalSum = 0;
            for (int i = 0; i < size; i++)
            {
                rightDiagonalSum += matrix[i, i];
            }

            Console.WriteLine("Addition of the right Diagonal elements is: " + rightDiagonalSum);
        }
    }
    }

