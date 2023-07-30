using BuisnessLayer.Abstract;

namespace BuisnessLayer.Concrate
{
	internal class AirCraft : Shape
	{
		public AirCraft(int panelWidth)
		{
			Left = (panelWidth - Width )/ 2;
		}
	}
}
