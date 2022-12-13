using Microsoft.VisualBasic.Devices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using SharpDX.MediaFoundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {
        public List<Vector2> _V2;
        KeyboardState currentKeyboardState;
        Keys _keys;
        public Snake(List<Vector2> V2)
        {
            _V2 = V2;
            
        }
        public void move()
        {
            
            if (currentKeyboardState.IsKeyDown(Keys.D))
            {
                Vector2 StartV = _V2[0];
                _V2[0].Deconstruct(out float X, out float Y);
                X++;
                _V2[0] = new Vector2(X, Y);
                
                for (int i = 1; i < _V2.Count; i++)
                {
                    Vector2 CounterV = _V2[i];
                    _V2[i] = StartV;
                    StartV = CounterV;
                }
                _keys = Keys.D;
            }
            if (currentKeyboardState.IsKeyDown(Keys.A))
            {
                Vector2 StartV = _V2[0];
                _V2[0].Deconstruct(out float X, out float Y);
                X--;
                _V2[0] = new Vector2(X, Y);

                for (int i = 1; i < _V2.Count; i++)
                {
                    Vector2 CounterV = _V2[i];
                    _V2[i] = StartV;
                    StartV = CounterV;
                }
                _keys = Keys.A;
            }
            if (currentKeyboardState.IsKeyDown(Keys.W))
            {
                Vector2 StartV = _V2[0];
                _V2[0].Deconstruct(out float X, out float Y);
                Y++;
                _V2[0] = new Vector2(X, Y);

                for (int i = 1; i < _V2.Count; i++)
                {
                    Vector2 CounterV = _V2[i];
                    _V2[i] = StartV;
                    StartV = CounterV;
                }
                _keys = Keys.W;
            }
            if (currentKeyboardState.IsKeyDown(Keys.S))
            {
                Vector2 StartV = _V2[0];
                _V2[0].Deconstruct(out float X, out float Y);
                Y--;
                _V2[0] = new Vector2(X, Y);

                for (int i = 1; i < _V2.Count; i++)
                {
                    Vector2 CounterV = _V2[i];
                    _V2[i] = StartV;
                    StartV = CounterV;
                }
                _keys = Keys.S;
            }
            else
            {
                if (_keys == Keys.D)
                {
                    Vector2 StartV = _V2[0];
                    _V2[0].Deconstruct(out float X, out float Y);
                    X++;
                    _V2[0] = new Vector2(X, Y);

                    for (int i = 1; i < _V2.Count; i++)
                    {
                        Vector2 CounterV = _V2[i];
                        _V2[i] = StartV;
                        StartV = CounterV;
                    }
                }
                if (_keys == Keys.A)
                {
                    Vector2 StartV = _V2[0];
                    _V2[0].Deconstruct(out float X, out float Y);
                    X--;
                    _V2[0] = new Vector2(X, Y);

                    for (int i = 1; i < _V2.Count; i++)
                    {
                        Vector2 CounterV = _V2[i];
                        _V2[i] = StartV;
                        StartV = CounterV;
                    }
                }
                if (_keys == Keys.W)
                {
                    Vector2 StartV = _V2[0];
                    _V2[0].Deconstruct(out float X, out float Y);
                    Y++;
                    _V2[0] = new Vector2(X, Y);

                    for (int i = 1; i < _V2.Count; i++)
                    {
                        Vector2 CounterV = _V2[i];
                        _V2[i] = StartV;
                        StartV = CounterV;
                    }
                }
                if (_keys == Keys.S)
                {
                    Vector2 StartV = _V2[0];
                    _V2[0].Deconstruct(out float X, out float Y);
                    Y--;
                    _V2[0] = new Vector2(X, Y);

                    for (int i = 1; i < _V2.Count; i++)
                    {
                        Vector2 CounterV = _V2[i];
                        _V2[i] = StartV;
                        StartV = CounterV;
                    }
                }
            }
        }
        public void extension()
        {
            Vector2 EndOfSnake = _V2[_V2.Count];
            Vector2 AlmostEndOfSnake = _V2[_V2.Count - 1];
            EndOfSnake.Deconstruct(out float x1, out float y1);
            AlmostEndOfSnake.Deconstruct(out float x2, out float y2);
            float test1 = x1 - x2;
            float test2 = y1 - y2;
            if(test1 == 0)
            {
                if(test2 < 0)
                {
                    _V2.Add(new Vector2(x1, y1 - 1));
                }
                else
                {
                    _V2.Add(new Vector2(x1, y1 + 1));
                }
            }
            if(test2 == 0)
            {

            }
            
        }
        
        public int scoreboard()
        {
            return 1;
        }
    }

}
