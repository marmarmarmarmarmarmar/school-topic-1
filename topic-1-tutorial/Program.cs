/* 
Coda | 2024/09/08
Topic 1 - Printing and Comments - Lesson Tutorial
*/

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ze first line"); // The "WriteLine" statements will write these two messages on seperate lines
            Console.WriteLine("ze second line!"); // above
            Console.Write("ze same"); // The "Write" statements will write these messages...
            Console.WriteLine(" line!"); // ...on the same line!

            //Console.WriteLine("comment test"); // This line has two dashes before it, meaning that it is "commented" and will not be processed. Comments are used to write information that should not be processed but may still be relevant or useful, or for testing purposes in which a line should not be executed.

            /* zis is a multi-line comment, put here for testing, and it is...
            very nice, yes yes!*/

            int wait1 = 2000;
            Thread.Sleep(wait1);

            Console.Write("Program...");
            int wait2 = 1500;
            Thread.Sleep(wait2);
            Console.Write(" finished!!!!!!"); // yeah!!!!!!!!!
        }
    }
}