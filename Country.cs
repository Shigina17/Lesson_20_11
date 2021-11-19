using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20_11
{
    class Country
    {
        public string name;

        public Country(string name)
        {
            this.name = name;
        }

        public void ToPlay(IGame game)
        {
            game.Play(name);
        }
    }
}
