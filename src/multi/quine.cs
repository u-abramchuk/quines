using System;
using System.Collections.Generic;
using System.Linq;

namespace multiquine
{
	class multiquine
	{
		private static int[] csData = new [] { 9, 9, 115, 116, 97, 116, 105, 99, 32, 118, 111, 105, 100, 32, 77, 97, 105, 110, 40, 112, 97, 114, 97, 109, 115, 32, 115, 116, 114, 105, 110, 103, 91, 93, 32, 97, 114, 103, 115, 41, 10, 9, 9, 123, 10, 9, 9, 9, 105, 102, 32, 40, 97, 114, 103, 115, 46, 76, 101, 110, 103, 116, 104, 32, 61, 61, 32, 48, 32, 124, 124, 32, 97, 114, 103, 115, 91, 48, 93, 32, 61, 61, 32, 34, 99, 115, 34, 41, 10, 9, 9, 9, 123, 10, 9, 9, 9, 9, 67, 111, 110, 115, 111, 108, 101, 46, 87, 114, 105, 116, 101, 40, 10, 64, 34, 117, 115, 105, 110, 103, 32, 83, 121, 115, 116, 101, 109, 59, 10, 117, 115, 105, 110, 103, 32, 83, 121, 115, 116, 101, 109, 46, 67, 111, 108, 108, 101, 99, 116, 105, 111, 110, 115, 46, 71, 101, 110, 101, 114, 105, 99, 59, 10, 117, 115, 105, 110, 103, 32, 83, 121, 115, 116, 101, 109, 46, 76, 105, 110, 113, 59, 10, 10, 110, 97, 109, 101, 115, 112, 97, 99, 101, 32, 109, 117, 108, 116, 105, 113, 117, 105, 110, 101, 10, 123, 10, 9, 99, 108, 97, 115, 115, 32, 109, 117, 108, 116, 105, 113, 117, 105, 110, 101, 10, 9, 123, 10, 34, 41, 59, 10, 9, 9, 9, 9, 67, 111, 110, 115, 111, 108, 101, 46, 87, 114, 105, 116, 101, 76, 105, 110, 101, 40, 34, 9, 9, 112, 114, 105, 118, 97, 116, 101, 32, 115, 116, 97, 116, 105, 99, 32, 105, 110, 116, 91, 93, 32, 99, 115, 68, 97, 116, 97, 32, 61, 32, 34, 32, 43, 32, 71, 101, 116, 68, 97, 116, 97, 83, 116, 114, 105, 110, 103, 40, 99, 115, 68, 97, 116, 97, 41, 41, 59, 10, 9, 9, 9, 9, 67, 111, 110, 115, 111, 108, 101, 46, 87, 114, 105, 116, 101, 40, 71, 101, 116, 67, 111, 100, 101, 83, 116, 114, 105, 110, 103, 40, 99, 115, 68, 97, 116, 97, 41, 41, 59, 10, 9, 9, 9, 9, 67, 111, 110, 115, 111, 108, 101, 46, 87, 114, 105, 116, 101, 40, 10, 64, 34, 9, 125, 10, 125, 34, 41, 59, 10, 9, 9, 9, 125, 10, 9, 9, 125, 10, 10, 9, 9, 112, 114, 105, 118, 97, 116, 101, 32, 115, 116, 97, 116, 105, 99, 32, 115, 116, 114, 105, 110, 103, 32, 71, 101, 116, 68, 97, 116, 97, 83, 116, 114, 105, 110, 103, 40, 73, 69, 110, 117, 109, 101, 114, 97, 98, 108, 101, 60, 105, 110, 116, 62, 32, 100, 97, 116, 97, 41, 10, 9, 9, 123, 10, 9, 9, 9, 114, 101, 116, 117, 114, 110, 32, 34, 110, 101, 119, 32, 91, 93, 32, 123, 32, 34, 32, 43, 32, 83, 116, 114, 105, 110, 103, 46, 74, 111, 105, 110, 40, 34, 44, 32, 34, 44, 32, 100, 97, 116, 97, 46, 83, 101, 108, 101, 99, 116, 40, 95, 32, 61, 62, 32, 95, 46, 84, 111, 83, 116, 114, 105, 110, 103, 40, 41, 41, 41, 32, 43, 32, 34, 125, 59, 34, 59, 10, 9, 9, 125, 10, 10, 9, 9, 112, 114, 105, 118, 97, 116, 101, 32, 115, 116, 97, 116, 105, 99, 32, 115, 116, 114, 105, 110, 103, 32, 71, 101, 116, 67, 111, 100, 101, 83, 116, 114, 105, 110, 103, 40, 73, 69, 110, 117, 109, 101, 114, 97, 98, 108, 101, 60, 105, 110, 116, 62, 32, 100, 97, 116, 97, 41, 10, 9, 9, 123, 10, 9, 9, 9, 114, 101, 116, 117, 114, 110, 32, 110, 101, 119, 32, 83, 116, 114, 105, 110, 103, 40, 100, 97, 116, 97, 46, 83, 101, 108, 101, 99, 116, 40, 95, 32, 61, 62, 32, 40, 99, 104, 97, 114, 41, 32, 95, 41, 46, 84, 111, 65, 114, 114, 97, 121, 40, 41, 41, 59, 10, 9, 9, 125, 10 };
		static void Main(params string[] args)
		{	
			if (args.Length == 0 || args[0] == "cs")
			{
				Console.Write(
@"using System;
using System.Collections.Generic;
using System.Linq;

namespace multiquine
{
	class multiquine
	{
");
				Console.WriteLine("		private static int[] csData = " + GetDataString(csData));
				Console.Write(GetCodeString(csData));
				Console.Write(
@"	}
}");
			}
		}

		private static string GetDataString(IEnumerable<int> data)
		{
			return "new [] { " + String.Join(", ", data.Select(_ => _.ToString())) + "};";
		}

		private static string GetCodeString(IEnumerable<int> data)
		{
			return new String(data.Select(_ => (char) _).ToArray());
		}
	}
}
