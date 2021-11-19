using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20_11
{
    class MyHandballGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"В центре арены рассыпаны мячи, которые участники команды {name} будут пытаться забросить в ворота соперника");
            Console.WriteLine("Свои ворота защищают атлеты в костюмах-перчатках, задачи которых, отражать мячи от ворот");
            Console.WriteLine("Но, а мешать всему процессу будет разъярённый бык");
            Console.WriteLine("Задача участников: забросить как можно больше мячей в ворота. Команда, забросившая больше всего мячей за отведённое время — побеждает!");
        }
    }
}
