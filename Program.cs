using System.Security.Cryptography.X509Certificates;

namespace ConsoleFib
{

    class Program
    {
        public int results;
        public int fib(int n, bool isList)
        {
            int i;
            int a = 0;
            int b = 1;


            if(isList)
            {
                Console.WriteLine(a);
                for (i = 0; i < n - 1; i++)
                {
                    int val = a + b;
                    a = b;
                    b = val;
                    results = val;
                    Console.WriteLine(val);
                }
            }
            if (!isList) 
            {
                for (i = 0; i < n - 1; i++)
                {
                    int val = a + b;
                    a = b;
                    b = val;
                    results = val;
                }
            }


            return results;

        }
        static void Main(string[] args)
        {

            Program fibonacci = new Program();
            int sum;
            bool ch = true; // add handling to check for null because method wont work if its not assigned here

            
            Console.WriteLine("Enter number:");
            string num = Console.ReadLine();

            

            Console.WriteLine("List or number? (l/n): ");
            string choice = Console.ReadLine();

            if(choice == "l")
            {
                ch = true;
            }
            if(choice == "n")
            {
                ch = false;
            }

           sum = fibonacci.fib(Convert.ToInt32(num), ch);



            if(ch == false)
            {
                Console.WriteLine("Fib is: " + sum);
            }

            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
