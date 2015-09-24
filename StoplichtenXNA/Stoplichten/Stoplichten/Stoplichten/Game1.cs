using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Diagnostics;

namespace Stoplichten
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        List<Road> R;
        int[][] RInfo;

        List<Car> C;
        int[][] CInfo;

        Intersection I;

        List<GameObject> objects;
        Controller controller;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);


            objects = new List<GameObject>();


            //Method of adding Objects to the list that goes to the controller
            //objects.Add(new ClassName());

            controller = new Controller(objects);

            // TODO: use this.Content to load your game content here
            R = new List<Road>(8);
            // LEGEND:
            // North = 0
            // East  = 1
            // South = 2
            // West  = 3

            //Directions, intersection options (3 times), rect x, rect y, rect height, rect width

            //TODO: add formulas
            RInfo =  new int[8][]
            {
                new int[8] {0, 1,2,3, 40, 0,  10, 40 },    // 0 <> 4
                new int[8] {1, 1,2,3, 60, 40, 40, 10 },    // 1 <> 5
                new int[8] {2, 1,2,3, 50, 60, 10, 40 },    // 2 <> 6
                new int[8] {3, 1,2,3, 0,  50, 40, 10 },    // 3 <> 7
                //No traffic lights
                new int[8] {0, 0,0,0, 50, 0,  10, 40 },    // 4 <> 0
                new int[8] {1, 0,0,0, 60, 50, 40, 10 },    // 5 <> 1
                new int[8] {2, 0,0,0, 40, 60, 10, 40 },    // 6 <> 2
                new int[8] {3, 0,0,0, 0,  40, 40, 10 },    // 7 <> 3
            };


            C = new List<Car>(1);
            CInfo = new int[1][]
            {
                new int[8] {2, 0,0,0, 40, 0,  10, 10 } //First car
            //    new int[8] {1, 1,2,3, 60, 40, 40, 10 },   
            };

            for (int i = 0; i < RInfo.GetLength(0); i++){
                R.Add(new Road(new Rectangle(RInfo[i][4], RInfo[i][5], RInfo[i][6], RInfo[i][7]), GraphicsDevice, Color.White));
            }

            for (int i = 0; i < CInfo.GetLength(0); i++)
            {
                C.Add(new Car(new Rectangle(CInfo[i][4], CInfo[i][5], CInfo[i][6], CInfo[i][7]), GraphicsDevice, Color.Red));
            }


            //TODO: put roads in intersection
            //Roads are put in on numerical order
           // I = new Intersection(R);


        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here


            for (int i = 0; i < RInfo.GetLength(0); i++)
            {
                R[i].Update(gameTime);
            }

            for (int i = 0; i < CInfo.GetLength(0); i++)
            {
                C[i].Update(gameTime);
            }


            List<GameObject> test = controller.checkCollision(C[0]);

            if (test != null)
            {
                
             //   if (lastDirection != null) { lastDirection.color = Color.Orange; }
             //   a = r.Next(test.Count);
             //   ball.angle = MathHelper.ToDegrees((float)Math.Atan2((test[a].rectangle.Y + (test[a].rectangle.Height / 2)) - (ball.rectangle.Y + (ball.rectangle.Height / 2)), (test[a].rectangle.X + (test[a].rectangle.Width / 2)) - (ball.rectangle.X + (ball.rectangle.Width / 2))));
             //   test[a].color = Color.White;
              //  lastDirection = (Block)test[a];
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            for (int i = 0; i < RInfo.GetLength(0); i++)
            {
                R[i].Draw(spriteBatch);
            }
            for (int i = 0; i < CInfo.GetLength(0); i++)
            {
                C[i].Draw(spriteBatch);
            }



            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
