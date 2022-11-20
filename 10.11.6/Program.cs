internal class Program
{
    private static void Main(string[] args)
    {
        int[] A = new int[20];
        int[] B = new int[20];

        for (int i = 0; i < A.Length; i++)
        {
            Random rnd = new Random();
            int num = rnd.Next(1337);
            A[i] = num;
        }

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] <= 888)
            {
                B[i] = A[i];
            }
        }

        int a = 0;
        for (int i = 0; i < 19; i++)
        {
            for (int j = i + 1; j < 20; j++)
            {
                if (B[i] < B[j])
                {
                    a = B[i];
                    B[i] = B[j];
                    B[j] = a;
                }
            }
        }

        for (int i = 0; i < 20; i++)
        {
            if (B[i] != 0)
            {
                Console.WriteLine(B[i]);
            }
        }
    }
}
    }
}