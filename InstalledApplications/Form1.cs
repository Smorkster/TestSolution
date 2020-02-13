using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace InstalledApplications
{
	/// <summary>
	/// List installed application on computer
	/// </summary>
	public partial class Form1 : Form
	{
		public bool working = true;
		List<string> installs = new List<string>();
		List<string> keys = new List<string>() {
							@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall",
							@"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall"};
		List<string> editors = new List<string>
			{
				@"Notepad++"
			};

		public Form1()
		{
			InitializeComponent();
			//UsingShellPack();
			var d = new FileInfo(@"C:\Program Files (x86)\Notepad++\notepad++.exe");
		}

		void UseFindInstalls()
		{
			// The RegistryView.Registry64 forces the application to open the registry as x64 even if the application is compiled as x86 
			FindInstalls(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64), keys, installs);
			FindInstalls(RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64), keys, installs);

			installs = installs.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
			installs.Sort(); // The list of ALL installed applications
			foreach(string s in installs)
			{
				textBox1.Text = textBox1.Text + s + "\r\n";
			}
		}

		void UsingShellPack()
		{
			// https://stackoverflow.com/questions/908850/get-installed-applications-in-a-system
			// GUID taken from https://docs.microsoft.com/en-us/windows/win32/shell/knownfolderid
			var FODLERID_AppsFolder = new Guid("{1e87508d-89c2-42f0-8a7e-645a0f50ca58}");
			ShellObject appsFolder = (ShellObject)KnownFolderHelper.FromKnownFolderId(FODLERID_AppsFolder);

			foreach (var app in (IKnownFolder)appsFolder)
			{
				// The friendly app name
				string name = app.Name;
				// The ParsingName property is the AppUserModelID
				string appUserModelID = app.ParsingName; // or app.Properties.System.AppUserModel.ID
				textBox1.Text = $"{textBox1.Text}\r\n{name}";

			}
		}

		void FindInstalls(RegistryKey regKey, List<string> keys, List<string> installed)
		{
			foreach (string key in keys)
			{
				using (RegistryKey rk = regKey.OpenSubKey(key))
				{
					if (rk == null)
					{
						continue;
					}
					foreach (string skName in rk.GetSubKeyNames())
					{
						using (RegistryKey sk = rk.OpenSubKey(skName))
						{
							try
							{
								//if (!sk.GetValue("InstallLocation").ToString().Equals("") &&
								//!sk.GetValue("DisplayName").ToString().Equals(""))
								foreach (string e in editors)
								{
									if (sk.GetValue("DisplayName").ToString().Contains(e))
									{
										installed.Add(Convert.ToString($"{sk.GetValue("DisplayName")} {sk.GetValue("InstallLocation")}"));
									}
								}
							}
							catch (Exception ex)
							{ }
						}
					}
				}
			}
		}
	}
}
