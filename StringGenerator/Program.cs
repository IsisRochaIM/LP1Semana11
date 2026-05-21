using System;
using System.Text;

namespace StringGenerator
{


    class Program
    {
        static void Main(string[] args)
        {
            string maybeSeed = args[0];
            
            bool sucesso = int.TryParse(maybeSeed, out int seed);
            if(sucesso == false)
            {
                Console.WriteLine("Nope");
            }
            else
            {
                Model m = new Model(seed);
                Controller start = new Controller(m);
                View v = new View(start);

                v.WriteStart();
            }
            
        }
    }
}