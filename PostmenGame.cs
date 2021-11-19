using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20_11
{
    class PostmenGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"Участникам команды {name} необходимо перенести письма с одного конца арены на другой");
            Console.WriteLine("На испытание дается всего 3 минут");
            Console.WriteLine("Сложность в том что по арене бегает бык...");
        }
    }
}
