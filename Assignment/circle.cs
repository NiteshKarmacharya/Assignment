using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class circle:Shape
    {
        int radius;

        public override void set(Color colour, params int[] list)
        {
            //list[0] is x, list[1] is y, list[2] is width, list[3] is height
            base.set(colour, list[0]);
            this.radius = list[1];

        }

        public override void draw(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
