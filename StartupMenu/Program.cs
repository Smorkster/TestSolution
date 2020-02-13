using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace StartupMenu
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] exclude = new[] { ".vs", "packages", "StartupMenu"};
			DirectoryInfo assemblies = new DirectoryInfo (Environment.CurrentDirectory);
			DirectoryInfo top = assemblies.Parent.Parent.Parent;
			List<Button> buttons = new List<Button>();
			foreach (DirectoryInfo d in top.EnumerateDirectories().Where(x => !exclude.Contains(x.Name)).OrderBy(x=> x.Name))
			{
				Button t = new Button
				{
					Name = "btn" + d.Name,
					Text = d.Name,
					AutoSize = true,
					AutoSizeMode = AutoSizeMode.GrowAndShrink
				};
				t.Click += delegate {
					string exe = $@"{d.FullName}\bin\Debug\{d.Name}.exe";
					Process.Start(exe);
				};
				buttons.Add(t);
			}
			new StartUp(buttons).ShowDialog();
		}
	}
}
