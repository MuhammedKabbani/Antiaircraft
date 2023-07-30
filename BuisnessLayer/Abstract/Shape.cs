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

		public new int Right
		{
			get => base.Right;
			set
			{
				Left = value - Width;
			}
		}
		public new int Bottom
		{
			get => base.Bottom;
			set
			{
				Top = value - Height;
			}
		}
		public int Center
		{
			get => Left + Width / 2;
			set => Left = value - Width / 2; 
		}
		public int Middle
		{
			get => (Top + Height) / 2;
			set => Top = value - Height / 2;
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

			Bottom = newBottom > MoveAreaSize.Height ? MoveAreaSize.Height : newBottom;

			return Bottom == MoveAreaSize.Height;
		}
		private bool MoveRight()
		{
			if (Right == MoveAreaSize.Width) return true;

			var newRight = Right + MoveAmount;

			Right= newRight > MoveAreaSize.Width ? MoveAreaSize.Width : newRight;

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
