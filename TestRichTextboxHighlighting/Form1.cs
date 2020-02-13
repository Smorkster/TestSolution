using ScintillaNET;
using System.Drawing;
using System.Windows.Forms;

namespace TestRichTextboxHighlighting
{
	public partial class Form1 : Form
	{
		string[] funcs = { "GetText", "GetTextDC", "PrintText" };
		string[] vars = { "id", "name", "anotherName" };
		string myText = @"InputBox, anotherName, Name
InputBox, id, id
StringUpper, id, id
Loop
{ PrintText
	StringReplace, id, id, `;, `,, UseErrorLevel
	if ErrorLevel = 0
		break
} GetText
PrintText(text)
text =
(
%id%
%name%
%anotherName%
)
PrintText(text)
Click, WheelUp, 10
Sleep 200
Click, 1313, 280
Click, 1283, 440
Click, 1504, 186
Return";

		public Form1()
		{
			InitializeComponent();
			SetUpScintilla();
			scintilla1.Text = myText;
		}

		private void SetUpScintilla()
		{
			scintilla1.StyleResetDefault();
			scintilla1.Styles[Style.Default].Font = "Consolas";
			scintilla1.Styles[Style.Default].Size = 10;
			scintilla1.StyleClearAll();
			scintilla1.Styles[Style.Cpp.Word].Bold = true;
			scintilla1.Styles[Style.Cpp.Word2].Italic = true;
			scintilla1.Styles[Style.Cpp.Word2].ForeColor = Color.Blue;
			scintilla1.Lexer = Lexer.Cpp;

			string keywords = "";
			foreach (string f in funcs) { keywords = keywords + " " + f; }
			keywords = keywords.Trim();
			scintilla1.SetKeywords(0, keywords);
			keywords = "";
			foreach (string v in vars) { keywords = keywords + " " + v; }
			keywords = keywords.Trim();
			scintilla1.SetKeywords(1, keywords);
		}
	}
}
