using ConsoleApp3;
using System;

namespace OOP2V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("Securing class from outside impact", "You shold not give the abilitty to set the VOte property from outside becauuse otherwise", "5.3.2022");
            Console.WriteLine(post.ToString());
            for(int i = 0; i < 10; i++)
            {
                post.Upvote();
            }
            for(int i = 0;i < 10;i++) {
                post.Downvote();
            }

            Console.WriteLine(post.ToString());
             Console.ReadLine();
        }
    }
}