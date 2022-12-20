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
        public List<List<Vector2>> _V2;
        KeyboardState currentKeyboardState;
        Keys _keys;
        public Snake()
        {
            _V2 = new List<List<Vector2>>();
            _V2[0].Add(new Vector2(0, 0));
            _keys = Keys.W;
        }
        public void create()
        {
            
            //_V2[0][0].Deconstruct(out float X, out float Y);
            ////_V2[0][1] = new Vector2(X + 50, Y);
            ////_V2[0][2] = new Vector2(X + 50, Y + 50);
            ////_V2[0][3] = new Vector2(X, Y + 50);

        }

        public void Update(KeyboardState KeyboardState)
        {
            currentKeyboardState = KeyboardState;
        }

        public void move()
        {
            if (currentKeyboardState.IsKeyDown(Keys.D))
            {
                List<Vector2> StartV = _V2[0];
                for (int i = 0; i < 4; i++)
                {
                    _V2[0][i].Deconstruct(out float X, out float Y);
                    X = X + 50;
                    _V2[0][i] = new Vector2(X, Y);
                }
                
                for (int i = 1; i < _V2.Count; i++)
                {
                    List<Vector2> CounterV = _V2[i];
                    _V2[i] = StartV;
                    StartV = CounterV;
                }

                _keys = Keys.D;
            }
            if (currentKeyboardState.IsKeyDown(Keys.S))
            {
                List<Vector2> StartV = _V2[0];
                for (int i = 0; i < 4; i++)
                {
                    _V2[0][i].Deconstruct(out float X, out float Y);
                    Y = Y - 50;
                    _V2[0][i] = new Vector2(X, Y);
                }

                for (int i = 1; i < _V2.Count; i++)
                {
                    List<Vector2> CounterV = _V2[i];
                    _V2[i] = StartV;
                    StartV = CounterV;
                }
                _keys = Keys.S;
            }
            if (currentKeyboardState.IsKeyDown(Keys.A))
            {
                List<Vector2> StartV = _V2[0];
                for (int i = 0; i < 4; i++)
                {
                    _V2[0][i].Deconstruct(out float X, out float Y);
                    X = X - 50;
                    _V2[0][i] = new Vector2(X, Y);
                }

                for (int i = 1; i < _V2.Count; i++)
                {
                    List<Vector2> CounterV = _V2[i];
                    _V2[i] = StartV;
                    StartV = CounterV;
                }
                _keys = Keys.A;
            }
            if (currentKeyboardState.IsKeyDown(Keys.W))
            {
                List<Vector2> StartV = _V2[0];
                for (int i = 0; i < 4; i++)
                {
                    _V2[0][i].Deconstruct(out float X, out float Y);
                    Y = Y + 50;
                    _V2[0][i] = new Vector2(X, Y);
                }

                for (int i = 1; i < _V2.Count; i++)
                {
                    List<Vector2> CounterV = _V2[i];
                    _V2[i] = StartV;
                    StartV = CounterV;
                }
                _keys = Keys.W;
            }
            else
            {
                if (_keys == Keys.D)
                {
                    List<Vector2> StartV = _V2[0];
                    for (int i = 0; i < 4; i++)
                    {
                        _V2[0][i].Deconstruct(out float X, out float Y);
                        X = X + 50;
                        _V2[0][i] = new Vector2(X, Y);
                    }

                    for (int i = 1; i < _V2.Count; i++)
                    {
                        List<Vector2> CounterV = _V2[i];
                        _V2[i] = StartV;
                        StartV = CounterV;
                    }
                    _keys = Keys.D;
                }
                if (_keys == Keys.S)
                {
                    List<Vector2> StartV = _V2[0];
                    for (int i = 0; i < 4; i++)
                    {
                        _V2[0][i].Deconstruct(out float X, out float Y);
                        Y = Y - 50;
                        _V2[0][i] = new Vector2(X, Y);
                    }

                    for (int i = 1; i < _V2.Count; i++)
                    {
                        List<Vector2> CounterV = _V2[i];
                        _V2[i] = StartV;
                        StartV = CounterV;
                    }
                }
                if (_keys == Keys.A)
                {
                    List<Vector2> StartV = _V2[0];
                    for (int i = 0; i < 4; i++)
                    {
                        _V2[0][i].Deconstruct(out float X, out float Y);
                        X = X - 50;
                        _V2[0][i] = new Vector2(X, Y);
                    }

                    for (int i = 1; i < _V2.Count; i++)
                    {
                        List<Vector2> CounterV = _V2[i];
                        _V2[i] = StartV;
                        StartV = CounterV;
                    }
                }
                if (_keys == Keys.W)
                {
                    List<Vector2> StartV = _V2[0];
                    for (int i = 0; i < 4; i++)
                    {
                        _V2[0][i].Deconstruct(out float X, out float Y);
                        Y = Y + 50;
                        _V2[0][i] = new Vector2(X, Y);
                    }

                    for (int i = 1; i < _V2.Count; i++)
                    {
                        List<Vector2> CounterV = _V2[i];
                        _V2[i] = StartV;
                        StartV = CounterV;
                    }
                }

            }
        }
        public void extension()
        {
            Vector2 EndOfSnake = _V2[_V2.Count][0];
            Vector2 AlmostEndOfSnake = _V2[_V2.Count - 1][0];
            EndOfSnake.Deconstruct(out float x1, out float y1);
            AlmostEndOfSnake.Deconstruct(out float x2, out float y2);
            float test1 = x1 - x2;
            float test2 = y1 - y2;
            List<Vector2> L = new List<Vector2>();
            if (test1 == 0)
            {
                if (test2 < 0)
                {
                    L.Add(new Vector2(x1, y1 + 1));
                    _V2.Add(L);
                }
                else if (test2 > 0)
                {
                    L.Add(new Vector2(x1, y1 - 1));
                    _V2.Add(L);
                }
            }
            else if (test2 == 0)
            {
                if (test1 < 0)
                {
                    L.Add(new Vector2(x1 + 1, y1));
                    _V2.Add(L);
                }
                else if (test1 > 0)
                {
                    L.Add(new Vector2(x1 - 1, y1));
                    _V2.Add(L);
                }
            }

        }
        
        public int scoreboard()
        {
            return _V2.Count;
        }

        public void AddSnakePart(Food Food, Snake Snoke)
        {
            if (_V2[0][0] == Food._position)
            {
                Snoke.extension();
            }
        }

        public void WallCollison()
        {
            _V2[0][0].Deconstruct(out float X, out float Y);
            if(X < 0 || Y < 0)
            {
                Game1.self.Exit();
            }
        }
    }

}
