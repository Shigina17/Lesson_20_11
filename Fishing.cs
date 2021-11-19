using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20_11
{
    class FishingGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"Участникам команды {name} предстоит наловить как можно больше рыб, стоя на крутящемся колесе");
            Console.WriteLine("На испытание дается 3 минуты");
        }
    }
}
