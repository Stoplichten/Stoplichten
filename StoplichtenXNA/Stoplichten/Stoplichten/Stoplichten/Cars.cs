using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Stoplichten
{
    class Cars
    {
        List<Car> C;
        int[][] CInfo;

        public Cars(GraphicsDevice g)
        {
            C = new List<Car>(1);
            CInfo = new int[1][]
            {
                new int[8] {2, 0,0,0, 40, 0,  10, 10 } //First car
            //    new int[8] {1, 1,2,3, 60, 40, 40, 10 },   
            };



            for (int i = 0; i < CInfo.GetLength(0); i++)
            {
                C.Add(new Car(new Rectangle(CInfo[i][4], CInfo[i][5], CInfo[i][6], CInfo[i][7]), g, Color.Red));
            }
        }

        public void Update(GameTime gameTime)
        {
            for (int i = 0; i < CInfo.GetLength(0); i++)
            {
                C[i].Update(gameTime);
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < CInfo.GetLength(0); i++)
            {
                C[i].Draw(spriteBatch);
            }

        }
    }
}
