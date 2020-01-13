using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    abstract class Shape : shapes
    {
        protected Color color;
        protected int x, y, z;

        public Shape()
        {
            color = Color.Red;
        }

        public Shape(Color color, int x, int y)
        {

            this.color = color; //shape's colour
            this.x = x; //its x pos
            this.y = y; //its y pos
            //can't provide anything else as "shape" is too general
        }

        public abstract void draw(Graphics g);

        public virtual void set(Color c, params int[] list)
        {
            this.color = c;
            this.x = list[0];
            this.y = list[1];
            this.z = list[2];
        }
    }
}
