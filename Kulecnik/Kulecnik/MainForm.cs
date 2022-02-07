/*
 * Created by SharpDevelop.
 * User: Petr
 * Date: 24.11.2020
 * Time: 18:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Kulecnik
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//Variables
		static int period = 100;
		
		//Objects
		Bitmap bm;
		Timer timer;
		Logic lg;

		
		public MainForm()
		{			
			InitializeComponent();
			bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			lg = new Logic(bm, pictureBox1, ColorLogic.ColorPallete.purpleShade);
			
            pictureBox1.BackColor = Color.White;
            cb_balls_number.SelectedIndex = 0;
  
			InitTimer();
            lg.BallManager(1);
		}	

		public void InitTimer()
		{
    		timer = new Timer();
    		timer.Tick += new EventHandler(timer_Tick);
    		timer.Interval = period; // in miliseconds
    		timer.Start();
		}

		void timer_Tick(object sender, EventArgs e)
		{
            lg.MoveBall();
        }
		
				
		//Ball Count
		void Cb_balls_numberSelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedNumber = cb_balls_number.SelectedIndex + 1;
			lg.BallManager(selectedNumber);
		}		
		
		//Ball Color
		void Ball_redClick(object sender, EventArgs e)
		{
			var currentItem = sender as ToolStripMenuItem;
			ChangeCheckedItem(currentItem);
			
			ball_red.Checked = true;
			lg.actualShade = ColorLogic.ColorPallete.redShade;
		}
		void Ball_blueClick(object sender, EventArgs e)
		{
			var currentItem = sender as ToolStripMenuItem;
			ChangeCheckedItem(currentItem);
			
			ball_blue.Checked = true;
			lg.actualShade = ColorLogic.ColorPallete.blueShade;	
		}
		void Ball_greenClick(object sender, EventArgs e)
		{
			var currentItem = sender as ToolStripMenuItem;
			ChangeCheckedItem(currentItem);
			
			ball_green.Checked = true;
			lg.actualShade = ColorLogic.ColorPallete.greenShade;
		}
		void Ball_yellowClick(object sender, EventArgs e)
		{
			var currentItem = sender as ToolStripMenuItem;
			ChangeCheckedItem(currentItem);
			
			ball_yellow.Checked = true;
			lg.actualShade = ColorLogic.ColorPallete.yellowShade;
		}
		void Ball_purpleClick(object sender, EventArgs e)
		{
			var currentItem = sender as ToolStripMenuItem;
			ChangeCheckedItem(currentItem);
			
			ball_purple.Checked = true;
			lg.actualShade = ColorLogic.ColorPallete.purpleShade;
		}
				
		//Background
		void Background_whiteClick(object sender, EventArgs e)
		{
			var currentItem = sender as ToolStripMenuItem;
			ChangeCheckedItem(currentItem);
			
			Background_white.Checked = true;
			pictureBox1.BackColor = Color.White;
			lg.ChangeBackgroundColor();
		}
		void Background_orangeClick(object sender, EventArgs e)
		{
			var currentItem = sender as ToolStripMenuItem;
			ChangeCheckedItem(currentItem);
			
			Background_orange.Checked = true;
			pictureBox1.BackColor = Color.Orange;
			lg.ChangeBackgroundColor();
		}
		void Background_blueClick(object sender, EventArgs e)
		{
			var currentItem = sender as ToolStripMenuItem;
			ChangeCheckedItem(currentItem);
			
			Background_blue.Checked = true;
			pictureBox1.BackColor = Color.Blue;
			lg.ChangeBackgroundColor();
		}
		void Background_greenClick(object sender, EventArgs e)
		{
			var currentItem = sender as ToolStripMenuItem;
			ChangeCheckedItem(currentItem);
			
			Background_green.Checked = true;
			pictureBox1.BackColor = Color.Green;
			lg.ChangeBackgroundColor();
		}
		
		void ChangeCheckedItem(ToolStripMenuItem currentItem)
		{
			if (currentItem != null)
    		{
    			((ToolStripMenuItem)currentItem.OwnerItem).DropDownItems
            		.OfType<ToolStripMenuItem>().ToList()
            		.ForEach(item =>
            	{
                	item.Checked = false;
            	});
        		currentItem.Checked = true;
    		}
		}
				
    }
}
