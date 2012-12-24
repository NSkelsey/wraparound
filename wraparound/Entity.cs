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
    class Entity
    {
        int gridSize = 20;//this shall be reset
        public bool gridLock = true;
        //if gridLocked it will only draw itself to the nearest grid point square as determined by the variable gridSize in Game1
        public int collisionType = 0;
        /*
        0 - does not detect for collision 
        1 - solid on all sides
        2 - solid on top (i.e, cannot fall through but can jump up through)
        3 - solid on bottom (i.e, cannot jump up through but can fall through)        
          
         
        */
        public int dimensionType = 1;
        /*
        
        1 - single block size
        2 - double block size (vertical), like Mario - may want to make two
        
        
        */
        public SpriteBatch spriteBatch;
        public Vector2 position;

        public Vector2 size;

        public GraphicsDevice graphics;
        public Texture2D texture;

        
        public virtual void Initialize(ContentManager content, GraphicsDevice graphicsDevice, Vector2 pos, Vector2 s, int gridsize)
        {
            gridSize = gridsize;
            this.graphics = graphicsDevice;
            
            spriteBatch = new SpriteBatch(graphicsDevice);
            texture = content.Load<Texture2D>(@"Textures\test");

            position = pos;
            size = s;

        }


        public void setRealX(int x)
        {
            position.X = x;
        }
        public void setRealY(int y)
        {
            position.Y = y;
        }
        public void setGridX(int x)
        {
            position.X = x;
        }
        public void setGridY(int y)
        {

        }


        public virtual void Update(GameTime gameTime, Vector2 pos)
        {

        }

        public virtual void Draw(GameTime gameTime)
        {

            Rectangle rectangle;
            if (gridLock)
            {
                rectangle = new Rectangle((int)(position.X - (position.X / gridSize)), (int)(position.Y - (position.Y / gridSize)), (int)size.X, (int)size.Y);
            }
            else
            {
                rectangle = new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
            }



            spriteBatch.Begin();


            spriteBatch.Draw(texture, rectangle, Color.White);

            spriteBatch.End();
        }



    }
}
