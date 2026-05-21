using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringGenerator
{
    public class Controller
    {
        private Model model;

        public Controller(Model m)
        {
            this.model = m;
        }

        public string Generate()
        {
            Random rng = new Random(model.Seed);

            StringBuilder result = new StringBuilder(model.GetLenght());

            for (int i = 0; i < model.GetLenght(); i++)
            {
                int index = rng.Next(model.GetCharsLenght());
                result.Append(model.GetChars()[index]);
            }

            return result.ToString();
        }

    }
}