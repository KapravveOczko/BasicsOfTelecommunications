using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Zadanie1
{
    internal class OneCorrection
    {

        /*
    G = 

    [ 1 0 0 0 0 0 0 0 1 1 0 1 ]
    [ 0 1 0 0 0 0 0 0 1 0 1 1 ]
    [ 0 0 1 0 0 0 0 0 0 1 1 1 ]
    [ 0 0 0 1 0 0 0 0 1 1 1 0 ]
    [ 0 0 0 0 1 0 0 0 1 1 0 1 ]
    [ 0 0 0 0 0 1 0 0 0 1 0 1 ]
    [ 0 0 0 0 0 0 1 0 1 0 1 0 ]
    [ 0 0 0 0 0 0 0 1 0 1 1 1 ]

        */

        public static int[][] G = new int[][] { // wrong Marix // parrity last?
        new int[] {1,0,0,0,0,0,0,0,1,1,0,1}, 
        new int[] {0,1,0,0,0,0,0,0,1,0,1,1},
        new int[] {0,0,1,0,0,0,0,0,0,1,1,1},
        new int[] {0,0,0,1,0,0,0,0,1,1,1,0},
        new int[] {0,0,0,0,1,0,0,0,1,1,0,1},
        new int[] {0,0,0,0,0,1,0,0,0,1,0,1},
        new int[] {0,0,0,0,0,0,1,0,1,0,1,0},
        new int[] {0,0,0,0,0,0,0,1,0,1,1,1}
                                           };


        public static int[][] H = new int[][] { //parity bits at end; 
        new int[] {1,1,0,1,1,0,1,1, 1,0,0,0},
        new int[] {1,0,1,1,0,1,1,1, 0,1,0,0},
        new int[] {0,1,1,1,0,0,0,1, 0,0,1,0},
        new int[] {0,0,0,0,1,1,1,1, 0,0,0,1}
                                            };


        public string encodeText(string text)
        {
            byte[] textInBytes = Encoding.UTF8.GetBytes(text);
            int[] word = new int[8];
            int position = 0;
            string encodedText = "";

            //textInBytes = holds text translated to bytes
            //word[] = holds word with will be send to encodeWord function
            //position = used to transver bits from textInBytes to word[]
            //encodedText = holds encoded text

            for (int i = 0; i!=text.Length*8; i++)
            {
                word[position] = textInBytes[i];
                if (position == 7)
                {
                    position = 0;
                }
                encodedText += encodeWord(word);
            }

            return encodedText;
        }

        public string encodeWord(int[] word)
        {
            int[] output = new int[12];
            for (int i=0; i<12; i++) 
            {
                output[i] = 0;
            }

            //position  = position of this bit in the word
            //output    = holds an output of a function

            for (int i=0; i!=8;i++) 
            {
                for (int j=0; j!=12; j++) 
                {
                    output[j] = output[j] + word[i] * G[i][j];
                }
            }

            for (int i=0; i!=12; i++)
            {
                output[i] = output[i]%2;
            }

            return bitsToStringBits(output, 12);
        }


        public void decodeText(BitArray text)
        {

        }

        public void decodeWord(int[] input) 
        {
            int[] test = new int[4];
            int parrityOutput = 0;

            string output = "";

            // test[]            = holds output of parity bits after using H matrix
            // parrityOutput     = holds position of wrong bit

            for (int i = 0; i != 12; i++)
            {
                for (int j = 0; j != 4; j++)
                {
                    test[j] = test[j] + H[j][i] * input[i];
                }
            }

            for (int i=0; i!=4; i++)
            {
                test[i] = test[i] % 2;
            }


            //checking if output of parrity bits ==0    //not tested yet
            //      makeit another function?

            for (int i=0; i!=4; i++)
            {
                if ((i==0) || (test[i]!=0)) 
                {
                    parrityOutput = parrityOutput + 1;
                }
                if ((i == 1) || (test[i] != 0))
                {
                    parrityOutput = parrityOutput + 2;
                }
                if ((i == 2) || (test[i] != 0))
                {
                    parrityOutput = parrityOutput + 3;
                }
                if ((i == 3) || (test[i] != 0))
                {
                    parrityOutput = parrityOutput + 4;
                }
            }

            //a part when we correct mistake

            if (parrityOutput != 0)
            {
                if (input[parrityOutput - 1] == 0)
                {
                    input[parrityOutput - 1] = 1;
                }
                else
                {
                    input[parrityOutput - 1] = 0;
                }
            }


        }

        public string bitsToStringBits(int[] input, int length)
        {
            string output = "";

            for (int i=0; i!= length; i++)
            {
                output = output + input[i];
            }
            return output;
        }


        public string BitToString(BitArray bits)
        {
            byte[] byteArray = new byte[(bits.Length + 7) / 8];
            bits.CopyTo(byteArray, 0);
            Encoding utf8 = Encoding.UTF8;
            string result = utf8.GetString(byteArray);

            return result;
        }
    }
   

}
