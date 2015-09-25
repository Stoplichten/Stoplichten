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

        Roads R;

        Cars C;

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

            C = new Cars(GraphicsDevice);

            R = new Roads(GraphicsDevice);

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

            R.Update(gameTime);

            C.Update(gameTime);


           /*List<GameObject> test = controller.checkCollision(C[0]);

            if (test != null)
            {
                
             //   if (lastDirection != null) { lastDirection.color = Color.Orange; }
             //   a = r.Next(test.Count);
             //   ball.angle = MathHelper.ToDegrees((float)Math.Atan2((test[a].rectangle.Y + (test[a].rectangle.Height / 2)) - (ball.rectangle.Y + (ball.rectangle.Height / 2)), (test[a].rectangle.X + (test[a].rectangle.Width / 2)) - (ball.rectangle.X + (ball.rectangle.Width / 2))));
             //   test[a].color = Color.White;
              //  lastDirection = (Block)test[a];
            }*/

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

            R.Draw(spriteBatch);
            C.Draw(spriteBatch);


            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
