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
        // Paint
        public Point current = new Point();
        public Point old = new Point();
        public Pen pen1 = new Pen(Color.Red, 5);
        public Graphics g;
        public bool isMouseMoving = false;


        // Mesure
        public Point ruller_Location;


        // Right Tool Panel Size
        Size right_tool_panel_Last_size;
        bool right_panel_resized = false;


        // Auto Risize Right Tool Panel
        bool auto_Resize_Right_Tool_panel = true;
           

        // Initialize
        public Form1()
        {
            InitializeComponent();
            // Paint
            g = workplace_pictureBox.CreateGraphics();
            pen1.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
           
        }


        



        // Load
        private void Form1_Load(object sender, EventArgs e)
        {

        }



      
            

          


        // Top mesuring
        private void top_mesuring_pictureBox_Paint(object sender, PaintEventArgs e)
        {
            

           Graphics g = e.Graphics;

              
            for (int x = 50; x < top_mesuring_pictureBox.Width; x += 100)  // Start at 50px. and draw line every 100px till it reaches the Picturebox end "Lenght"
            {
                g.DrawLine(new Pen(new SolidBrush(Color.Red), 3.0f), new Point(x,0), new Point(x,20)); // Pen is drawing the outter and Brush is filling the inner
            }



            //// ----------------
            //Graphics g = e.Graphics;
            //for (int x = 30; x < top_mesuring_pictureBox.Width; x += 100)
            //{
            //    g.DrawLine(new Pen(new SolidBrush(Color.Red), 3.0f), new Point(x, 0), new Point(x, 20));
            //}
            //for (int x = 30; x < top_mesuring_pictureBox.Width; x += 50)
            //{
            //    g.DrawLine(new Pen(new SolidBrush(Color.Blue), 2.0f), new Point(x, 0), new Point(x, 10));
            //}
            //for (int x = 30; x < top_mesuring_pictureBox.Width; x += 10)
            //{
            //    g.DrawLine(new Pen(new SolidBrush(Color.Red), 1.0f), new Point(x, 0), new Point(x, 5));
            //}

            //g.DrawLine(new Pen(new SolidBrush(Color.Red), 2.0f), new Point(ruller_Location.X, 0), new Point(ruller_Location.X, 10));
        }











        // Mouse Down - WORKPLACE
        private void workplace_pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (isMouseMoving == false)
            {
                g.DrawLine(pen1, e.Location, new Point(e.Location.X - 1, e.Location.Y - 1));
            }

            old = e.Location;
        }









        // Mouse Move - WORKPLACE
        private void workplace_pictureBox_MouseMove(object sender, MouseEventArgs e)
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





        // Form Resize
        private void Form1_Resize(object sender, EventArgs e)
        {


            // Auto Resize Right Tool Panel:::::::::::::::::START::::::::::::::::::::::::
            if(auto_Resize_Right_Tool_panel == true)
            {

                if(this.Width <= 800 && right_tool_panel.Width >= 100)
                {
                    right_tool_panel_Last_size = right_tool_panel.Size; // Remember last Size
                    right_tool_panel.Width = 99;
                    right_panel_resized = true;
                }
               
                else if(this.Width >= 800 && right_panel_resized == true)
                {
                    right_tool_panel.Width = right_tool_panel_Last_size.Width;
                    right_panel_resized = false;
                }
            }
            // Auto Resize Right Tool Panel:::::::::::::::::END::::::::::::::::::::::::



        }



        // AutoResize Checked Changed
        private void autoResize_Right_Tool_Panel_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            // Right Tool Panel - Toggle AutoResize:::::::::START::::::::::::
            if(autoResize_Right_Tool_Panel_checkBox.Checked == true)
            {
                auto_Resize_Right_Tool_panel = true;
            }
            else  
            {
                auto_Resize_Right_Tool_panel = false;
            }
            // Right Tool Panel - Toggle AutoResize:::::::::END::::::::::::

        }







        // Follow Line

        //        if(isMouseMoving == false)
        //        {
        //            g.DrawLine(pen1, old, e.Location);
        //        }

        //old = e.Location;



    }
}
