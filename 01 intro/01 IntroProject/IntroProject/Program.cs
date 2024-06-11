
namespace IntroProject
{
    internal class Program
    {
        int myDisplayName;
        int myAge;
        static void Main(string[] args)
        {
            Program myProgram= new Program();
            myProgram.Run();
             
        }

        internal Program()
        {
            //ken waardes toe aan de variabelen (assignement (=))
            myDisplayName =???;
            myAge = ???;//hier stellen we de leeftijd in
        }

        private void Run()
        {
            Console.WriteLine("hello!, let me introduce myself");
            Console.WriteLine("i'm "+ myDisplayName);

            //vraag de waarde van myAge waar de vraagtekens staan
            string myAgeSentance = "i'm " + ??? +" years old";
            Console.WriteLine(???);//gebruik hier myAgeSentance 

        }
    }
}
