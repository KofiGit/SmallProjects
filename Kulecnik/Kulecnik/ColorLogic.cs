/*
 * Created by SharpDevelop.
 * User: Petr
 * Date: 25.11.2020
 * Time: 20:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace Kulecnik
{
	/// <summary>
	/// Description of ColorLogic.
	/// </summary>
	public class ColorLogic
	{
		public enum ColorPallete
		{
			purpleShade,
			yellowShade,
			redShade,
			blueShade,
			greenShade,
			white,
			black
		}
		
		Random rnd = new Random();
		
		public ColorLogic()
		{
		}
		
		public SolidBrush GetMeColor(ColorPallete color)
		{
			var random = 255;
			switch(color)
			{
				case ColorPallete.blueShade:
					random = rnd.Next(50,256);
					return new SolidBrush(Color.FromArgb(255, (byte)0, (byte)0, (byte)random));
					
				case ColorPallete.greenShade:
					random = rnd.Next(50,256);
					return new SolidBrush(Color.FromArgb(255, (byte)0, (byte)random, (byte)0));
				
				case ColorPallete.redShade:
					random = rnd.Next(50,256);
					return new SolidBrush(Color.FromArgb(255, (byte)random, (byte)0, (byte)0));
					
				case ColorPallete.purpleShade:
					random = rnd.Next(50,256);
					var randomPurple = rnd.Next(50,256);
					return new SolidBrush(Color.FromArgb(255, (byte)random, (byte)0, (byte)randomPurple));
					
				case ColorPallete.yellowShade:
					random = rnd.Next(160,256);
					var randomYellow = rnd.Next(160,256);
					return new SolidBrush(Color.FromArgb(255, (byte)random, (byte)randomYellow, (byte)0));
					
				case ColorPallete.white:
					return new SolidBrush(Color.FromArgb(255, (byte)255, (byte)255, (byte)255));
					
				case ColorPallete.black:
					return new SolidBrush(Color.FromArgb(255, (byte)0, (byte)0, (byte)0));
			}
			
			return new SolidBrush(Color.FromArgb(255, (byte)0, (byte)0, (byte)0));
		}
	}
}
