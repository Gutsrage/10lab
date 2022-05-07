using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle[] aa = {new Rectangle(155,155,40,50),new Rectangle(95,155,40,50),new Rectangle(80, 130, 130, 100) };
            e.Graphics.DrawRectangles(Pens.Red, aa);

            // Стена
            Point[] bb = {new Point(210,230),new Point(232,208),new Point(232,117),new Point(210,130) };
            e.Graphics.DrawPolygon(Pens.Red, bb);

            //Крыша
            Point[] cc = {new Point(145,65),new Point(80,130),new Point(210,130) };
            e.Graphics.DrawPolygon(Pens.Red, cc);

            // Крыша
            Point[] dd = {new Point(180,65),new Point(232,117),new Point(210,130),new Point(145,65) };
             e.Graphics.DrawPolygon(Pens.Red, dd);

            // окно
            e.Graphics.DrawEllipse(Pens.Red, 130, 90, 30, 30);

            //Труба
            Point[] ff = {new Point(205,70),new Point(205,110),new Point(195,110),new Point(195,70) };
            e.Graphics.DrawPolygon(Pens.Red, ff);

           

        }

    }
}
