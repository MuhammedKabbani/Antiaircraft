using BuisnessLayer.Enum;
using System;
using System.Windows.Forms.Design;

namespace BuisnessLayer.Interface
{
	internal interface IGame
	{
		bool IsContinue { get; }

		TimeSpan SpentTime { get; }
		
		event EventHandler SpentTimeChanged;

		void StartGame();

		void MovePlane(Direction direction);

		void Fire();
	}
}
