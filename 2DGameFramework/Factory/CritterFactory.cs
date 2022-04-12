using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DGameFramework.Interface;
using _2DGameFramework.Model.Creatures;

namespace _2DGameFramework.Factory
{
    public class CritterFactory : IFactory
    {
        public ICreature GetCreature(RaceType typeOfRace)
        {
            return new Critter();
        }
    }
}
