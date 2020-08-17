using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Test1
{
    public partial class Form1 : Form
    {

        public Point current = new Point();
        public Point old = new Point();
        public Pen pen1 = new Pen(Color.Red, 5);
        public Graphics g;
        public bool isMouseMoving = false;
        



        // Initialize
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            pen1.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
        }





        // Load
        private void Form1_Load(object sender, EventArgs e)
        {

        }





        // Mouse Move - Panel
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            isMouseMoving = true;

            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                g.DrawLine(pen1, old, current);
                old = current;
            }

            isMouseMoving = false;

        }



     
     



        // Mouse Down
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if(isMouseMoving == false)
            {
                g.DrawLine(pen1, e.Location, new Point(e.Location.X-10, e.Location.Y-10));
            }

            old = e.Location;
        }




    }
}
