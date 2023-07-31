using BuisnessLayer.Abstract;
using System.Drawing;

namespace BuisnessLayer.Concrate
{
	internal class Bullet : Shape
	{
		public Bullet(Size moveAreaSize,int centerAirCraft) : base(moveAreaSize)
		{
			Image = Image.FromFile(@"Images\Bullet.png");
			MoveAmount =(int)(Height * .15);
			SetFirstLocation(centerAirCraft);
		}
		private void SetFirstLocation(int centerAirCraft)
		{
			Bottom = MoveAreaSize.Height;
			Center = centerAirCraft;
		}
	}
}
