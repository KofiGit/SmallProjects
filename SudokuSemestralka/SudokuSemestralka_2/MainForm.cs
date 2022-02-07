/*
 * Created by SharpDevelop.
 * User: Petr
 * Date: 01.12.2020
 * Time: 17:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SudokuSemestralka_2.SudokuLogic;

namespace SudokuSemestralka_2
{
	/// <summary>
	/// Main window form.
	/// </summary>
	public partial class MainForm : Form
	{
		Sudoku sudoku;
		Random random = new Random();
		Diff diff = Diff.Easy;
		
		public MainForm()
		{
			InitializeComponent();
			
			//Initialize sudoku class for performing backend operations.
			sudoku = new Sudoku();
			
			//Get cells and add them to Panel
			FillPanel();
			
			//Start new game
			StartNewGame();
		}
		
		/// <summary>
		/// Method to create cells and fill panel with all of them
		/// </summary>
		void FillPanel()
		{
			sudoku.CreateCells();
			
			for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                	playBoard.Controls.Add(sudoku.cells[i, j]);	
                }
                
			}						
		}
		
		/// <summary>
		/// Start new game and determine how much numbers to show according set difficulty
		/// </summary>
		void StartNewGame()
		{
    		sudoku.GetCellValues();
    		
    		var numbersToShow = 0;
    		
    		if (diff == Diff.Easy)
        		numbersToShow = 45;
    		else if (diff == Diff.Medium)
        		numbersToShow = 30;
    		else if (diff == Diff.Hard)
        		numbersToShow = 15;

    		sudoku.RandomNumbersToShow(numbersToShow);
		}
		
		//MENU
		
		/// <summary>
		/// Click event on new game in menu strip
		/// Starts new game
		/// </summary>		
		void MenuItemNewGameClick(object sender, EventArgs e)
		{
			StartNewGame();
		}
		
		/// <summary>
		/// Click event on exit in menu strip
		/// Closes application
		/// </summary>	
		void MenuItemExitClick(object sender, EventArgs e)
		{
			Close();
		}
		
		/// <summary>
		/// Click event on Easy difficulty in menu strip
		/// </summary>	
		void EasyToolStripMenuItemClick(object sender, EventArgs e)
		{
			var currentItem = sender as ToolStripMenuItem;
			ChangeCheckedItem(currentItem);
			
			diff = Diff.Easy;
		}
		
		/// <summary>
		/// Click event on Medium difficulty in menu strip
		/// </summary>	
		void MediumToolStripMenuItemClick(object sender, EventArgs e)
		{
			var currentItem = sender as ToolStripMenuItem;
			ChangeCheckedItem(currentItem);
			
			diff = Diff.Medium;
		}
		
		/// <summary>
		/// Click event on Hard difficulty in menu strip
		/// </summary>	
		void HardToolStripMenuItemClick(object sender, EventArgs e)
		{
			var currentItem = sender as ToolStripMenuItem;
			ChangeCheckedItem(currentItem);
			
			diff = Diff.Hard;
		}
		
		/// <summary>
		/// Method to change checked items in menu strip, according to level, in which current item is in
		/// </summary>	
		/// <param name="currentItem">Current item that has been changed and should be only one checked</param>
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
		
		/// <summary>
		/// Click event on Clear Inputs in menu strip.
		/// Clears all user inputs in cells.
		/// </summary>	
		void MenuItemClearInputsClick(object sender, EventArgs e)
		{
			foreach (var cell in sudoku.cells)
    		{
        		// clear of value if its not locked as hint
				if (!cell.IsLocked)
					cell.Clear();
    		}
		}
		
		/// <summary>
		/// Click event on check solution in menu strip.
		/// Check all inputs if they are correct
		/// </summary>	
		void MenuItemCheckSolutionClick(object sender, EventArgs e)
		{
			var wrongCells = new List<Cell>();

    		// Check all wrong according to already have cells value
    		foreach (var cell in sudoku.cells)
    		{
        		if (!string.Equals(cell.Value.ToString(), cell.Text))
        		{
            		wrongCells.Add(cell);
        		}
    		}

    		// Is any wrong? 
    		if (wrongCells.Any())
    		{
        		// Change the wrong ones to red
        		wrongCells.ForEach(x => x.ForeColor = Color.Red);
        		MessageBox.Show("Some numbers are wrong", "Sudoku is not finished", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    		}
    		else
    		{
        		MessageBox.Show("You did it, all is correct", "Sudoku finished sucessfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    		}
		}
		
		/// <summary>
		/// Click event on show solution in menu strip.
		/// Show sudoku numbers  which are solution in  green color.
		/// </summary>	
		void ShowSolutionToolStripMenuItemClick(object sender, EventArgs e)
		{
			foreach(var cell in sudoku.cells)
			{
				cell.Text = cell.Value.ToString();
				if(!cell.IsLocked)
					cell.ForeColor = Color.Green;
			}
		}
		
		/// <summary>
		/// Click event on About in menu strip.
		/// Show new about window.
		/// </summary>	
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			About about = new About();
			about.Show();
		}
		
		/// <summary>
		/// Click event on Help in menu strip.
		/// Show new help window.
		/// </summary>	
		void MenuItemHelpClick(object sender, EventArgs e)
		{
			Help help = new Help();
			help.Show();
		}
		
		
	}
}
