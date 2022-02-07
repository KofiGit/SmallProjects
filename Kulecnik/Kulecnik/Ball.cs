/*
 * Created by SharpDevelop.
 * User: Petr
 * Date: 25.11.2020
 * Time: 20:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kulecnik
{
	/// <summary>
	/// Description of Ball.
	/// </summary>
	public class Ball
	{
		public int xMovement = 5;
		public int yMovement = 0;
		public SolidBrush color;
		public Rectangle rect;
		Random rnd = new Random();
		
		public Ball(SolidBrush color, int picBoxWidth, int picBoxHeight)
		{
			this.color = color;
 			int nSize = 20;
 			var spawnWidth = rnd.Next(nSize,picBoxWidth - nSize);
 			var spawnHeight = rnd.Next(nSize,picBoxHeight - nSize);
            //rect = new Rectangle(Convert.ToInt32((picBoxWidth - nSize) / 2), Convert.ToInt32((picBoxHeight - nSize) / 2), nSize, nSize);
			rect = new Rectangle(spawnWidth, spawnHeight, nSize, nSize);	            
		}
	}
}
