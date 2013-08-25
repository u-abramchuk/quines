/*

to get source code representation as int[]:
1. convert the source code into array of strings
2. escape double quotes in each string
3. join all the strings
4. convert each symbol into int

*/

using System;
using System.Text;
using System.Linq;

namespace multiquine
{
	class Helper
	{
		public static void Main()
		{
			var cs1Data = new [] {
"using System;",
"",
"namespace multiquine",
"{",
"	class multiquine",
"	{",
"		static void Main(params string[] args)",
"		{",
"			var csData = new [] {",
"			};",
"			if (args.Length == 0 || args[0] == \"cs\")",
"			{",
"				for (var i = 0; i < 9; i++)",
"				{",
"					Console.WriteLine(csData[i]);",
"				}",
"				for (var i = 0; i < csData.Length; i++)",
"				{",
"					Console.WriteLine(Convert.ToChar(34) + csData[i] + Convert.ToChar(34) + ',');",
"				}",
"				for (var i = 9; i < csData.Length; i++)",
"				{",
"					Console.WriteLine(csData[i]);",
"				}",
"			}",
"		}",
"	}",
"}",
			};

			var csData = new [] {
"		static void Main(params string[] args)",
"		{",
"			if (args.Length == 0 || args[0] == \"cs\")",
"			{",
"				Console.Write(",
"@\"using System;",
"using System.Collections.Generic;",
"using System.Linq;",
"",
"namespace multiquine",
"{",
"	class multiquine",
"	{",
"\");",
"				Console.WriteLine(\"		private static int[] csData = \" + GetDataString(csData));",
"				Console.Write(GetCodeString(csData));",
"				Console.Write(",
"@\"	}",
"}\");",
"			}",
"		}",
"",
"		private static string GetDataString(IEnumerable<int> data)",
"		{",
"			return \"new [] { \" + String.Join(\", \", data.Select(_ => _.ToString())) + \"};\";",
"		}",
"",
"		private static string GetCodeString(IEnumerable<int> data)",
"		{",
"			return new String(data.Select(_ => (char) _).ToArray());",
"		}",
			};

			var cs = new StringBuilder();
			foreach (var row in csData)
			{
				cs.AppendLine(row);
			}
			var result = cs.ToString().Select(x => (int) x).ToArray();
			Console.Write("new [] { ");
			foreach (var code in result)
			{
				Console.Write(code + ", ");
			}
			Console.Write("};");
		}
	}
}