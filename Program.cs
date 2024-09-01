namespace Algorithmic
{
    internal class Program
    {
        static void Main(String[] args)
        {
            int[] num = { 3, 1, 5, 2, 7, 4, 0 };

           /* for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = 0; j < num.Length - 1 - i; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        int temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }*/
/*            Console.WriteLine(string.Join(", ", num));
*/
            for (int i = 0; i < num.Length - 1; ++i)
            {
                for(int j = 0; j < num.Length - 1 - i - 1; ++j)
                {
                    if (num[j]  < num[j + 1])
                    {
                        int temp = num[j];
                        num[j ] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", num));




        }


    }
}

    

