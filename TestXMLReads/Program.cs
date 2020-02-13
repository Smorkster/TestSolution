using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//TestXmlRead();
			TestToUpperInvariant();
		}

		static void TestToUpperInvariant()
		{
			string t = "jiojio";
			string u = "Jjijiojiojoi";
			string v = "jJJIojiojojo";
			Console.WriteLine(t.First().ToString().ToUpper() + t.Substring(1));
			Console.WriteLine(u.ToUpperInvariant());
			Console.WriteLine(v.ToUpperInvariant());
			Console.ReadLine();
		}

		static void TestXmlRead()
		{ 
			XElement e = XElement.Load(@"G:\Lit\Servicedesk\Verktyg\AutoHotKey\Gamla Skript\AHK - Standardsvar.xml");
			//XElement e2 = XElement.Load(@"H:\Dokument\AHK - Standardsvar.xml");

			var elements = e.Elements("ahkcommand").Where(x => x.Descendants().First().ToString().Contains("command"));

			foreach (XElement i in elements)
			{
				if (!i.Descendants("system").First().Value.Contains("Variables"))
				{
					Console.WriteLine(i.Descendants("command").First().Value);
					Console.WriteLine(i.Descendants("text").First().Value);
					Console.WriteLine(i.Descendants("system").First().Value);
					break;
				}
			}

			Console.ReadLine();
		}
	}
}
