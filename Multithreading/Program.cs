namespace Multithreading;

using System.Threading;
using System;

class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();

        int r = rng.Next(100,500);
        int s = rng.Next(100,200);
        int t = rng.Next(100,500);

        int[,] A = {{1,2},{3,4}};
        int[,] B = {{5,6,7},{8,9,10}};

        int[,] C = new int[r,s];
        int[,] D = new int[s,t];

        PopulateMatrix(C, rng);
        PopulateMatrix(D, rng);

        var watch = System.Diagnostics.Stopwatch.StartNew();
        int[,] mat1 = MatrixMultiplication.SequentialMult(A, B);
        //Print2DMatrix(mat1);
        watch.Stop();
        Console.WriteLine("{0}\n", watch.ElapsedMilliseconds);

        watch = System.Diagnostics.Stopwatch.StartNew();
        int[,] mat2 = MatrixMultiplication.ParallelMult(A, B);
        //Print2DMatrix(mat2);
        watch.Stop();
        Console.WriteLine("{0}\n", watch.ElapsedMilliseconds);


        //Random Matrices
        watch = System.Diagnostics.Stopwatch.StartNew();
        int[,] mat3 = MatrixMultiplication.SequentialMult(C, D);
        //Print2DMatrix(mat3);
        watch.Stop();
        Console.WriteLine("{0}\n", watch.ElapsedMilliseconds);

        watch = System.Diagnostics.Stopwatch.StartNew();
        int[,] mat4 = MatrixMultiplication.ParallelMult(C, D);
        //Print2DMatrix(mat4);
        watch.Stop();
        Console.WriteLine("{0}\n", watch.ElapsedMilliseconds);
    }

    static void Print2DMatrix(int[,] mat){
        Console.WriteLine("{");
        for(int row = 0; row < mat.GetLength(0); row++){
            string printString = "";
            for(int col = 0; col < mat.GetLength(1); col++){
                printString += mat[row, col] + ",";
            }
            Console.WriteLine(printString);
        }
        Console.WriteLine("}");
    }

    static void PopulateMatrix(int[,] mat, Random rng){
        for(int row = 0; row < mat.GetLength(0); row++){
            for(int col = 0; col < mat.GetLength(1); col++){
                mat[row, col] = rng.Next(1,100);
            }
        }
    }
}

class MatrixMultiplication{
    public static int[,] SequentialMult(int[,] matA, int[,] matB){
        if(matA.GetLength(1) != matB.GetLength(0)){
            throw new Exception("Dimensions incompatible");
        }

        int dim = matA.GetLength(1);

        int[,] matC = new int[matA.GetLength(0), matB.GetLength(1)];

        for(int row = 0; row < matC.GetLength(0); row++){
            for(int col = 0; col < matC.GetLength(1); col++){
                for (int i = 0; i < dim; i++){
                    matC[row, col] += matA[row, i] * matB[i, col];
                }
            }
        }

        return matC;
    }

    public static int[,] ParallelMult(int[,] matA, int[,] matB){
        if(matA.GetLength(1) != matB.GetLength(0))
            throw new Exception("Dimensions Incompatible");

        int dim = matA.GetLength(1);

        int[,] matC = new int[matA.GetLength(0), matB.GetLength(1)];

        Thread[] threads= new Thread[matC.Length];

        for(int row = 0; row < matC.GetLength(0); row++){
            for(int col = 0; col < matC.GetLength(1); col++){
                int r = row;
                int c = col;
                Thread t = new Thread(()=>ThreadMult(r, c, dim, matA, matB, matC));
                threads[row*matC.GetLength(1) + col] = t;
                t.Start();
            }
        }

        foreach(Thread t in threads){
            t.Join();
        }

        return matC;
    }

    public static void ThreadMult(int row, int col, int dim, int[,] matA, int[,] matB, int[,] matC){
        //Console.WriteLine("{0}, {1}", matC.GetLength(0), matC.GetLength(1));
        for (int i = 0; i < dim; i++){
            //Console.WriteLine("{0}, {1}, {2}", row, col, i);
            matC[row, col] += matA[row, i] * matB[i, col];
        }
    }
}