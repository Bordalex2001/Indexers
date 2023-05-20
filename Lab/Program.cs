using System;

namespace Lab
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Class Matrix\n");
            Matrix A = new Matrix(new int[,] { { 10, 17, 24 }, { 24, 36, 13 }, { 50, 29, 42 } });
            Matrix A1 = new Matrix(new int[,] { { 10, 17, 24 }, { 24, 36, 13 }, { 50, 29, 42 } });
            Console.WriteLine(A);
            Console.Write($"Minimum element: {A.GetMinimum()}\nMaximum element: {A.GetMaximum()}");
            Console.WriteLine("\n");
            Matrix B = new Matrix(new int[,] { { 25, 36, 18 }, { 47, 42, 68 }, { 53, 27, 39 } });
            Matrix B1 = new Matrix(new int[,] { { 25, 36, 18 }, { 47, 42, 68 }, { 53, 27, 39 } });
            Console.WriteLine(B);
            Console.Write($"Minimum element: {B.GetMinimum()}\nMaximum element: {B.GetMaximum()}");
            Console.WriteLine("\n");
            Console.WriteLine($"Element by index A[1, 2]: {A[1, 2]}");
            Console.WriteLine($"Element by index B[2, 1]: {B[2, 1]}");
            Console.WriteLine($"Element by index A[0, 1]: {A[0, 1]}");
            Console.WriteLine($"Element by index B[1, 0]: {B[1, 0]}");
            Console.WriteLine("\nMatrix A after setting new values:");
            A[0, 0] = 32;
            A[1, 1] = 81;
            A[2, 2] = 64;
            Console.WriteLine(A);
            Console.WriteLine("Matrix B after setting new values:");
            B[0, 2] = 78;
            B[1, 1] = 113;
            B[2, 0] = 94;
            Console.WriteLine(B);
            /*Console.WriteLine("\n");
            Console.WriteLine("Sum of matrices (A + B):");
            Matrix sum = A + B;
            Console.WriteLine(sum.ToString());
            Console.WriteLine("Difference of matrices (B - A):");
            Matrix difference = B - A;
            Console.WriteLine(difference.ToString());
            Console.WriteLine("Matrix multiplication by number (A * 2):");
            Matrix multByNumberA = A * 2;
            Console.WriteLine(multByNumberA.ToString());
            Console.WriteLine("Matrix multiplication by number (B * 3):");
            Matrix multByNumberB = B * 3;
            Console.WriteLine(multByNumberB.ToString());
            Console.WriteLine("Product of matrices (A * B):");
            Matrix productAB = A * B;
            Console.WriteLine(productAB.ToString());
            Console.WriteLine("Product of matrices (B * A):");
            Matrix productBA = B * A;
            Console.WriteLine(productBA.ToString());
            if (A == B) Console.WriteLine("Matrix A is equal to matrix B\n");
            if (A != B) Console.WriteLine("Matrix A is not equal to matrix B\n");
            Console.WriteLine(A.Equals(A1) ? "Matrix A is equal to matrix A1" : "Matrix A is not equal to matrix A1");
            Console.WriteLine(B.Equals(B1) ? "Matrix B is equal to matrix B1" : "Matrix B is not equal to matrix B1");*/
        }
    }
}