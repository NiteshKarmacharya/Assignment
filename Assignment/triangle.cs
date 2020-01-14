using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class triangle:Shape
    {
        int side1, side2, side3;

        public override void set(Color colour, params int[] list)
        {
            //list[0] is x, list[1] is y, list[2] is width, list[3] is height
            base.set(colour, list[0], list[1], list[2]);
            this.side1 = list[2];
            this.side2 = list[3];
            this.side3 = list[4];

        }

        public override void draw(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
