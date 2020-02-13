namespace TestRichTextboxHighlighting
{
	public static class Extentions
	{
		public static bool IsFunction(this string[] arr, string test)
		{
			foreach (string s in arr)
			{
				if (s.Equals(test))
					return true;
			}
			return false;
		}
	}
}

