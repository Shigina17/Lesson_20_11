using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20_11
{
    class SlidesGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"В финальном конкурсе представителям команды {name} нужно с помощью шеста подняться на вершину горки");
            Console.WriteLine("Благодаря очкам, заработанным в прошлых конкурсах, стартуют участники с разных позиций");
            Console.WriteLine("Представители команды, которые придут первыми, принесут победу всей своей команде в игре");
        }
    }
}
