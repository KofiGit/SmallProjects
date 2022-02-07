/*
 * Created by SharpDevelop.
 * User: Petr
 * Date: 24.11.2020
 * Time: 18:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Kulecnik
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ballCountToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ballColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ball_red;
		private System.Windows.Forms.ToolStripMenuItem ball_blue;
		private System.Windows.Forms.ToolStripMenuItem ball_green;
		private System.Windows.Forms.ToolStripMenuItem ball_purple;
		private System.Windows.Forms.ToolStripMenuItem ball_yellow;
		private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem Background_white;
		private System.Windows.Forms.ToolStripMenuItem Background_orange;
		private System.Windows.Forms.ToolStripMenuItem Background_blue;
		private System.Windows.Forms.ToolStripMenuItem Background_green;
		public System.Windows.Forms.ToolStripComboBox cb_balls_number;
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ballCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cb_balls_number = new System.Windows.Forms.ToolStripComboBox();
			this.ballColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ball_red = new System.Windows.Forms.ToolStripMenuItem();
			this.ball_blue = new System.Windows.Forms.ToolStripMenuItem();
			this.ball_green = new System.Windows.Forms.ToolStripMenuItem();
			this.ball_purple = new System.Windows.Forms.ToolStripMenuItem();
			this.ball_yellow = new System.Windows.Forms.ToolStripMenuItem();
			this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Background_white = new System.Windows.Forms.ToolStripMenuItem();
			this.Background_orange = new System.Windows.Forms.ToolStripMenuItem();
			this.Background_blue = new System.Windows.Forms.ToolStripMenuItem();
			this.Background_green = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(1, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(408, 300);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(413, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ballCountToolStripMenuItem,
			this.ballColorToolStripMenuItem,
			this.backgroundColorToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// ballCountToolStripMenuItem
			// 
			this.ballCountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.cb_balls_number});
			this.ballCountToolStripMenuItem.Name = "ballCountToolStripMenuItem";
			this.ballCountToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.ballCountToolStripMenuItem.Text = "Ball Count";
			// 
			// cb_balls_number
			// 
			this.cb_balls_number.Items.AddRange(new object[] {
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9",
			"10"});
			this.cb_balls_number.MaxDropDownItems = 10;
			this.cb_balls_number.Name = "cb_balls_number";
			this.cb_balls_number.Size = new System.Drawing.Size(121, 23);
			this.cb_balls_number.SelectedIndexChanged += new System.EventHandler(this.Cb_balls_numberSelectedIndexChanged);
			// 
			// ballColorToolStripMenuItem
			// 
			this.ballColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ball_red,
			this.ball_blue,
			this.ball_green,
			this.ball_purple,
			this.ball_yellow});
			this.ballColorToolStripMenuItem.Name = "ballColorToolStripMenuItem";
			this.ballColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.ballColorToolStripMenuItem.Text = "Ball Color";
			// 
			// ball_red
			// 
			this.ball_red.Name = "ball_red";
			this.ball_red.Size = new System.Drawing.Size(148, 22);
			this.ball_red.Text = "Red Shades";
			this.ball_red.Click += new System.EventHandler(this.Ball_redClick);
			// 
			// ball_blue
			// 
			this.ball_blue.Name = "ball_blue";
			this.ball_blue.Size = new System.Drawing.Size(148, 22);
			this.ball_blue.Text = "Blue Shades";
			this.ball_blue.Click += new System.EventHandler(this.Ball_blueClick);
			// 
			// ball_green
			// 
			this.ball_green.Name = "ball_green";
			this.ball_green.Size = new System.Drawing.Size(148, 22);
			this.ball_green.Text = "Green Shades";
			this.ball_green.Click += new System.EventHandler(this.Ball_greenClick);
			// 
			// ball_purple
			// 
			this.ball_purple.Checked = true;
			this.ball_purple.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ball_purple.Name = "ball_purple";
			this.ball_purple.Size = new System.Drawing.Size(148, 22);
			this.ball_purple.Text = "Purple Shades";
			this.ball_purple.Click += new System.EventHandler(this.Ball_purpleClick);
			// 
			// ball_yellow
			// 
			this.ball_yellow.Name = "ball_yellow";
			this.ball_yellow.Size = new System.Drawing.Size(148, 22);
			this.ball_yellow.Text = "Yellow Shades";
			this.ball_yellow.Click += new System.EventHandler(this.Ball_yellowClick);
			// 
			// backgroundColorToolStripMenuItem
			// 
			this.backgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.Background_white,
			this.Background_orange,
			this.Background_blue,
			this.Background_green});
			this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
			this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.backgroundColorToolStripMenuItem.Text = "Background Color";
			// 
			// Background_white
			// 
			this.Background_white.Checked = true;
			this.Background_white.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Background_white.Name = "Background_white";
			this.Background_white.Size = new System.Drawing.Size(113, 22);
			this.Background_white.Text = "White";
			this.Background_white.Click += new System.EventHandler(this.Background_whiteClick);
			// 
			// Background_orange
			// 
			this.Background_orange.Name = "Background_orange";
			this.Background_orange.Size = new System.Drawing.Size(113, 22);
			this.Background_orange.Text = "Orange";
			this.Background_orange.Click += new System.EventHandler(this.Background_orangeClick);
			// 
			// Background_blue
			// 
			this.Background_blue.Name = "Background_blue";
			this.Background_blue.Size = new System.Drawing.Size(113, 22);
			this.Background_blue.Text = "Blue";
			this.Background_blue.Click += new System.EventHandler(this.Background_blueClick);
			// 
			// Background_green
			// 
			this.Background_green.Name = "Background_green";
			this.Background_green.Size = new System.Drawing.Size(113, 22);
			this.Background_green.Text = "Green";
			this.Background_green.Click += new System.EventHandler(this.Background_greenClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(413, 327);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximumSize = new System.Drawing.Size(429, 366);
			this.MinimumSize = new System.Drawing.Size(429, 366);
			this.Name = "MainForm";
			this.Text = "Kulecnik";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
