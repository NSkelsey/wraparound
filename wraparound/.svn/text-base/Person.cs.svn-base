using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace wraparound
{
    class Person: GameObject
    {
        public Vector2 direction;
        public float movementSpeed;


        public void SetSpeed(float s)
        {
            this.movementSpeed = s;
        }

        public void Move(GameTime gameTime, Vector2 direction)
        {
            position += (float)gameTime.ElapsedGameTime.TotalMilliseconds * movementSpeed * direction;
        }


    }
}
