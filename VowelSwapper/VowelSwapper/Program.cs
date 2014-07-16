using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelSwapper
{
	class Program
	{
		/// <summary>
		/// simple runner for the dll
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			Console.WriteLine(VowelSwap.Swaps.ReverseTheVowels(args[0]));
		}
	}
}
