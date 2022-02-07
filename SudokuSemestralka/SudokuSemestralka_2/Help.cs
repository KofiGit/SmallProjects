/*
 * Created by SharpDevelop.
 * User: Petr
 * Date: 21.12.2020
 * Time: 16:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SudokuSemestralka_2
{
	/// <summary>
	/// Help form window.
	/// </summary>
	public partial class Help : Form
	{
		public Help()
		{
			InitializeComponent();			
			
			string text = "If you wanna input number, click in field where you wanna put something and then press numeric key you want to input." +
						  "@If you wanna delete entered numeric number press numeric 0, your input will be deleted." +
						  "@You can also check your solution or show complete sudoku solution.";
				
			text = text.Replace("@", System.Environment.NewLine);
			
			infoLabel.Text = text;
			
		}
	}
}
