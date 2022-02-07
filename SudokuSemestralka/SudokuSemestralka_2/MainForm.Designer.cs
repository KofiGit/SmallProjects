/*
 * Created by SharpDevelop.
 * User: Petr
 * Date: 01.12.2020
 * Time: 17:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SudokuSemestralka_2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel playBoard;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuItemNewGame;
		private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuItemClearInputs;
		private System.Windows.Forms.ToolStripMenuItem menuItemCheckSolution;
		private System.Windows.Forms.ToolStripMenuItem menuItemExit;
		private System.Windows.Forms.ToolStripMenuItem showSolutionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
		
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
			this.playBoard = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemNewGame = new System.Windows.Forms.ToolStripMenuItem();
			this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemClearInputs = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemCheckSolution = new System.Windows.Forms.ToolStripMenuItem();
			this.showSolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// playBoard
			// 
			this.playBoard.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.playBoard.Location = new System.Drawing.Point(37, 27);
			this.playBoard.Name = "playBoard";
			this.playBoard.Size = new System.Drawing.Size(487, 469);
			this.playBoard.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuToolStripMenuItem,
			this.aboutToolStripMenuItem,
			this.menuItemHelp,
			this.menuItemExit});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(543, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuItemNewGame,
			this.difficultyToolStripMenuItem,
			this.menuItemClearInputs,
			this.menuItemCheckSolution,
			this.showSolutionToolStripMenuItem});
			this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// menuItemNewGame
			// 
			this.menuItemNewGame.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.menuItemNewGame.Name = "menuItemNewGame";
			this.menuItemNewGame.Size = new System.Drawing.Size(153, 22);
			this.menuItemNewGame.Text = "New Game";
			this.menuItemNewGame.ToolTipText = "Start a new sudoku game";
			this.menuItemNewGame.Click += new System.EventHandler(this.MenuItemNewGameClick);
			// 
			// difficultyToolStripMenuItem
			// 
			this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.easyToolStripMenuItem,
			this.mediumToolStripMenuItem,
			this.hardToolStripMenuItem});
			this.difficultyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
			this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.difficultyToolStripMenuItem.Text = "Difficulty";
			this.difficultyToolStripMenuItem.ToolTipText = "Select sudoku difficulty";
			// 
			// easyToolStripMenuItem
			// 
			this.easyToolStripMenuItem.Checked = true;
			this.easyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
			this.easyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.easyToolStripMenuItem.Text = "Easy";
			this.easyToolStripMenuItem.Click += new System.EventHandler(this.EasyToolStripMenuItemClick);
			// 
			// mediumToolStripMenuItem
			// 
			this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
			this.mediumToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.mediumToolStripMenuItem.Text = "Medium";
			this.mediumToolStripMenuItem.Click += new System.EventHandler(this.MediumToolStripMenuItemClick);
			// 
			// hardToolStripMenuItem
			// 
			this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
			this.hardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.hardToolStripMenuItem.Text = "Hard";
			this.hardToolStripMenuItem.Click += new System.EventHandler(this.HardToolStripMenuItemClick);
			// 
			// menuItemClearInputs
			// 
			this.menuItemClearInputs.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.menuItemClearInputs.Name = "menuItemClearInputs";
			this.menuItemClearInputs.Size = new System.Drawing.Size(153, 22);
			this.menuItemClearInputs.Text = "Clear Inputs";
			this.menuItemClearInputs.ToolTipText = "Clear all of user inputs";
			this.menuItemClearInputs.Click += new System.EventHandler(this.MenuItemClearInputsClick);
			// 
			// menuItemCheckSolution
			// 
			this.menuItemCheckSolution.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.menuItemCheckSolution.Name = "menuItemCheckSolution";
			this.menuItemCheckSolution.Size = new System.Drawing.Size(153, 22);
			this.menuItemCheckSolution.Text = "Check Solution";
			this.menuItemCheckSolution.ToolTipText = "Check user inputs if they are correct";
			this.menuItemCheckSolution.Click += new System.EventHandler(this.MenuItemCheckSolutionClick);
			// 
			// showSolutionToolStripMenuItem
			// 
			this.showSolutionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.showSolutionToolStripMenuItem.Name = "showSolutionToolStripMenuItem";
			this.showSolutionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.showSolutionToolStripMenuItem.Text = "Show Solution";
			this.showSolutionToolStripMenuItem.ToolTipText = "Show actual sudoku solution";
			this.showSolutionToolStripMenuItem.Click += new System.EventHandler(this.ShowSolutionToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.ToolTipText = "About this application";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// menuItemHelp
			// 
			this.menuItemHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.menuItemHelp.Name = "menuItemHelp";
			this.menuItemHelp.Size = new System.Drawing.Size(44, 20);
			this.menuItemHelp.Text = "Help";
			this.menuItemHelp.Click += new System.EventHandler(this.MenuItemHelpClick);
			// 
			// menuItemExit
			// 
			this.menuItemExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.menuItemExit.Name = "menuItemExit";
			this.menuItemExit.Size = new System.Drawing.Size(38, 20);
			this.menuItemExit.Text = "Exit";
			this.menuItemExit.ToolTipText = "Close this application";
			this.menuItemExit.Click += new System.EventHandler(this.MenuItemExitClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(543, 508);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.playBoard);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(559, 547);
			this.Name = "MainForm";
			this.Text = "Sudoku Game";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
