using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringGenerator
{
    public class Model
    {
        private const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        private int length = 16;

        public int Seed{get;set;}

        public Model(int seed)
        {
            Seed = seed;
        }

        public int GetLenght()
        {
            return length;
        }

        public string GetChars()
        {
            return chars;
        }

        public int GetCharsLenght()
        {
            return chars.Length;
        }

    }
}