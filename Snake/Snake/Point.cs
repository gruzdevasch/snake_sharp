using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Snake
{
    class Point
    {
        private int x;
        private int y;
        public char sym;
        public Point()
        {
        }
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int offset, Direction direction)
        {
            switch (direction) {

                case Direction.RIGHT:
                    x = x + offset;
                    break;
                case Direction.LEFT:
                    x = x - offset;
                    break;
                case Direction.UP:
                    y = y - offset;
                    break;
                case Direction.DOWN:
                    y = y + offset;
                    break;
                default:
                    break;
            }
        }
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }
    }
}
