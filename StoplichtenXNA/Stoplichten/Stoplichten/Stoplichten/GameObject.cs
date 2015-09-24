using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Stoplichten
{
    class GameObject
    {

        public float currentRotation
        {
            get { return _currentRotation; }
            set { _currentRotation = value; }
        }

        private float _currentRotation;

        private Rectangle _rectangle;

        public Rectangle rectangle
        {
            get { return _rectangle; }
            set { _rectangle = value; }
        }

        public Color color
        {
            get { return _color; }
            set { _color = value; }
        }

        private Color _color;

        private GameTime _gameTime;

        public GameTime gameTime
        {
            get { return _gameTime; }
            set { _gameTime = value; }
        }

        private SpriteBatch _spriteBatch;

        public SpriteBatch spriteBatch
        {
            get { return _spriteBatch; }
            set { _spriteBatch = value; }
        }
        private Texture2D _texture;

        public Texture2D texture
        {
            get { return _texture; }
            set { _texture = value; }
        }

        public GameObject(Rectangle rectangle, Color color)
        {
            this._rectangle = rectangle;
            this._color = color;
        }

        public GameObject(Rectangle rectangle)
        {
            this._rectangle = rectangle;
        }

        public void Up(GameTime gameTime)
        {
            _rectangle.Y -= (int)(0.2f * gameTime.ElapsedGameTime.Milliseconds);
        }


        public void Down(GameTime gameTime)
        {
            _rectangle.Y += (int)(0.2f * gameTime.ElapsedGameTime.Milliseconds);
        }

        public void Left(GameTime gameTime)
        {
            _rectangle.X -= (int)(0.2f * gameTime.ElapsedGameTime.Milliseconds);
        }
        public void Right(GameTime gameTime)
        {
            _rectangle.X += (int)(0.2f * gameTime.ElapsedGameTime.Milliseconds);
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _rectangle,null, _color,currentRotation,new Vector2(0,0),SpriteEffects.None,0f);
            return;
        }


      /*  internal void Update(GameTime gameTime)
        {
           
        }*/
    }
}
