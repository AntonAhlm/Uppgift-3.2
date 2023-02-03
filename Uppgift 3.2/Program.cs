using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vilka vann fotbolls-VM för damer 2015? : ");
            string svar = Console.ReadLine();
            string svar2 = svar.ToLower();

            if ( svar2 == "usa" )
            {
                Console.WriteLine("Du har rätt :D");
            }

        }
    }
}
