
using BuisnessLayer.Enum;
using System.Drawing;

namespace BuisnessLayer.Interface
{
	internal interface IMoveable
	{
		/// <summary>
		/// Move the shape depending on wanted direction
		/// </summary>
		/// <param name="direction">The direction wanted</param>
		/// <returns>Returns true if the shape hit a wall</returns>
		bool Move(Direction direction);

		Size MoveAreaSize { get; }
		int MoveAmount { get; }
	}
}
