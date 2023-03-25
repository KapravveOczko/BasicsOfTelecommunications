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


        public void encodeText(string[] input)
        {
            //input = text to translate

            string output = "";
            string tmpWord = "";
            int[] word = new int[8];

            //output is a encoded textusing G matrix
            // tmpWord ia a buffor variable used to hold word before converting it to int[]
            //word[] is a variable used dor encodWord function

            for (int i=0; i!= input.Length; i++) 
            {

            }

        }

        public void encodeWord(int[] word)
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
        }


        public void decodeWord(int[] input) 
        {
            int[] test = new int[4];
            int parrityOutput = 0;

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

            if (parrityOutput != 0)
            {
                correctError(parrityOutput, input);
            }

        }

        public void correctError(int position, int[] word) //not tested yet
        {
            //takes position of wrong bit  and repears it
            //word is 8 or 12 bits? (12 probably)

            if (word[position-1] == 0)
            {
                word[position - 1] = 1;
            }
            else
            {
                word[position - 1] = 0;
            }

        }


    }

   

}
