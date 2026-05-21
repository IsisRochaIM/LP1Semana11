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
            if(sucesso)
            {
                Model m = new Model(seed);
                Controller start = new Controller(m);
                View v = new View(start);

                v.WriteStart();
            }
            else
            {
                Model m = new Model(1);
                Controller start = new Controller(m);
                View v = new View(start);
                v.Error();
            }
            
        }
    }
}