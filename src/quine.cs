using System;

namespace quine
{
	class quine
	{
		static void Main()
		{
			const string data = @"using System;{2}{2}namespace quine{2}{{{2}	class quine{2}	{{{2}		static void Main(){2}		{{{2}			const string data = @{1}{0}{1};{2}			Console.WriteLine(data, data, '{1}', Environment.NewLine);{2}		}}{2}	}}{2}}}";
			Console.WriteLine(data, data, '"', Environment.NewLine);
		}
	}
}
