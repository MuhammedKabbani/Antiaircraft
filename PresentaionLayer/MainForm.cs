using BuisnessLayer.Concrate;
using BuisnessLayer.Enum;
using DevExpress.XtraReports.Parameters;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PresentaionLayer
{
	public partial class MainForm : Form
	{
		private readonly Game _game;
		delegate void SetTextCallback(string text);

		public MainForm()
		{
			InitializeComponent();
			_game = new Game(panelHome, panelBoard);
			_game.SpentTimeChanged += Game_SpentTimeChanged;
			_game.ScoreChanged += Game_ScoreChanged;
			_game.LevelChanged += Game_LevelChanged;
			_game.GameEnded += Game_GameEnded;

		}
		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Right:
					_game.MovePlane(Direction.Right);
					break;
				case Keys.Left:
					_game.MovePlane(Direction.Left);
					break;
				case Keys.Enter:
					_game.StartGame();
					break;
				case Keys.Space:
					_game.Fire();
					break;
			}
		}
		private void Game_SpentTimeChanged(object sender, EventArgs e)
		{
			var time = _game.SpentTime.ToString(@"m\:ss");
			SetText(time);
		}
		private void SetText(string text)
		{
			try
			{

				if (lblTimer.InvokeRequired)
				{
					SetTextCallback d = new SetTextCallback(SetText);
					Invoke(d, new object[] { text });
				}
				else
				{
					lblTimer.Text = text;
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}
		private void Game_ScoreChanged(object sender , EventArgs e)
		{
			lblScore.Text = _game.Score.ToString();
		}
		private void Game_LevelChanged(object sender , EventArgs e)
		{
			lblLevel.Text = _game.Level.ToString();
		}
		private void Game_GameEnded(object sender, EventArgs e)
		{
			lblLevel.Text = "1";
		}
	}
}
