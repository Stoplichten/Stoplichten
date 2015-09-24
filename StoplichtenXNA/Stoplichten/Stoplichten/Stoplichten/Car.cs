using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Stoplichten
{
    class Car : GameObject
    {
        Texture2D CTexture;
        Rectangle CRectangle;


        public Car(Rectangle rectangle, GraphicsDevice g, Color color) : base(rectangle, color) {
            CTexture = new Texture2D(g, 1, 1);

            CTexture.SetData(new[] { color });
            this.rectangle = rectangle;
            this.color = color;
            this.texture = CTexture;
            CRectangle = this.rectangle;
            this.currentRotation = 0f;


        }
        public void Update(GameTime gameTime)
        {
            //Console.WriteLine(gameTime.ElapsedGameTime.Milliseconds);
            
          //  CRectangle.Y += (int)(0.2f * gameTime.ElapsedGameTime.Milliseconds);




            if (this.rectangle.Y >= 50)
            {
                this.Right(gameTime);
            }
            else
            {
                this.Down(gameTime);
            }

            

         //   base.rectangle = CRectangle;
        }

     /*   public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(CTexture, base.rectangle, base.color);

        
        }*/
    }
}
