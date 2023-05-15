using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualisesort.options
{
    public class penoptions
    {
        public static Pen White() => new Pen(Color.White, arrayoptions.Width);

        public static Pen Blue() => new Pen(Color.Aqua, arrayoptions.Width);

        public static Pen MediumOrchid() => new Pen(Color.MediumOrchid, arrayoptions.Width);

        public static Pen MediumPurple() => new Pen(Color.MediumPurple, arrayoptions.Width);
    }
}
