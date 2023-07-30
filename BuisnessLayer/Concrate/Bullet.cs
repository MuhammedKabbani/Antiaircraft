using BuisnessLayer.Abstract;
using DevExpress.Utils.DirectXPaint.Svg;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrate
{
	internal class Bullet : Shape
	{
		public Bullet(Size moveAreaSize,int centerAirCraft) : base(moveAreaSize)
		{
			Image = Image.FromFile(@"Images\Bullet.png");
			MoveAmount =(int)(Height * 1.5);
			SetFirstLocation(centerAirCraft);
		}
		private void SetFirstLocation(int centerAirCraft)
		{
			Bottom = MoveAreaSize.Height;
			Center = centerAirCraft;
		}
	}
}
