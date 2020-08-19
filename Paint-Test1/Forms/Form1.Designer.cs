using GUI.GUI__Visual___Classes;

namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.right_tool_panel = new System.Windows.Forms.Panel();
            this.autoResize_Right_Tool_Panel_checkBox = new System.Windows.Forms.CheckBox();
            this.top_tool_panel = new System.Windows.Forms.Panel();
            this.left_tool_panel = new System.Windows.Forms.Panel();
            this.left_mesuring_pictureBox = new System.Windows.Forms.PictureBox();
            this.top_mesuring_pictureBox = new System.Windows.Forms.PictureBox();
            this.main_holder_panel = new System.Windows.Forms.Panel();
            this.workplace_pictureBox = new System.Windows.Forms.PictureBox();
            this.bottom_info_panel = new System.Windows.Forms.Panel();
            this.right_tool_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.left_mesuring_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top_mesuring_pictureBox)).BeginInit();
            this.main_holder_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workplace_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // right_tool_panel
            // 
            this.right_tool_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.right_tool_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.right_tool_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.right_tool_panel.Controls.Add(this.autoResize_Right_Tool_Panel_checkBox);
            this.right_tool_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.right_tool_panel.Location = new System.Drawing.Point(1122, 0);
            this.right_tool_panel.Name = "right_tool_panel";
            this.right_tool_panel.Size = new System.Drawing.Size(235, 731);
            this.right_tool_panel.TabIndex = 2;
            this.right_tool_panel.SizeChanged += new System.EventHandler(this.right_tool_panel_SizeChanged);
            this.right_tool_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.right_tool_panel_Paint);
            this.right_tool_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.right_tool_panel_MouseDown);
            this.right_tool_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.right_tool_panel_MouseMove);
            this.right_tool_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.right_tool_panel_MouseUp);
            this.right_tool_panel.Resize += new System.EventHandler(this.right_tool_panel_Resize);
            // 
            // autoResize_Right_Tool_Panel_checkBox
            // 
            this.autoResize_Right_Tool_Panel_checkBox.AutoSize = true;
            this.autoResize_Right_Tool_Panel_checkBox.Checked = true;
            this.autoResize_Right_Tool_Panel_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoResize_Right_Tool_Panel_checkBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoResize_Right_Tool_Panel_checkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.autoResize_Right_Tool_Panel_checkBox.Location = new System.Drawing.Point(33, 46);
            this.autoResize_Right_Tool_Panel_checkBox.Name = "autoResize_Right_Tool_Panel_checkBox";
            this.autoResize_Right_Tool_Panel_checkBox.Size = new System.Drawing.Size(102, 17);
            this.autoResize_Right_Tool_Panel_checkBox.TabIndex = 0;
            this.autoResize_Right_Tool_Panel_checkBox.Text = "Auto Resize";
            this.autoResize_Right_Tool_Panel_checkBox.UseVisualStyleBackColor = true;
            this.autoResize_Right_Tool_Panel_checkBox.CheckedChanged += new System.EventHandler(this.autoResize_Right_Tool_Panel_checkBox_CheckedChanged);
            // 
            // top_tool_panel
            // 
            this.top_tool_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.top_tool_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_tool_panel.Location = new System.Drawing.Point(121, 0);
            this.top_tool_panel.Name = "top_tool_panel";
            this.top_tool_panel.Size = new System.Drawing.Size(1001, 69);
            this.top_tool_panel.TabIndex = 3;
            // 
            // left_tool_panel
            // 
            this.left_tool_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.left_tool_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.left_tool_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_tool_panel.Location = new System.Drawing.Point(0, 0);
            this.left_tool_panel.Name = "left_tool_panel";
            this.left_tool_panel.Size = new System.Drawing.Size(121, 731);
            this.left_tool_panel.TabIndex = 4;
            // 
            // left_mesuring_pictureBox
            // 
            this.left_mesuring_pictureBox.BackColor = System.Drawing.Color.Navy;
            this.left_mesuring_pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_mesuring_pictureBox.Location = new System.Drawing.Point(121, 96);
            this.left_mesuring_pictureBox.Name = "left_mesuring_pictureBox";
            this.left_mesuring_pictureBox.Size = new System.Drawing.Size(37, 635);
            this.left_mesuring_pictureBox.TabIndex = 5;
            this.left_mesuring_pictureBox.TabStop = false;
            // 
            // top_mesuring_pictureBox
            // 
            this.top_mesuring_pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.top_mesuring_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.top_mesuring_pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_mesuring_pictureBox.Location = new System.Drawing.Point(121, 69);
            this.top_mesuring_pictureBox.Name = "top_mesuring_pictureBox";
            this.top_mesuring_pictureBox.Size = new System.Drawing.Size(1001, 27);
            this.top_mesuring_pictureBox.TabIndex = 6;
            this.top_mesuring_pictureBox.TabStop = false;
            this.top_mesuring_pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.top_mesuring_pictureBox_Paint);
            // 
            // main_holder_panel
            // 
            this.main_holder_panel.BackColor = System.Drawing.Color.White;
            this.main_holder_panel.Controls.Add(this.workplace_pictureBox);
            this.main_holder_panel.Controls.Add(this.left_mesuring_pictureBox);
            this.main_holder_panel.Controls.Add(this.top_mesuring_pictureBox);
            this.main_holder_panel.Controls.Add(this.top_tool_panel);
            this.main_holder_panel.Controls.Add(this.left_tool_panel);
            this.main_holder_panel.Controls.Add(this.right_tool_panel);
            this.main_holder_panel.Controls.Add(this.bottom_info_panel);
            this.main_holder_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_holder_panel.Location = new System.Drawing.Point(0, 0);
            this.main_holder_panel.Name = "main_holder_panel";
            this.main_holder_panel.Size = new System.Drawing.Size(1357, 758);
            this.main_holder_panel.TabIndex = 7;
            // 
            // workplace_pictureBox
            // 
            this.workplace_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workplace_pictureBox.Location = new System.Drawing.Point(158, 96);
            this.workplace_pictureBox.Name = "workplace_pictureBox";
            this.workplace_pictureBox.Size = new System.Drawing.Size(964, 635);
            this.workplace_pictureBox.TabIndex = 7;
            this.workplace_pictureBox.TabStop = false;
            this.workplace_pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.workplace_pictureBox_MouseDown);
            this.workplace_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.workplace_pictureBox_MouseMove);
            // 
            // bottom_info_panel
            // 
            this.bottom_info_panel.BackColor = System.Drawing.Color.Gray;
            this.bottom_info_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_info_panel.Location = new System.Drawing.Point(0, 731);
            this.bottom_info_panel.Name = "bottom_info_panel";
            this.bottom_info_panel.Size = new System.Drawing.Size(1357, 27);
            this.bottom_info_panel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1357, 758);
            this.Controls.Add(this.main_holder_panel);
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.right_tool_panel.ResumeLayout(false);
            this.right_tool_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.left_mesuring_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top_mesuring_pictureBox)).EndInit();
            this.main_holder_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workplace_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel right_tool_panel;
        private System.Windows.Forms.Panel top_tool_panel;
        private System.Windows.Forms.Panel left_tool_panel;
        private System.Windows.Forms.PictureBox left_mesuring_pictureBox;
        private System.Windows.Forms.PictureBox top_mesuring_pictureBox;
        private System.Windows.Forms.Panel main_holder_panel;
        private System.Windows.Forms.PictureBox workplace_pictureBox;
        private System.Windows.Forms.CheckBox autoResize_Right_Tool_Panel_checkBox;
        private System.Windows.Forms.Panel bottom_info_panel;
    }
}

