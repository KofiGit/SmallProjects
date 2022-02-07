/*
 * Created by SharpDevelop.
 * User: Petr
 * Date: 01.12.2020
 * Time: 17:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace SudokuSemestralka_2
{
	/// <summary>
	/// Description of Cell.
	/// </summary>
	public class Cell : Button
	{
		public int Value { get; set; }
        public bool IsLocked { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }
		
        /// <summary>
        /// Method to clear all given settings to cell.
        /// </summary>
        public void Clear()
        {
            Text = string.Empty;
            IsLocked = false;
        }
	}
}
