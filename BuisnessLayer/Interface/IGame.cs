using BuisnessLayer.Enum;
using System;
using System.Windows.Forms.Design;

namespace BuisnessLayer.Interface
{
	internal interface IGame
	{
		bool IsContinue { get; }
		TimeSpan SpentTime { get; }
		int Level { get; }
		int Score { get; }
		event EventHandler SpentTimeChanged;
		event EventHandler ScoreChanged;
		event EventHandler LevelChanged;
		event EventHandler GameEnded;
		void StartGame();
		void MovePlane(Direction direction);
		void Fire();
	}
}
