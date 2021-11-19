using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20_11
{
    class MousetrapGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"Участникам команды {name} предстоит пройти испытание!");
            Console.WriteLine("Правила таковы: В костюмах мышей поочерёдно они должны миновать препятствия и попасть в большой кусок сыра, расположенный в центре арены");
            Console.WriteLine("Там они должны взять маленький кусочек сыра и принести его в свой ящик");
            Console.WriteLine("Сложность в том, что по арене расставлены мышеловки");
        }
    }
}
