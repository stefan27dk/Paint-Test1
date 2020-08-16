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

        Graphics g;
        Pen pen1;

    
        
        public Form1()
        {
            g = panel1.CreateGraphics();
            InitializeComponent();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen1 = new Pen(Color.Red, 10);
            pen1.StartCap = pen1.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }


        // Mouse Move - Panel
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
             
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(pen1, new Point(e.X, e.Y), new Point(e.Location.X -1, e.Location.Y -1));
           
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
