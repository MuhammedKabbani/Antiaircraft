using BuisnessLayer.Enum;
using BuisnessLayer.Interface;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Timers;
using System.Windows.Forms;

namespace BuisnessLayer.Concrate
{
	public class Game : IGame
	{
		#region Fields
		private TimeSpan _spentTime;
		private AirCraft _airCraft;
		private readonly System.Timers.Timer _spentTimeTimer;
		private readonly System.Windows.Forms.Timer _movingTimer;
		private readonly System.Windows.Forms.Timer _createPlaneTimer;
		private readonly PanelControl _airCraftPanel;
		private readonly PanelControl _fieldPanel;
		private readonly List<Bullet> _bullets;
		private readonly List<Plane> _planes;
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
		public Game(PanelControl airCraftPanel, PanelControl fieldPanel)
		{
			_spentTimeTimer = new System.Timers.Timer(interval: 1000);
			_movingTimer = new System.Windows.Forms.Timer() { Interval = 5 };
			_createPlaneTimer = new System.Windows.Forms.Timer() { Interval = 2500 };

			_spentTimeTimer.Elapsed += SpentTimeTimer_Elapsed;
			_movingTimer.Tick += MovingTimer_Tick;
			_createPlaneTimer.Tick += CreatePlaneTimer_Tick;

			_airCraftPanel = airCraftPanel;
			_fieldPanel = fieldPanel;
			_bullets = new List<Bullet>();
			_planes = new List<Plane>();
		}
		public void StartGame()
		{
			if (IsContinue) return;
			IsContinue = true;
			_spentTimeTimer.Enabled = true;
			_fieldPanel.Controls.Clear();
			_airCraftPanel.Controls.Clear();
			SpentTime = TimeSpan.FromSeconds(0);
			_spentTimeTimer.Start();
			_movingTimer.Start();
			_createPlaneTimer.Start();
			CreateAirCraft();
			CreatePlane();
		}
		private void EndGame()
		{
			if (!IsContinue) return;
			IsContinue = false;
			_spentTimeTimer.Enabled = false;
			_spentTimeTimer.Stop();
			_movingTimer.Stop();
			_createPlaneTimer.Stop();
			_planes.Clear();
			_bullets.Clear();
		}
		private void CreateAirCraft()
		{
			_airCraft = new AirCraft(_airCraftPanel.Width, _airCraftPanel.Size);
			_airCraftPanel.Controls.Add(_airCraft);
		}
		private void CreatePlane()
		{
			Plane plane = new Plane(_fieldPanel.Size);
			_fieldPanel.Controls.Add(plane);
			_planes.Add(plane);
		}
		private void SpentTimeTimer_Elapsed(object sender, ElapsedEventArgs e)
		{
			SpentTime += TimeSpan.FromSeconds(1);
		}
		private void MovingTimer_Tick(object sener, EventArgs e)
		{
			MoveBullets();
			MovePlanes();
			DestroyPlane();
		}
		private void CreatePlaneTimer_Tick(object sener, EventArgs e)
		{
			CreatePlane();
		}
		private void MoveBullets()
		{
			for (int i = 0; i < _bullets.Count; i++)
			{
				Bullet bullet = _bullets[i];
				if (bullet.Move(Direction.Up))
				{
					_bullets.Remove(bullet);
					_fieldPanel.Controls.Remove(bullet);
					i--;
				}
			}
		}
		private void MovePlanes()
		{
			for (int i = 0; i < _planes.Count; i++)
			{
				Plane plane = _planes[i];
				if (plane.Move(Direction.Down))
				{
					EndGame();
					break;
				}
			}
		}

		public void Fire()
		{
			if (!IsContinue) return;
			Bullet bullet = new Bullet(_fieldPanel.Size, _airCraft.Center);
			_fieldPanel.Controls.Add(bullet);
			_bullets.Add(bullet);
		}
		private void DestroyPlane()
		{
			for (int i = 0; i < _planes.Count; i++)
			{
				Plane plane = _planes[0];
				Bullet hittenBullet = plane.IsHit(_bullets);
				if (hittenBullet != null)
				{
					_fieldPanel.Controls.Remove(plane);
					_fieldPanel.Controls.Remove(hittenBullet);
					_planes.Remove(plane);
					_bullets.Remove(hittenBullet);
				}
			}
		}
		public void MovePlane(Direction direction)
		{
			if (!IsContinue) return;
			_airCraft.Move(direction);
		}
		#endregion
	}
}
