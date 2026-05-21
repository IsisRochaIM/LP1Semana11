using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringGenerator
{
    public class View
    {
        private Controller controller;

        public View (Controller c)
        {
            this.controller = c;
        }

        public void Error()
        {
            Console.WriteLine("Nope");
        }

        public void WriteStart()
        {
            Console.WriteLine(controller.Generate());
        }
    }
}