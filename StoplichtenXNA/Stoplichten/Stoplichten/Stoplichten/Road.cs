using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Stoplichten
{
    // 1 is right
    // 2 is straight
    // 3 is left

    
    class Road : GameObject
    {
        Texture2D RTexture;

        public Road(Rectangle rectangle, GraphicsDevice g, Color color)
            : base(rectangle, color)
        {
            RTexture = new Texture2D(g, 1, 1);
            RTexture.SetData(new[] { Color.White });
            this.rectangle = rectangle;
            this.color = color;
            this.texture = RTexture;
            this.currentRotation = 0f;
        }
        public void Update(GameTime gameTime)
        {
            return;
        }

       /* public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(RTexture, base.rectangle, base.color);

        }*/


    }
}
