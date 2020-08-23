using GUI.GUI__Visual___Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
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
        public Size right_tool_panel_Last_size = new Size();
        bool right_panel_resized = false;


        // Auto Risize Right Tool Panel
        bool auto_Resize_Right_Tool_panel = true;



        // Right Tool Panel Variables
        bool Right_Tool_panel_Is_Resizing = false;



        // Initialize::::################################################
        public Form1()
        {
            InitializeComponent();


            // Paint
            g = workplace_pictureBox.CreateGraphics();
            pen1.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);


            //// Assign Right Panel
            //Resizable_Panel Right_ToolPanel_Resizable = new Resizable_Panel();
            //Right_ToolPanel_Resizable.Right_Tool_Panel = right_tool_panel;
            //this.Controls.Add(Right_ToolPanel_Resizable.Get_Right_Tool_Panel());
            


        }


        



        // Load::::################################################
        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            Resizable_Panel Right_Tool_Panel_Resizable = new Resizable_Panel();
            right_tool_panel = Right_Tool_Panel_Resizable.Get_Right_Tool_Panel();


            // Right Tool PAnel
            // Remove Flickering---------------:::START:::
            typeof(Panel).GetProperty("ResizeRedraw", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(right_tool_panel, true, null);

            typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(right_tool_panel, true, null);

            // Remove Flickering---------------:::END:::
        }









        // TOP MESURING-::::::::::::::::START:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::  
        private void top_mesuring_pictureBox_Paint(object sender, PaintEventArgs e)
        {

            // Ruller - Moving Line Top
            //e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Blue), 7.0f), new Point(ruller_Location.X + 25, 0), new Point(ruller_Location.X + 25, 25));
            e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black), 5.0f), new Point(ruller_Location.X + 25, 0), new Point(ruller_Location.X + 25, 25));
            e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Red), 3.0f), new Point(ruller_Location.X + 25, 0), new Point(ruller_Location.X + 25, 25));


            int everySecond_Num = 0; // Change Color Every Second



            // Draw - "0" --------::START::-----------------------------------
            e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Orange), 2.0f), new Point(0, 0), new Point(8, 8)); // The "\"
            e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Orange), 2.0f), new Point(23, 0), new Point(23, 25)); // The "|"
            e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Orange), 2.0f), new Point(0, 23), new Point(23, 23)); // The "--"

            // Draw Text 
            using (Font font1 = new Font("Verdana", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            {
                PointF pointF = new PointF(8, 5);
                e.Graphics.DrawString("0", font1, Brushes.Orange, pointF);  // The "0"
            }
            
            // Draw - "0" --------::END::-----------------------------------------






            //-------------Draw Small Lines---RED---Horizontal---------------------------------------------------------   
            for (int x1 = 23; x1 < top_mesuring_pictureBox.Width; x1 += 25)
            {
                // Draw Line - Small
                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Red), 1.0f), new Point(x1, 0), new Point(x1, 3)); // Pen is drawing the outter and Brush is filling the inner

            }
            //--------------------------------------------------------------------------------------------




            int buffer_left_corner = 23;

            // Mesure - Horizontal  
            for (int x = 73; x < top_mesuring_pictureBox.Width; x += 50)  // Start at 50px. and draw line every 100px till it reaches the Picturebox end "Lenght"
            {

               
                //Dark Violet
                if (everySecond_Num == 0)
                {

                    //-----------Draw Line - First BLUE-----------------------------------------------------  
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(156, 117, 154)), 1.0f), new Point(x, 0), new Point(x, 10)); // Pen is drawing the outter and Brush is filling the inner


                    // Draw Text 
                    using (Font font1 = new Font("Verdana", 11, FontStyle.Bold, GraphicsUnit.Pixel))
                    {
                        PointF pointF = new PointF(x, 5);
                        e.Graphics.DrawString((x - buffer_left_corner).ToString(), font1, new SolidBrush(Color.FromArgb(156, 117, 154)), pointF);
                    }
                    everySecond_Num ++; // Every Second ++
                    //--------------------------------------------------------------------------------------

                }

                else
                {

                    ////----------------Draw Line - Second - Blue-----------------------------------------  
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(105, 193, 255)), 1.0f), new Point(x, 0), new Point(x, 20)); // Pen is drawing the outter and Brush is filling the inner

                    //// Draw Text 
                    using (Font font1 = new Font("Verdana", 12, FontStyle.Bold, GraphicsUnit.Pixel))
                    {
                        PointF pointF = new PointF(x, 10);
                        e.Graphics.DrawString((x - buffer_left_corner).ToString(), font1, new SolidBrush(Color.FromArgb(105, 193, 255)), pointF);
                    }
                    everySecond_Num = 0; // Every Second = 0
                    ////---------------------------------------------------------------------------------- 

                }

              
            }


           




            // Mesure 100
            //for (int x = 100; x < top_mesuring_pictureBox.Width; x += 100)  // Start at 50px. and draw line every 100px till it reaches the Picturebox end "Lenght"
            //{
            //    g.DrawLine(new Pen(new SolidBrush(Color.Red), 1.0f), new Point(x, 0), new Point(x, 20)); // Pen is drawing the outter and Brush is filling the inner



            //    // Draw "100"
            //    using (Font font1 = new Font("Verdana", 12, FontStyle.Bold, GraphicsUnit.Pixel))
            //    {
            //        PointF pointF = new PointF(x, 10);
            //        e.Graphics.DrawString("100", font1, Brushes.Red, pointF);
            //    }


            //}



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

        // TOP MESURING-:::::::::::::::::END::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::  







        // Left MESURING-::::::::::::::::START:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::  


        //-------------Draw Small Lines---Vertical------------------------------------------------------------   
        private void left_mesuring_pictureBox_Paint(object sender, PaintEventArgs e)
        {

            // Ruller - Moving Line Left
            e.Graphics.DrawLine(new Pen(Color.Black, 10.0f), new Point(0, ruller_Location.Y), new Point(25, ruller_Location.Y));
            e.Graphics.DrawLine(new Pen(Color.Orange, 2.0f), new Point(0, ruller_Location.Y), new Point(25, ruller_Location.Y));




            int every_Second_Vertical = 0;

            // Red small Lines
            for (int y = 24; y < left_mesuring_pictureBox.Height; y += 25)
            {
               e.Graphics.DrawLine(new Pen(Color.Red, 1.0f), new Point(0,y), new Point(5,y));
                 
            }


            // Mesure - Vertical
               for (int y2 = 49; y2 < left_mesuring_pictureBox.Height; y2 += 50)
               {

                   if(every_Second_Vertical == 0)
                   {
                        e.Graphics.DrawLine(new Pen(Color.FromArgb(156, 117, 154), 1.0f), new Point(0, y2), new Point(10 ,y2)); // Line Blue Vertical


                       //// Draw Text - Blue - Vertical
                       using (Font font1 = new Font("Verdana", 11, FontStyle.Bold, GraphicsUnit.Pixel))
                       {

                        System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                        drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;

                        PointF pointF = new PointF(3, y2 );
                        e.Graphics.DrawString((y2 +1).ToString(), font1, new SolidBrush(Color.FromArgb(156, 117, 154)), pointF, drawFormat);

                       }
                        
                        every_Second_Vertical++;   
                   }

                   else
                   {

                       e.Graphics.DrawLine(new Pen(Color.FromArgb(105, 193, 255), 1.0f), new Point(0, y2), new Point(20, y2));


                        // Draw Text  - Green - Vertical
                        using (Font font1 = new Font("Verdana", 12, FontStyle.Bold, GraphicsUnit.Pixel))
                        {   
                            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                            drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
                       
                            PointF pointF = new PointF(8, y2);
                            e.Graphics.DrawString((y2 + 1).ToString(), font1, new SolidBrush(Color.FromArgb(105, 193, 255)), pointF, drawFormat);
                       
                        }
                       

                    every_Second_Vertical = 0;

                   }


               }

  


        }
        // Left MESURING-::::::::::::::::END:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::  






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

            // Ruller Location moves on Mouse Move Top and Left - MesurePictureBoxes
            ruller_Location = new Point(e.X, e.Y );
            top_mesuring_pictureBox.Invalidate();
            left_mesuring_pictureBox.Invalidate();

            isMouseMoving = false;
        }








        // Form Resize
        private void Form1_Resize(object sender, EventArgs e)
        {

            // Auto Resize Right Tool Panel:::::::::::::::::START::::::::::::::::::::::::
            if(auto_Resize_Right_Tool_panel == true)
            {

                if(this.Width <= 800 && right_tool_panel.Width >= 100 && right_panel_resized != true)
                {
                    right_tool_panel_Last_size.Width = right_tool_panel.Width; // Remember last Size
                    right_tool_panel.Width = 90;
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








        //:::::::::::::--RIGHT--TOOL--Panel:::::::::::::::::::START::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::


        // Mouse Down - Right Tool Panel
        private void right_tool_panel_MouseDown(object sender, MouseEventArgs e)
        {
            //Point locationOnForm = control.FindForm().PointToClient( control.Parent.PointToScreen(control.Location));
            if (Cursor.Position.X <= right_tool_panel.Parent.PointToScreen(right_tool_panel.Location).X + 10)
            {
                Right_Tool_panel_Is_Resizing = true;
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.VSplit;
                //Right_Tool_panel_Old_Location = e.Location;
            }
        }









        // Mouse UP - Right Tool Panel
        private void right_tool_panel_MouseUp(object sender, MouseEventArgs e)
        {
            Right_Tool_panel_Is_Resizing = false;
        }








        // Mouse Move - Right Tool Panel
        private void right_tool_panel_MouseMove(object sender, MouseEventArgs e)
        {


            if (Cursor.Position.X <= right_tool_panel.Parent.PointToScreen(right_tool_panel.Location).X + 100) // + 100 so there is not unhook when moving the cursor fast
            {

                // Only Cursor Icon
                if (Cursor.Position.X <= right_tool_panel.Parent.PointToScreen(right_tool_panel.Location).X + 10)
                {
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.VSplit;
                }


                // Resize With Mouse
                if (Right_Tool_panel_Is_Resizing == true)
                {
                    right_tool_panel.Width = right_tool_panel.Width - e.X;
                }
            }


        }









        // PAINT - Right Tool Panel
        private void right_tool_panel_Paint(object sender, PaintEventArgs e)
        {

        

            // Left Border - "Dragger"
            using (Pen Pen_Lb = new Pen(Color.FromArgb(104, 109, 127), 15))
            {
                e.Graphics.DrawLine(Pen_Lb, new Point(0, 0), new Point(0, right_tool_panel.ClientSize.Height));
            }





            //HANDLE -  Right Tool Panel  
            using (Pen Pen_H = new Pen(Color.FromArgb(255, 200, 71), 2))
            {
                e.Graphics.DrawLine(Pen_H, new Point(1, right_tool_panel.ClientSize.Height / 2), new Point(1, right_tool_panel.ClientSize.Height / 2 - 20));
                e.Graphics.DrawLine(Pen_H, new Point(6, right_tool_panel.ClientSize.Height / 2), new Point(6, right_tool_panel.ClientSize.Height / 2 - 20));
                //e.Graphics.DrawLine(Pen_H, new Point(6, right_tool_panel.ClientSize.Height / 2), new Point(6, right_tool_panel.ClientSize.Height / 2 -20) );
            }

            //ControlPaint.DrawBorder(e.Graphics, this.Right_Tool_Panel.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Inset); // Draw Border

        }







        // Size Changed - Right Tool Panel      // Used for removing flickering
        private void right_tool_panel_SizeChanged(object sender, EventArgs e)
        {
          
        }


       



        // Resize - Right Tool Panel 
        private void right_tool_panel_Resize(object sender, EventArgs e)
        {
            
        }

           
        //:::::::::::::--RIGHT--TOOL--Panel:::::::::::::::::::END::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::






        // Follow Line

        //        if(isMouseMoving == false)
        //        {
        //            g.DrawLine(pen1, old, e.Location);
        //        }

        //old = e.Location;



    }
}
