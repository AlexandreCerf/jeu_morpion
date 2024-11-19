using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_Morpion.Interfaces
{
    internal interface IWrite
    {
        public void Write(string feur)
        {
            Console.WriteLine(feur);
        }
        public void WriteLine(string feur)
        {
            Console.WriteLine(feur);
        }
    }
}
