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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.left_tool_panel = new System.Windows.Forms.Panel();
            this.left_mesuring_pictureBox = new System.Windows.Forms.PictureBox();
            this.top_mesuring_pictureBox = new System.Windows.Forms.PictureBox();
            this.main_holder_panel = new System.Windows.Forms.Panel();
            this.workplace_pictureBox = new System.Windows.Forms.PictureBox();
            this.bottom_info_panel = new System.Windows.Forms.Panel();
            this.right_tool_panel.SuspendLayout();
            this.top_tool_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.right_tool_panel.Location = new System.Drawing.Point(1122, 69);
            this.right_tool_panel.MaximumSize = new System.Drawing.Size(500, 900);
            this.right_tool_panel.MinimumSize = new System.Drawing.Size(100, 50);
            this.right_tool_panel.Name = "right_tool_panel";
            this.right_tool_panel.Size = new System.Drawing.Size(235, 662);
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
            this.top_tool_panel.Controls.Add(this.menuStrip1);
            this.top_tool_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_tool_panel.Location = new System.Drawing.Point(0, 0);
            this.top_tool_panel.Name = "top_tool_panel";
            this.top_tool_panel.Size = new System.Drawing.Size(1357, 69);
            this.top_tool_panel.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.effectsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1357, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // effectsToolStripMenuItem
            // 
            this.effectsToolStripMenuItem.Name = "effectsToolStripMenuItem";
            this.effectsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.effectsToolStripMenuItem.Text = "Effects";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // left_tool_panel
            // 
            this.left_tool_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.left_tool_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.left_tool_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_tool_panel.Location = new System.Drawing.Point(0, 69);
            this.left_tool_panel.Name = "left_tool_panel";
            this.left_tool_panel.Size = new System.Drawing.Size(121, 662);
            this.left_tool_panel.TabIndex = 4;
            // 
            // left_mesuring_pictureBox
            // 
            this.left_mesuring_pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.left_mesuring_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.left_mesuring_pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_mesuring_pictureBox.Location = new System.Drawing.Point(121, 94);
            this.left_mesuring_pictureBox.Name = "left_mesuring_pictureBox";
            this.left_mesuring_pictureBox.Size = new System.Drawing.Size(25, 637);
            this.left_mesuring_pictureBox.TabIndex = 5;
            this.left_mesuring_pictureBox.TabStop = false;
            this.left_mesuring_pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.left_mesuring_pictureBox_Paint);
            // 
            // top_mesuring_pictureBox
            // 
            this.top_mesuring_pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.top_mesuring_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.top_mesuring_pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_mesuring_pictureBox.Location = new System.Drawing.Point(121, 69);
            this.top_mesuring_pictureBox.Name = "top_mesuring_pictureBox";
            this.top_mesuring_pictureBox.Size = new System.Drawing.Size(1001, 25);
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
            this.main_holder_panel.Controls.Add(this.left_tool_panel);
            this.main_holder_panel.Controls.Add(this.right_tool_panel);
            this.main_holder_panel.Controls.Add(this.top_tool_panel);
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
            this.workplace_pictureBox.Location = new System.Drawing.Point(146, 94);
            this.workplace_pictureBox.Name = "workplace_pictureBox";
            this.workplace_pictureBox.Size = new System.Drawing.Size(976, 637);
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
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.right_tool_panel.ResumeLayout(false);
            this.right_tool_panel.PerformLayout();
            this.top_tool_panel.ResumeLayout(false);
            this.top_tool_panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

