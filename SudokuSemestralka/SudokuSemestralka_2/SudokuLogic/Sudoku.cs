/*
 * Created by SharpDevelop.
 * User: Petr
 * Date: 01.12.2020
 * Time: 18:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SudokuSemestralka_2.SudokuLogic
{
	/// <summary>
	/// Class <c>Sudoku</c> for all operations with cells.
	/// </summary>
	public class Sudoku
	{
		/// <summary>
		/// Cells array.
		/// Carrying all information for sudoku.
		/// </summary>
		/// <permission cref="System.Security.PermissionSet">Array can be set only in <c>Sudoku</c> class.</permission>
		public Cell[,] cells
		{
			get;
			private set;
		}
		
		
		Random random = new Random();
		
		/// <summary>
		/// Constructor for sudoku game.
		/// </summary>
		public Sudoku()
		{
			cells = new Cell[9, 9];
		}
		
		/// <summary>
		/// Creating all needed cells with needed parameters and actions.
		/// </summary>
		public void CreateCells()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    // Create cells for sudoku 9 x 9
                    cells[i, j] = new Cell();
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 22);
                    cells[i, j].Size = new Size(50, 50);
                    cells[i, j].ForeColor = SystemColors.ControlDarkDark;
                    cells[i, j].Location = new Point(i * 50, j * 50);
                    cells[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.Black;
                    cells[i, j].posX = i;
                    cells[i, j].posY = j;

                    // assing key pressed - to catch pressed key by player
                    cells[i, j].KeyPress += Cell_keyPressed;
                }
            }
            
        }
		
		/// <summary>
		/// Key pressed action - to catch pressed key from player
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		static void Cell_keyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Cell;

            // cells locked - is hint
            if (cell.IsLocked)
                return;

            int value;

            // Get pressed value to given cell
            if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                // clear if 0 is pressed 
                if (value == 0)
                    cell.Clear();
                else
                    cell.Text = value.ToString();

                cell.ForeColor = Color.Blue;
            }
        }
		
		/// <summary>
		/// Randomly choose visible numbers from given parameter <paramref name="numbersToShow"/>.
		/// </summary>
		/// <param name="numbersToShow">Given number of hints to show.</param>
		public void RandomNumbersToShow(int numbersToShow)
		{
    		for (int i = 0; i < numbersToShow; i++)
    		{
        		var rndX = random.Next(9);
        		var rndY = random.Next(9);

        		// Change style and lock the value - player cant edit it
        		cells[rndX, rndY].Text = cells[rndX, rndY].Value.ToString();
        		cells[rndX, rndY].ForeColor = Color.Black;
        		cells[rndX, rndY].IsLocked = true;
    		}
		}
		
		/// <summary>
		/// Clear and set value 0 to every cell and then generate new sudoku.
		/// </summary>
		public void GetCellValues()
		{
    		// Clear the values in each cells
    		foreach (var cell in cells)
    		{
        		cell.Value = 0;
        		cell.Clear();
    		}

    		// Recursive - to find suitable values
    		FindValueForNextCell(0, -1);
		}
		
		
		//RECURSIVE - FINDING CORRECT VALUES
		
		/// <summary>
		/// Find recursively value for cells.
		/// Everytime is given cell position (<paramref name="x"/>,<paramref name="y"/>)
		/// </summary>
		/// <param name="x">Cell position [x,]</param>
		/// <param name="y">Cell position [,y]</param>
		/// <returns>True if value has been found for cell</returns>
		bool FindValueForNextCell(int x, int y)
		{
    		if (++y > 8)
    		{
        		y = 0;

        		if (++x > 8)
            		return true;
    		}

    		var value = 0;
    		var numsLeft = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    		do
    		{
        		if (numsLeft.Count < 1)
        		{
            		cells[x, y].Value = 0;
            		return false;
        		}

        		value = numsLeft[random.Next(0, numsLeft.Count)];
        		cells[x, y].Value = value;

        		numsLeft.Remove(value);
    		}
    		while (!IsValidNumber(value, x, y) || !FindValueForNextCell(x, y));

   			return true;
		}
		
		/// <summary>
		/// Check if number in cell is valid, according to sudoku rules.
		/// </summary>
		/// <param name="value">Value we want to put in cell</param>
		/// <param name="x">Cell postion [x,]</param>
		/// <param name="y">Cell postion [,y]</param>
		/// <returns>True if number can be put in cell</returns>
		bool IsValidNumber(int value, int x, int y)
		{
    		for (int i = 0; i < 9; i++)
    		{
        		// Checking x
        		if (i != y && cells[x, i].Value == value)
            		return false;

        		// Checking y
        		if (i != x && cells[i, y].Value == value)
            		return false;
    		}
            
    		// Checking block, sudoku 3x3 box so modulo 3
    		for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
    		{
        		for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
        		{
           			if (i != x && j != y && cells[i, j].Value == value)
                		return false;
        		}
    		}

    		return true;
		}
	}
}
