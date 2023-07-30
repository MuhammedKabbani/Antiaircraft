using BuisnessLayer.Enum;
using BuisnessLayer.Interface;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace BuisnessLayer.Concrate
{
	public class Game : IGame
	{
		#region Fields

		private TimeSpan _spentTime;
		private readonly System.Timers.Timer _spentTimeTimer = new System.Timers.Timer(interval: 1000);
		private readonly PanelControl _airCraftPanel;
		#endregion
		
		#region Events
		
		public event EventHandler SpentTimeChanged;

		#endregion

		#region Properties

		public bool IsContinue { get; private set; }
		public TimeSpan SpentTime 
		{ 
			get => _spentTime;  
			private set 
			{
				_spentTime = value;

				SpentTimeChanged?.Invoke(this, EventArgs.Empty);
			}
		}

		#endregion

		#region Methods
		public Game(PanelControl airCraftPanel)
		{
			_airCraftPanel = airCraftPanel;
			_spentTimeTimer.Elapsed += _spentTimeTimer_Elapsed;
		}
		public void StartGame()
		{
			if (IsContinue) return;
			IsContinue = true;
			_spentTimeTimer.Enabled = true;
			_spentTimeTimer.Start();

			CreateAirCraft();
		}

		private void CreateAirCraft()
		{
			var airCraft = new AirCraft(_airCraftPanel.Width)
			{
				Image = Image.FromFile(@"Images\airCraft.png")
			};
			_airCraftPanel.Controls.Add(airCraft);
		}

		private void _spentTimeTimer_Elapsed(object sender, ElapsedEventArgs e)
		{
			SpentTime += TimeSpan.FromSeconds(1);
		}

		private void EndGame()
		{
			if (!IsContinue) return;
			IsContinue = false;
			_spentTimeTimer.Enabled = false;
			_spentTimeTimer.Stop();

		}
		public void Fire()
		{
			if (!IsContinue) return;

		}

		public void MovePlane(Direction direction)
		{
			if (!IsContinue) return;
		}
		#endregion
	}
}
