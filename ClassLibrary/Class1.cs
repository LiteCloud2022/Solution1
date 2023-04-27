namespace ClassLibrary
{
    public class Exercise1
    {
        public void DoSequence(int N)
        { 
            for (int n = 0; n < N; n++)
            {
                if ((n+1) == N)
                {
                    Console.Write((n + 1) + ".");
                }
                else
                {
                    Console.Write((n+1) + ", ");
                }
            }
            Console.WriteLine("");
        }
    }

    public class Exercise2
    {
        public void DoRectangle(int N)
        {
            if ((N % 2) == 1)
            {
                for (int n = 0; n < N; n++)
                {
                    if ((N/2) == n)
                    {
                        for (int x = 0; x < N; x++)
                        {
                            if ((N / 2) == x)
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("*");
                            }
                        }
                    }
                    else
                    {
                        for (int x = 0; x < N; x++)
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("N is not odd");
            }
        }
    }
}