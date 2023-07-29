using BuisnessLayer.Enum;
using System;

namespace BuisnessLayer.Interface
{
	internal interface IGame
	{
		bool IsContinue { get; }

		TimeSpan SpentTime { get; }


		void StartGame();

		void MovePlane(Direction direction);

		void Fire();
	}
}
