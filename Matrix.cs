//Author:Nour Omran
using System;
class Matrix
{
    long[,] matrix1 = new long[100, 100];
    long[,] matrix2 = new long[100, 100];
    long[,] matrix3 = new long[100, 100];
    long ro1, co1,ro2,co2;
    public Matrix(long[,] m1, long[,] m2, long r1, long c1 , long r2 ,long c2 )
    {
        matrix1 = m1;
        matrix2 = m2;
        ro1 = r1;
        co1 = c1;
        ro2 = r2;
        co2 = c2;

    }
    static void disply(long[,] dis, long a ,long b  )
    {
        for (int i=0; i < a; i++)
        {
            Console.WriteLine();
            for (int j =0; j< b; j++)
            {
                Console.Write("{0} ", dis[i, j]);
            }

        } 

    }
    public void matrixadd()
    {
        for (int i = 0; i < ro1; i++)
        {
            for (int j = 0; j < co1; j++)
            {
                matrix3[i, j] = matrix1[i, j] + matrix2[i, j];

            }
        }
        disply(matrix3, ro1, co1);
        
    }
    public void matrixsub()
    {
        for (int i = 0; i < ro1; i++)
        {
            for (int j = 0; j < co1; j++)
            {
                matrix3[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        disply(matrix3, ro1, co1);

    }
    public void matrixmul()
    {
        if (co1 != ro2)
        {
            Console.WriteLine("Error! column of first matrix not equal to row of second try agian .");
        }
        else
        {
            for (int i = 0; i < ro1; i++)
            {
                for (int j = 0; j < co2; j++)
                {
                    for (int k = 0; k < co1; k++)
                    {

                        matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
        }
        disply(matrix3, ro1, co1);

    }
    public void matrixtranspose_1()
    {
        for (int i =0; i< ro1; i++)
        {
           for (int j =0; j<co1; j++) {
                matrix3[j, i] = matrix1[i, j];
            }
        }
        disply(matrix3, ro1, co1);

    }
    public void matrixtranspose_2()
    {
        for (int i = 0; i < ro2; i++)
        {
            for (int j = 0; j < co2; j++)
            {
                matrix3[j, i] = matrix2[i, j];
            }
        }
        disply(matrix3, ro2, co2);

    }
    public void matrixabs_1()
    {
        for (int i = 0; i < ro1; i++)
        {
            for (int j = 0; j < co1; j++)
            {
                if (matrix1[i, j] < 0 )
                {
                    matrix1[i, j] *= -1;
                }
            }
        }
        disply(matrix3, ro1, co1);
    }

    public void matrixabs_2()
    {
        for (int i = 0; i < ro2; i++)
        {
            for (int j = 0; j < co2; j++)
            {
                if (matrix2[i, j] < 0)
                {
                    matrix2[i, j] *= -1;
                }
            }
         }
        disply(matrix3, ro1, co1);

    }
    public void strassen ()
    {
        long  p1, p2, p3, p4, p5, p6, p7;
        p1 = (matrix1[0,0] + matrix1[1,1]) * (matrix2[0,0] + matrix2[1,1]);

        p2 = (matrix1[1,0] + matrix1[1,1]) * matrix2[0,0];  

        p3 = matrix1[0,0] * (matrix2[0,1] - matrix2[1,1]);

        p4 = matrix1[1,1] * (matrix2[1,0] - matrix2[0,0]);

        p5 = (matrix1[0,0] + matrix1[0,1]) * matrix2[1,1];

        p6 = (matrix1[1,0] - matrix1[0,0]) * (matrix2[0,0] + matrix2[0,1]);

        p7 = (matrix1[0,1] - matrix1[1,1]) * (matrix2[1,0] + matrix2[1,1]);

        matrix3[0,0] = p1 + p4 + -p5 + p7;

        matrix3[0,1] = p3 + p5;

        matrix3[1,0] = p2 + p4;

        matrix3[1,1] = p1 + p3 - p2 + p6;

        disply(matrix3, ro1, co1);
    }
}

