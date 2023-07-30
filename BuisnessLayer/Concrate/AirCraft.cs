using BuisnessLayer.Abstract;
using System.Drawing;

namespace BuisnessLayer.Concrate
{
	internal class AirCraft : Shape
	{
		public AirCraft(int panelWidth, Size moveAreaSize) : base (moveAreaSize)
		{
			Image = Image.FromFile(@"Images\airCraft.png");
			Left = (panelWidth - Width )/ 2;
			MoveAmount = Width;
		}
	}
}
