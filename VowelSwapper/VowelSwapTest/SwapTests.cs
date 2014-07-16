using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VowelSwap;

namespace VowelSwapTest
{
	[TestClass]
	public class SwapTests
	{
		const string MIXED_STRING = "qadetuho";
		const string MIXED_STRING_REVERSED = "qoduteha";

		const string ALL_VOWEL_STRING = "aeuo";
		const string ALL_VOWEL_STRING_REVERSED = "ouea";

		const string NO_VOWEL_STRING = "qdth";

		const int NUMBER_OF_RANDOM_STRINGS = 20;
		const int LENGTH_OF_RANDOM_STRING = 10;

		/// <summary>
		///tests a known string with with no vowels 
		/// </summary>
		[TestMethod]
		public void KnownNoVowelString()
		{
			Assert.AreEqual(VowelSwap.Swaps.ReverseTheVowels(NO_VOWEL_STRING), NO_VOWEL_STRING);
		}

		/// <summary>
		/// tests the vowel swapper with a known string of all vowels
		/// </summary>
		[TestMethod]
		public void KnownAllVowelString()
		{
			Assert.AreEqual(VowelSwap.Swaps.ReverseTheVowels(ALL_VOWEL_STRING), ALL_VOWEL_STRING_REVERSED);
		}

		/// <summary>
		/// Tests the vowel swapper with a known string of mixed consonants and vowels
		/// </summary>
		[TestMethod]
		public void KnownMixedString()
		{
			Assert.AreEqual(VowelSwap.Swaps.ReverseTheVowels(MIXED_STRING), MIXED_STRING_REVERSED);
		}

		//test n randomly generated strings w/ output report

		/// <summary>
		/// Runs the vowel swapper with randomly generated input for the number of times set in the constants
		/// puts the traces random string and the result so one can manuall verify that it worked if one would like
		/// </summary>
		[TestMethod]
		public void RandomStrings()
		{
			for (int i = 0; i < NUMBER_OF_RANDOM_STRINGS; i++)
			{
				var input = RandomStringGenerator(LENGTH_OF_RANDOM_STRING);

				System.Diagnostics.Trace.WriteLine(string.Format("{0}:{1}", input, VowelSwap.Swaps.ReverseTheVowels(input)));

			}

			//assert is inconclusive since this merely runs the swapper, it cannot assert that the swap was
			//performed correctly.
			Assert.Inconclusive("Log must be checked");

		}


		/// <summary>
		/// generates random number for use in RandomStringGenerator
		/// </summary>
		private static Random random = new Random((int)DateTime.Now.Ticks);

		/// <summary>
		/// Creates a random string
		/// owes credit to: http://stackoverflow.com/questions/1122483/random-string-generator-returning-same-string
		/// </summary>
		/// <param name="stringLength">length of string to create</param>
		/// <returns></returns>
		private string RandomStringGenerator(int stringLength = 10)
		{
			StringBuilder builder = new StringBuilder();
			char ch;
			for (int i = 0; i < stringLength; i++)
			{
				ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
				builder.Append(ch);
			}

			return builder.ToString();
		}
	}
}
