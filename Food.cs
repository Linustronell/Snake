using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    public class Food
    {

        Vector2 _position;
        Random _rand;

        public Food(Random random)
        {
            _position = Vector2.Zero;
            _rand = random;
        }

        public void GenerateFood()
        {

        }
    }
}
