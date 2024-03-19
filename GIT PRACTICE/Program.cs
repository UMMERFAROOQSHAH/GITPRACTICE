namespace GIT_PRACTICE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int i = 10;
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            int a = 5;
            int b = 6;
            int z = a + b;
            Console.WriteLine("SUM OF A AND B IS " +z);
            Console.WriteLine("FIBONACCI SERIES:-");
            int n1 = 0, n2 = 1, n3,j;
            Console.WriteLine(n1 + " " + n2 + " ");   
            for (j = 2; j < 5; ++j)    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
    }

