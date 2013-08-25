using System;

namespace multiquine
{
	class multiquine
	{
		private static int[] csData = new [] { 9, 9, 115, 116, 97, 116, 105, 99, 32, 118, 111, 105, 100, 32, 77, 97, 105, 110, 40, 112, 97, 114, 97, 109, 115, 32, 115, 116, 114, 105, 110, 103, 91, 93, 32, 97, 114, 103, 115, 41, 10, 9, 9, 123, 10, 9, 9, 9, 105, 102, 32, 40, 97, 114, 103, 115, 46, 76, 101, 110, 103, 116, 104, 32, 61, 61, 32, 48, 32, 124, 124, 32, 97, 114, 103, 115, 91, 48, 93, 32, 61, 61, 32, 34, 99, 115, 34, 41, 10, 9, 9, 9, 123, 10, 9, 9, 9, 9, 67, 111, 110, 115, 111, 108, 101, 46, 87, 114, 105, 116, 101, 40, 64, 34, 117, 115, 105, 110, 103, 32, 83, 121, 115, 116, 101, 109, 59, 10, 10, 110, 97, 109, 101, 115, 112, 97, 99, 101, 32, 109, 117, 108, 116, 105, 113, 117, 105, 110, 101, 10, 123, 10, 9, 99, 108, 97, 115, 115, 32, 109, 117, 108, 116, 105, 113, 117, 105, 110, 101, 10, 9, 123, 10, 34, 41, 59, 10, 9, 9, 9, 9, 67, 111, 110, 115, 111, 108, 101, 46, 87, 114, 105, 116, 101, 40, 34, 9, 9, 112, 114, 105, 118, 97, 116, 101, 32, 115, 116, 97, 116, 105, 99, 32, 105, 110, 116, 91, 93, 32, 99, 115, 68, 97, 116, 97, 32, 61, 32, 110, 101, 119, 32, 91, 93, 32, 123, 32, 34, 41, 59, 10, 9, 9, 9, 9, 102, 111, 114, 101, 97, 99, 104, 32, 40, 118, 97, 114, 32, 99, 111, 100, 101, 32, 105, 110, 32, 99, 115, 68, 97, 116, 97, 41, 10, 9, 9, 9, 9, 123, 10, 9, 9, 9, 9, 9, 67, 111, 110, 115, 111, 108, 101, 46, 87, 114, 105, 116, 101, 40, 99, 111, 100, 101, 32, 43, 32, 34, 44, 32, 34, 41, 59, 10, 9, 9, 9, 9, 125, 10, 9, 9, 9, 9, 67, 111, 110, 115, 111, 108, 101, 46, 87, 114, 105, 116, 101, 76, 105, 110, 101, 40, 34, 32, 125, 59, 34, 41, 59, 10, 9, 9, 9, 9, 102, 111, 114, 101, 97, 99, 104, 40, 118, 97, 114, 32, 99, 111, 100, 101, 32, 105, 110, 32, 99, 115, 68, 97, 116, 97, 41, 10, 9, 9, 9, 9, 123, 10, 9, 9, 9, 9, 9, 67, 111, 110, 115, 111, 108, 101, 46, 87, 114, 105, 116, 101, 40, 67, 111, 110, 118, 101, 114, 116, 46, 84, 111, 67, 104, 97, 114, 40, 99, 111, 100, 101, 41, 41, 59, 10, 9, 9, 9, 9, 125, 10, 9, 9, 9, 9, 67, 111, 110, 115, 111, 108, 101, 46, 87, 114, 105, 116, 101, 40, 64, 34, 9, 125, 10, 125, 34, 41, 59, 10, 9, 9, 9, 125, 10, 9, 9, 125, 10, };
		static void Main(params string[] args)
		{	
			if (args.Length == 0 || args[0] == "cs")
			{
				Console.Write(@"using System;

namespace multiquine
{
	class multiquine
	{
");
				Console.Write("		private static int[] csData = new [] { ");
				foreach (var code in csData)
				{
					Console.Write(code + ", ");
				}
				Console.WriteLine(" };");
				foreach(var code in csData)
				{
					Console.Write(Convert.ToChar(code));
				}
				Console.Write(@"	}
}");
			}
		}
	}
}
