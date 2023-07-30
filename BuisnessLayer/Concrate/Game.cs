﻿using BuisnessLayer.Enum;
using BuisnessLayer.Interface;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
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
		private readonly System.Windows.Forms.Timer _movingTimer = new System.Windows.Forms.Timer() { Interval = 500 };
		private readonly PanelControl _airCraftPanel;
		private readonly PanelControl _fieldPanel;
		private AirCraft _airCraft;
		private readonly List<Bullet> _bullets;
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
			_airCraftPanel = airCraftPanel;
			_spentTimeTimer.Elapsed += SpentTimeTimer_Elapsed;
			_movingTimer.Tick += MovingTimer_Tick;
			_fieldPanel = fieldPanel;
			_bullets = new List<Bullet>();
		}
		public void StartGame()
		{
			if (IsContinue) return;
			IsContinue = true;
			_spentTimeTimer.Enabled = true;
			_spentTimeTimer.Start();
			_movingTimer.Start();
			CreateAirCraft();
		}

		private void CreateAirCraft()
		{
			_airCraft = new AirCraft(_airCraftPanel.Width, _airCraftPanel.Size);
			_airCraftPanel.Controls.Add(_airCraft);
		}

		private void SpentTimeTimer_Elapsed(object sender, ElapsedEventArgs e)
		{
			SpentTime += TimeSpan.FromSeconds(1);
		}
		private void MovingTimer_Tick(object sener , EventArgs e)
		{
			MoveBullets();
		}

		private void MoveBullets()
		{
			for(int i = 0; i< _bullets.Count; i++)
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

		private void EndGame()
		{
			if (!IsContinue) return;
			IsContinue = false;
			_spentTimeTimer.Enabled = false;
			_spentTimeTimer.Stop();
			_movingTimer.Stop();

		}
		public void Fire()
		{
			if (!IsContinue) return;
			Bullet bullet = new Bullet(_fieldPanel.Size,_airCraft.Center);
			_fieldPanel.Controls.Add(bullet);
			_bullets.Add(bullet);
		}

		public void MovePlane(Direction direction)
		{
			if (!IsContinue) return;
			_airCraft.Move(direction);
		}
		#endregion
	}
}
