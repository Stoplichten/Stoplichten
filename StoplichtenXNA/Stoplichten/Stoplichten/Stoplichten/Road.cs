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

    
    class Road
    {
        int[] RInfo;
        Rectangle RRect;
        Texture2D RTexture;

        public Road(int[] RInfo, GraphicsDevice g) {
            this.RInfo = RInfo;
            RRect = new Rectangle(RInfo[4], RInfo[5], RInfo[6], RInfo[7]);
            RTexture = new Texture2D(g, 1, 1);

            RTexture.SetData(new[] { Color.White });
        }
        public void Update(GameTime gameTime)
        {
            return;
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(RTexture,RRect,Color.Blue);

        }


    }
}
