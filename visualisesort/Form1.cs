using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using visualisesort.entity;
using visualisesort.options;

namespace visualisesort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Graphics graphic;
        private List<element> elements = new List<element>();

        private void Form1_Load(object sender, EventArgs e)
        {
            graphic = pnlmoniter.CreateGraphics();
        }

        private void pnlMonitor_Paint(object sender, PaintEventArgs e)
        {
            var rand = new Random();
            int padding = arrayoptions.Padding;

            // create random array
            for (int index = 0; index < arrayoptions.Length; index++)
            {
                var start = new Point(padding, moniteroptions.Height);
                int value = moniteroptions.Height - rand.Next(50) * 10;
                var end = new Point(padding, value);
                var element = new element(start, end, moniteroptions.Height - value);

                elements.Add(element);
                padding += arrayoptions.Width + arrayoptions.Space;
            }

            // draw to panel

            elements.ForEach(c =>
            {
                c.Draw(graphic);
            });
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            // sort
             int loopCount = 10;
             for (int i = 0; i < elements.Count - 1; i++)
             {    
                for (int j = 0; j < elements.Count - 1; j++)
                {
                    if (elements[j].Value > elements[j + 1].Value) 
                       {
                            elementhelper.DrawSwap(elements[j], elements[j + 1], graphic);
                            elementhelper.ElementSwap(elements, j, j + 1);
                       }
                            loopCount++;
                            lblloopcount.Text = loopCount.ToString();
                            lblloopcount.Update();
                }
             }

                     elementhelper.CompletedList(elements, graphic);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
