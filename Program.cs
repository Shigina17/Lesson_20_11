using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Country[] teams = {
                new Country("Russia"),
                new Country("France"),
                new Country("China"),
                new Country("Ukraine")
            };

            foreach(Country country in teams)
            {
                country.ToPlay(new MyHandballGame());
                country.ToPlay(new SeaGame());
                country.ToPlay(new FishingGame());
                country.ToPlay(new MousetrapGame());
                country.ToPlay(new BeachGame());
                country.ToPlay(new PostmenGame());
                country.ToPlay(new SlidesGame());
            }
            Console.WriteLine("Победила Росиия!");
            Console.ReadKey();
        }
    }
}
