using System.Collections.Generic;
using System.Windows.Forms;

namespace StartupMenu
{
	public partial class StartUp : Form
	{
		public StartUp(List<Button> buttons)
		{
			InitializeComponent();
			foreach (Button b in buttons)
			{
				flpButtons.Controls.Add(b);
			}
		}
	}
}
