using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_Morpion.Class
{
    internal class Player
    {
        public char CrossOrCircle { get; set; }

        public Player(char crossOrCircle)
        {
            CrossOrCircle = crossOrCircle;
        }
    }
}