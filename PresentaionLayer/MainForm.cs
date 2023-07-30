using BuisnessLayer.Concrate;
using BuisnessLayer.Enum;
using DevExpress.XtraReports.Parameters;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PresentaionLayer
{
	public partial class MainForm : Form
	{
		private readonly Game _game = new Game();
		delegate void SetTextCallback(string text);

		public MainForm()
		{
			InitializeComponent();
			_game.SpentTimeChanged += Game_SpentTimeChanged;
			
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
		private void Game_SpentTimeChanged(object sender , EventArgs e)
		{
			var time = _game.SpentTime.ToString(@"m\:ss");
			SetText(time);
		}
		private void SetText(string text)
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
	}
}
