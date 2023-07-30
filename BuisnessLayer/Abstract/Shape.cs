using System.Windows.Forms;

namespace BuisnessLayer.Abstract
{
	internal abstract class Shape : PictureBox
	{
		protected Shape()
		{
			SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		}
	}
}
