using System;

namespace Declare_and_use_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            string aFriend = "Bill";
            // Console.WriteLine("Hello " + aFriend);
            Console.WriteLine($"Hello {aFriend}");
            aFriend = "Maria";
            Console.WriteLine(aFriend);
        }
    }
}
