using BuisnessLayer.Concrate;
using BuisnessLayer.Enum;
using DevExpress.XtraReports.Parameters;
using System.Windows.Forms;

namespace PresentaionLayer
{
	public partial class MainForm : Form
	{
		private readonly Game _game = new Game();

		public MainForm()
		{
			InitializeComponent();
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
	}
}
