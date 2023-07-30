using BuisnessLayer.Enum;
using BuisnessLayer.Interface;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BuisnessLayer.Abstract
{
	internal abstract class Shape : PictureBox, IMoveable
	{
		protected Shape(Size moveAreaSize)
		{
			SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			MoveAreaSize = moveAreaSize;
		}

		public Size MoveAreaSize { get; private set; }

		public int MoveAmount { get;protected set; }

		public bool Move(Direction direction)
		{
			switch (direction)
			{
				case Direction.Up:
					return MoveUp();
				case Direction.Down:
					return MoveDown();
				case Direction.Right:
					return MoveRight();
				case Direction.Left:
					return MoveLeft();
				default:
					return false;
			}
		}

		private bool MoveUp()
		{
			if (Top == 0) return true;

			var newTop = Top - MoveAmount;

			Top = newTop < 0 ? 0 : newTop;

			return Top == 0;
		}
		private bool MoveDown()
		{
			if (Bottom == MoveAreaSize.Height) return true;

			var newBottom = Bottom + MoveAmount;

			var bottom = newBottom > MoveAreaSize.Height ? MoveAreaSize.Height : newBottom;
			Top = bottom - Height;
			return Bottom == MoveAreaSize.Height;
		}
		private bool MoveRight()
		{
			if (Right == MoveAreaSize.Width) return true;

			var newRight = Right + MoveAmount;

			var right = newRight > MoveAreaSize.Width ? MoveAreaSize.Width : newRight;
			Left = right - Width;
			return Right == MoveAreaSize.Width;
		}
		private bool MoveLeft()
		{
			if (Left == 0) return true;

			var newLeft = Left - MoveAmount;

			Left = newLeft < 0 ? 0 : newLeft;

			return Left == 0;
		}



	}
}
