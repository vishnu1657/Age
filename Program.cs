namespace Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
           
                Console.WriteLine("Enter your age");
                int age = Convert.ToInt32(Console.ReadLine());
                
                if (age > 18)
                {
                    Console.WriteLine("You can drive ");
                }
                else
                {
                    Console.WriteLine("You cant drive ");
                }
            }
        }

    }
}
