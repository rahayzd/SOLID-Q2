using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refactored.Interfaces;

namespace Refactored.Model
{
    public class Zoo
    {
        private readonly List<IAnimalSound> _animals;

        public Zoo()
        {
            _animals = new List<IAnimalSound>
            {
                new Lion(),
                new Elephant(),
                new Giraffe(),
                new Monkey()
            };
        }

        public void MakeAnimalSounds()
        {
            foreach (var animal in _animals)
            {
                animal.MakeSound();
            }
        }
    }
}
