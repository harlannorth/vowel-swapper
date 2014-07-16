using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelSwap
{
	static public class Swaps
	{
		/// <summary>
		/// Swaps the first vowel found reading from the begining of a string with the first vowel found reading 
		/// from the end of string, then move on and swaps the 2nd found from the begining with the second founf
		/// from the end and so forth
		/// </summary>
		/// <param name="input">string to perform swaps on</param>
		/// <returns>string with swaps</returns>
		static public string ReverseTheVowels(string input)
		{
			//forward iterator
			int forward = 0;
			//backward iterator
			int backward = input.Length - 1;

			//indicator that something has switched
			bool swapped = false;

			//strings for output
			string output = "";
			string revOutput = "";

			//regex to detect
			System.Text.RegularExpressions.Regex vowels = new System.Text.RegularExpressions.Regex("(?i)[aeiou]");

			while (forward <= backward)
			{
				//if we get a match start moving backwards
				if (vowels.IsMatch(input[forward].ToString()))
				{
					while (swapped == false && backward >= forward)
					{
						if (backward == forward)
						{
							//if they are pointing at the same thing then output it 
							revOutput = input[forward] + revOutput;
						}
						else if (vowels.IsMatch(input[backward].ToString()))
						{
							//do 'swap' by appending the pointed at chars to the reversed output strings
							output = output + input[backward];
							revOutput = input[forward] + revOutput;
							//set swapped to true
							swapped = true;
						}
						else
						{
							//if not a vowel then append to the backward moving output string
							revOutput = input[backward] + revOutput;
						}
						backward--;
					}

				}
				else
				{
					// if not a vowel, append to the forward output string
					output = output + input[forward];
				}

				//increment the forward itorator
				forward++;

				//reset the swapped
				swapped = false;
			}

			//append the two outputs
			return output + revOutput;

		}
    }
}
