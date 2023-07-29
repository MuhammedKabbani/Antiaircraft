using BuisnessLayer.Enum;
using BuisnessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrate
{
	public class Game : IGame
	{
		public bool IsContinue { get; private set; }

		public TimeSpan SpentTime { get; private set; }

		public void StartGame()
		{
			if (IsContinue) return;
			IsContinue = true;
		}
		private void EndGame()
		{
			if (!IsContinue) return;
			IsContinue = false;
		}
		public void Fire()
		{
			if (!IsContinue) return;

		}

		public void MovePlane(Direction direction)
		{
			if (!IsContinue) return;
		}

	}
}
