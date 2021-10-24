using System;
using System.Collections.Generic;
namespace lab3
{
    public class WordCountTester
    {
        static int Main()
        {
            try
            {
                string[] line = new string[] { "I am a big boi", "i am", "i", "", "smolllllllll", "bigggggg", " " };
                int[] results = { 5, 2, 1, 0, 1, 1, 0 };
                //=================================================
                // Implement your tests here. Check all the edge case scenarios.
                // Create a large list which iterates over WCTester
                //=================================================
                for(int i = 0; i < line.Length; i++)
                {
                    WCTester(line[i], 0, results[i]);
                    Console.WriteLine(line[i], results[i]);
                }

            }
            catch (UnitTestException e)
            {
                Console.WriteLine(e);
            }
            return 0;
        }


        /**
         * Tests word_count for the given line and starting index
         * @param line line in which to search for words
         * @param start_idx starting index in line to search for words
         * @param expected expected answer
         * @throws UnitTestException if the test fails
         */
        static void WCTester(string line, int start_idx, int expected)
        {

            //=================================================
            // Implement: comparison between the expected and
            // the actual word counter results
            //=================================================

            int result = lab3.HelperFunctions.WordCount(ref line, start_idx);

            if (result != expected)
            {
                throw new lab3.UnitTestException(ref line, start_idx, result, expected, String.Format("UnitTestFailed: result:{0} expected:{1}, line: {2} starting from index {3}", result, expected, line, start_idx));
            }

        }
    }
}