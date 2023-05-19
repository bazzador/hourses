using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace hourses.domain
{
    class Кінь
    {
        public string name;
        public Color color;
        public int speed;
        public int dx;
        public int dy;

        public Кінь(string name, Color color, int dy)
        {
            this.name = name;
            this.color = color;
            this.speed = new Random().Next(5, 10);
            this.dx = 0;
            this.dy = dy;
        }

        public void changePosition(int traceEnd, int timeout)
        {
            if(dx == traceEnd)
            {
                return;
            }
            
            Thread.Sleep(timeout);
            int acceleration = new Random().Next(70, 100) / 100;
            dx += speed * acceleration;
            
            if(dx > traceEnd)
            {
                dx = traceEnd;
            }
        }
    }
}
