using BuisnessLayer.Enum;
using BuisnessLayer.Interface;
using System;
using System.Timers;
namespace BuisnessLayer.Concrate
{
	public class Game : IGame
	{
		#region Fields

		private TimeSpan _spentTime;
		private readonly Timer _spentTimeTimer = new Timer(interval: 1000);

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
		public Game()
		{
			_spentTimeTimer.Elapsed += _spentTimeTimer_Elapsed;
		}
		public void StartGame()
		{
			if (IsContinue) return;
			IsContinue = true;
			_spentTimeTimer.Enabled = true;
			_spentTimeTimer.Start();
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
