using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refactored.Interfaces;

namespace Refactored.Model
{
    public class Giraffe : IAnimalSound
    {
        public void MakeSound()
        {
            Console.WriteLine("Giraffe Sound");
        }
    }

}
