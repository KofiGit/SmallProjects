/*
 * Created by SharpDevelop.
 * User: Petr
 * Date: 25.11.2020
 * Time: 17:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Kulecnik
{
	/// <summary>
	/// Description of Logic.
	/// </summary>
	public class Logic
	{
		public PictureBox picBox;
		SolidBrush backgroundColor;
		Bitmap bm;
        Random rnd = new Random();
        public List<Ball> ballList = new List<Ball>();
        public ColorLogic.ColorPallete actualShade;
        ColorLogic colors;
        
        public Logic(Bitmap bm, PictureBox pb, ColorLogic.ColorPallete shade)
		{
            picBox = pb;
			this.bm = bm;
			actualShade = shade;
			colors = new ColorLogic();
			ChangeBackgroundColor();
        }
        
        public void BallManager(int numberOfBalls)
        {
        	while(numberOfBalls != ballList.Count)
        	{
        		if(ballList.Count < numberOfBalls)
        		{
        			var color = colors.GetMeColor(actualShade);
        			var ball = new Ball(color, picBox.Width, picBox.Height);
        			ball.xMovement = rnd.Next(-5,6);
        			ball.yMovement = rnd.Next(-5,6);
					ballList.Add(ball);
        		}
        		else if(ballList.Count > numberOfBalls)
        		{
        			ballList.RemoveAt(1);
        		}
        	}
        	        	
        	ChangeGraphicBall();
        }
						
		void ChangeGraphicBall(Brush br = null)
		{		
			using (Graphics gr = Graphics.FromImage(bm))
			{
				//Clear of all balls
				gr.Clear(picBox.BackColor);
				
				//Draw them again with new coordinates
				foreach(Ball b in ballList)
				{
					gr.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
    				if(br == null)
    			   		gr.FillEllipse(b.color, b.rect);
    				else
    			   		gr.FillEllipse(br, b.rect);
    				
    				gr.DrawEllipse(Pens.Black,b.rect);
				}
			}
			picBox.Image = bm;
		}

        public void MoveBall()
        {
        	foreach(var ball in ballList)
			{            
            	ball.rect.X += ball.xMovement;
            	ball.rect.Y += ball.yMovement;
            
            	if(ball.rect.X > picBox.Width - ball.rect.Width)
            	{
            		ball.rect.X = picBox.Width - ball.rect.Width;
            		ball.xMovement = rnd.Next(-5,0);
            		ball.yMovement = rnd.Next(-5,6);
            	}
            	if(ball.rect.Y > picBox.Height - ball.rect.Height)
            	{
            		ball.rect.Y = picBox.Height - ball.rect.Height;
            		ball.xMovement = rnd.Next(-5,6);
            		ball.yMovement = rnd.Next(-5,0);
            	}
            	if(ball.rect.X < 0)
            	{
            		ball.rect.X = 0;
            		ball.yMovement = rnd.Next(-5,6);
            		ball.xMovement = rnd.Next(1,6);
            	}
            	if(ball.rect.Y < 0)
            	{
            		ball.rect.Y = 0;
            		ball.yMovement = rnd.Next(1,6);
            		ball.xMovement = rnd.Next(-5,6);
            	}
			}
        	
        	ChangeGraphicBall();
        }
        
        public void ChangeBackgroundColor()
        {
        	backgroundColor = new SolidBrush(Color.FromArgb(255, (byte)picBox.BackColor.R, (byte)picBox.BackColor.G, (byte)picBox.BackColor.B));
        }
        
	}
}
