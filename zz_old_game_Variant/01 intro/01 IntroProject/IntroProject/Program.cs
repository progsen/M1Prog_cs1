﻿
namespace IntroProject
{
    internal class Program
    {
        string myDisplayName;
        int myAge;
        static void Main(string[] args)
        {
            Program myProgram= new Program();
            myProgram.Run();
             
        }

        internal Program()
        {
            //1) ken waardes toe aan de variabelen (assignement (=))
            myDisplayName =???;
            myAge = ???;//hier stellen we de leeftijd in
        }

        private void Run()
        {
            Console.WriteLine("hello!, let me introduce myself");
            Console.WriteLine("i'm "+ myDisplayName);

            //2) vraag de waarde van myAge waar de vraagtekens staan
            string myAgeSentance = "i'm " + ??? +" years old";
            Console.WriteLine(???);//3) gebruik hier myAgeSentance 

        }
    }
}
