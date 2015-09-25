using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Stoplichten
{
    class Roads
    {

        List<Road> R;
        int[][] RInfo;


        public Roads(GraphicsDevice g)
        {
            R = new List<Road>(8);
            // LEGEND:
            // North = 0
            // East  = 1
            // South = 2
            // West  = 3

            //Directions, intersection options (3 times), rect x, rect y, rect height, rect width

            //Parts of the road are 10x10 (dynamicly)

            RInfo = new int[20][];

            //TODO: add formulas
            RInfo = new int[][]
            {
                //Road 0
              //  new int[8] {0, 1,2,3, 40, 0,  10, 10 },    // 0 <> 4
              //  new int[8] {0, 1,2,3, 40, 10,  10, 10 },    // 0 <> 4
              //  new int[8] {0, 1,2,3, 40, 20,  10, 10 },    // 0 <> 4
               // new int[8] {0, 1,2,3, 40, 30,  10, 10 },    // 0 <> 4


                //Road 1
                new int[8] {1, 1,2,3, 60, 40, 40, 10 },    // 1 <> 5
                new int[8] {2, 1,2,3, 50, 60, 10, 40 },    // 2 <> 6
                new int[8] {3, 1,2,3, 0,  50, 40, 10 },    // 3 <> 7
                //No traffic lights
                new int[8] {0, 0,0,0, 50, 0,  10, 40 },    // 4 <> 0
                new int[8] {1, 0,0,0, 60, 50, 40, 10 },    // 5 <> 1
                new int[8] {2, 0,0,0, 40, 60, 10, 40 },    // 6 <> 2
                new int[8] {3, 0,0,0, 0,  40, 40, 10 },    // 7 <> 3
            };
            List<int[]> R2 = new List<int[]>();

            int RHeight = 40;
            int RWidth = 40;

            int RIHeight = 40;
            int RIWidth = 40;

            int RAmount = 7;


            //Road 0 dynamicly
            /*for (int i = 0; i < RAmount; i++)
            {
                R2.Add(new int[8] { 0, 1, 2, 3, (RAmount * RWidth * 0) + RAmount * RWidth + (0 * RWidth), (RAmount * RHeight * 0) + i * RHeight, RHeight, RWidth });
                R2.Add(new int[8] { 0, 1, 2, 3, (RAmount * RWidth * 0) + RAmount * RWidth + (1 * RWidth), (RAmount * RHeight * 0) + i * RHeight, RHeight, RWidth });
                R2.Add(new int[8] { 0, 1, 2, 3, (RAmount * RWidth * 0) + i * RWidth, (RAmount * RHeight * 0) + RAmount * RHeight + (0 * RHeight), RHeight, RWidth });
                R2.Add(new int[8] { 0, 1, 2, 3, (RAmount * RWidth * 0) + i * RWidth, (RAmount * RHeight * 0) + RAmount * RHeight + (1 * RHeight), RHeight, RWidth });

                R2.Add(new int[8] { 0, 1, 2, 3, 
                    (RAmount * RWidth * 1) + RAmount * RWidth + (0 * RWidth), 
                    (RAmount * RHeight * 1) + i * RHeight, RHeight, RWidth });
                R2.Add(new int[8] { 0, 1, 2, 3, 
                    (RAmount * RWidth * 1) + RAmount * RWidth + (1 * RWidth), 
                    (RAmount * RHeight * 1) + i * RHeight, RHeight, RWidth });
                R2.Add(new int[8] { 0, 1, 2, 3, 
                    (RAmount * RWidth * 1) + i * RWidth, (RAmount * RHeight * 1) + RAmount * RHeight + (1 * RHeight), RHeight, RWidth });
                R2.Add(new int[8] { 0, 1, 2, 3, 
                    (RAmount * RWidth * 1) + i * RWidth, (RAmount * RHeight * 1) + RAmount * RHeight + (1 * RHeight), RHeight, RWidth });
            }*/
            for (int x = 0; x < RAmount; x++)
            {
                for (int y = 0; y < RAmount; y++)
                {
                    R2.Add(new int[8] { 0, 1, 2, 3, 
                        
                        (RAmount * RWidth * 0) + 
                        RAmount * RWidth + 
                        (0 * RWidth), 
                        
                        (RAmount * RHeight * 0) + y * RHeight, RHeight, RWidth });
                    R2.Add(new int[8] { 0, 1, 2, 3, (RAmount * RWidth * 0) + RAmount * RWidth + (1 * RWidth), (RAmount * RHeight * 0) + y * RHeight, RHeight, RWidth });
                    R2.Add(new int[8] { 0, 1, 2, 3, (RAmount * RWidth * 0) + x * RWidth, (RAmount * RHeight * 0) + RAmount * RHeight + (0 * RHeight), RHeight, RWidth });
                    R2.Add(new int[8] { 0, 1, 2, 3, (RAmount * RWidth * 0) + x * RWidth, (RAmount * RHeight * 0) + RAmount * RHeight + (1 * RHeight), RHeight, RWidth });


                    R2.Add(new int[8] { 0, 1, 2, 3, (RAmount * RWidth * 0) + RAmount * RWidth + (0 * RWidth) + (RIWidth * 0), (RAmount * RHeight * 1) + y * RHeight + (RIHeight * 2), RHeight, RWidth });
                    R2.Add(new int[8] { 0, 1, 2, 3, (RAmount * RWidth * 0) + RAmount * RWidth + (1 * RWidth)+(RIWidth * 0), (RAmount * RHeight * 1) + y * RHeight + (RIHeight * 2), RHeight, RWidth });
                    R2.Add(new int[8] { 0, 1, 2, 3, 
                        (RAmount * RWidth * 1) +
                        x * RWidth+
                        (RIWidth * 2), 
                        
                        (RAmount * RHeight * 0) + 
                        RAmount * RHeight + (0 * RHeight)+ 
                        (RIHeight * 0)
                        
                        , RHeight, RWidth });
                    R2.Add(new int[8] { 0, 1, 2, 3, (RAmount * RWidth * 1) + x * RWidth + (RIWidth * 2), (RAmount * RHeight * 0) + RAmount * RHeight + (0 * RHeight) + (RIHeight * 1), RHeight, RWidth });
                }
            }


            for (int i = 0; i < RInfo.GetLength(0); i++)
            {
                R.Add(new Road(new Rectangle(RInfo[i][4], RInfo[i][5], RInfo[i][6], RInfo[i][7]), g, Color.White));
            }
            foreach (int[] RMini in R2) {
                R.Add(new Road(new Rectangle(RMini[4], RMini[5], RMini[6], RMini[7]), g, Color.Brown));
            }

            

        }

        public void Update(GameTime gameTime)
        {

            foreach (Road RPart in R)
            {
                RPart.Update(gameTime);
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Road RPart in R)
            {
                RPart.Draw(spriteBatch);
            }
        }


    }
}
