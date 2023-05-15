using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using visualisesort.options;

namespace visualisesort.entity
{
    public class element
    {
        public Point Start { get; set; }

        public Point End { get; set; }

        public int Value { get; set; }
        public element(Point start, Point end, int value)
        {
            Start = start;
            End = end;
            Value = value;
        }
        public element Clone() => new element(Start, End, Value);

        public void Draw(Graphics graphic)
        {
                var pen = new Pen(Color.MediumOrchid, arrayoptions.Width);
               // graphic.DrawLine(pen, Start, End);
            
        }

        public void Eraser(Graphics graphic)
        {
            var pen = new Pen(Color.White, arrayoptions.Width);
          //  graphic.DrawLine(pen, Start, End);
        }

        public void Selected(Graphics graphic)
        {
            var pen = new Pen(Color.MediumPurple, arrayoptions.Width);
           // graphic.DrawLine(pen, Start, End);
        }
    }
}

