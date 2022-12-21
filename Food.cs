using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using System;
using SharpDX.MediaFoundation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;
using System.Diagnostics;

namespace Snake2
{
    public class Food
    {
        public Vector2 _foodPos;
        Texture2D _appleTexture;

        Random _rand = new Random ();
        MouseState mState;
        bool mRealeased = true;
        int[] positionArray = { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600, 650, 700, 750, 800 };
        
        public Food(Texture2D appleTexture)
        {
            _appleTexture = appleTexture;
        }

        public void Update()
        {
            mState = Mouse.GetState();

            if (mState.LeftButton == ButtonState.Pressed && mRealeased == true)
            {
                float mouseTargetDist = Vector2.Distance(_foodPos, mState.Position.ToVector2());
                if (mouseTargetDist < _appleTexture.Width)
                {
                    _foodPos.X = positionArray[_rand.Next(0, positionArray.Length)];
                    _foodPos.Y = positionArray[_rand.Next(0, positionArray.Length)];
                    Debug.Write(_foodPos);
                }
                mRealeased = false;
            }

            if (mState.LeftButton == ButtonState.Released)
            {
                mRealeased = true;
            }


       
        }

        public void Draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(_appleTexture, _foodPos, null, Color.White, 0f, new Vector2(_appleTexture.Width, _appleTexture.Height), Vector2.One, SpriteEffects.None, 0f);
        }

    }
}

