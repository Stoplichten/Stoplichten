using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Stoplichten
{
    class Car
    {
        int[] CInfo;
        Rectangle CRect;
        Texture2D CTexture;




        public Car(int[] CInfo, GraphicsDevice g) {
            this.CInfo = CInfo;
            CRect = new Rectangle(CInfo[4], CInfo[5], CInfo[6], CInfo[7]);
            CTexture = new Texture2D(g, 1, 1);

            CTexture.SetData(new[] { Color.White });


        }
        public void Update(GameTime gameTime)
        {
            
            CRect.Y += 1 * gameTime.ElapsedGameTime.Milliseconds;
            return;
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(CTexture,CRect,Color.Red);

        
        }
    }
}
