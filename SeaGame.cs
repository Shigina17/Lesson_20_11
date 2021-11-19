using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20_11
{
    class SeaGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"Участникам команды {name} нужно пройти через препятствия, расположенные на бегущей дорожке, не упав при этом в воду");
            Console.WriteLine("Если участник спрыгивает в воду, он проходит испытание снова, до тех пор пока не получится");
            Console.WriteLine("Больше баллов наберет та команда, которой удастся пройти испытание как можно раньше");
        }
    }
}
