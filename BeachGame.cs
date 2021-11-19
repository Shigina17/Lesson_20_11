using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20_11
{
    class BeachGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"Участники команды {name} должны найти звезды, спрятанные в песке");
            Console.WriteLine("Продолжительность испытания составит 3 минуты");
            Console.WriteLine("Победит та комнада, которая принесет больше звезд!");
        }
    }
}
