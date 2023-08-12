using BuisnessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace BuisnessLayer.Concrate
{
	internal class Plane : Shape
	{

		private static readonly Random random = new Random();
		private static double _moveRatio = 0.03;
		public Plane(Size moveAreaSize) : base(moveAreaSize)
		{
			Image = Image.FromFile(@"Images\Plane.png");
			MoveAmount = (int)(Height* _moveRatio);
			SetStartPosition();
		}
		private void SetStartPosition()
		{
			Left = random.Next(MoveAreaSize.Width - Width + 1);
		}
		public Bullet IsHit(List<Bullet> bullets)
		{
			Bullet HittenBullet = null;
			foreach(var bullet in bullets)
			{
				bool isHit = bullet.Top <= Bottom && bullet.Right >= Left && bullet.Left <= Right;
				if (isHit)
				{
					HittenBullet = bullet;
					break;
				}
			}
			return HittenBullet;
		}
		
		public static void IncreaseMoveRatio()
		{
			_moveRatio += 0.001;
		}
		public static void ResetMoveRatio()
		{
			_moveRatio = 0.03;
		}
	}
}
