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
    class Block : Entity
    {
        
        public override void Initialize(ContentManager content, GraphicsDevice graphicsDevice, Vector2 pos, Vector2 s, int gridsize)
        {
            this.graphics = graphicsDevice;

            spriteBatch = new SpriteBatch(graphicsDevice);
            texture = content.Load<Texture2D>(@"Textures\test");

            position = pos;
            size = s;

        }

        public override void Update(GameTime gameTime, Vector2 pos)
        {

        }

       



    }
}
