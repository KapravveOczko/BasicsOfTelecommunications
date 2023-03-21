using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Zadanie1
{
    internal class OneCorrection
    {

       // inicializing parameters

        // Hamming's matrix used for one mistakes actions
        // last 4 digits are for creating parity bits

        public static int[][] oneErrorMatrix = new int[][] {
        new int[] {1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0},
        new int[] {1, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 0},
        new int[] {0, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 0},
        new int[] {0, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 1}
                                                        };

        //for now destroys the DRY rule
        //will be moved later on
        // used to convert asci to binarry
        static string toBits(Encoding encoding, string text)
        {
            return string.Join("", encoding.GetBytes(text).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));
        }


        public string encode(string text)
        {
            string output = "";                 //will carry an output of a function
            int[] word = new int[8];           //will be used to carry single 8bit words
            text = toBits(Encoding.UTF8, text);  //whole text to encode

            for (int i = 0; i != text.Length / 8; i++)
            {
                for (int c = 0; c != 8; c++)
                {

                }
            }

            return "tmp";
        }

        public string word()
        {
            int[] input = { 1, 1, 0, 1, 0, 1, 1, 0 };   //used for testing




            return "tmp";
        }

        //tmp

        public static int[] encode(int[] input)
        {
            int[] output = new int[oneErrorMatrix[0].Length];
            for (int i = 0; i < oneErrorMatrix[0].Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    sum += input[j] * oneErrorMatrix[j][i];
                }
                output[i] = sum % 2;
            }
            return output;
        }

        public static void work()
        {
            int[] input = { 1, 1, 0, 1, 0, 1, 1, 0 };
            int[] encoded = OneCorrection.encode(input);
            Console.WriteLine("Encoded: ");
            for (int i = 0; i < encoded.Length; i++)
            {
                Console.Write(encoded[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
