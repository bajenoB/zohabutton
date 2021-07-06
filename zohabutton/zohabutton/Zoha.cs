using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace zohabutton
{
    public class Zoha : Control
    {
       public Rectangle circle=new Rectangle();
        public Rectangle rect = new Rectangle();

        public Size size { get; set; }

        public Color color { get; set; }
        public Point point { get; set; }
        public Zoha() 
        {
            //point = new Point(0, 0);
            circle = new Rectangle(0, 0,40,40);
            rect = new Rectangle(0, 0, 150, 40);
            //size = new Size(150, 40);
           
        }

        public Zoha(Point p1):this()
        {
            //point = new Point(point.X, point.Y);
            circle = new Rectangle(p1.X, p1.Y, 40, 40);
            rect = new Rectangle(p1.X, p1.Y, 150, 40);
            circle.Location = p1;
            rect.Location = p1;
        }

        public Zoha(Color color): this()
        {
            this.color = color;
        }

        public Zoha(Color color,Point point):this(color)
        {
            this.circle.Location = point;
        }


    }
}
