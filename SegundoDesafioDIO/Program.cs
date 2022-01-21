using SegundoDesafioDIO;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Serie s = new Serie("Breaking Bad", "Professor de química vende droga", 2015, Genero.Suspense, 001);
            s.ToString();
        }
    }
}