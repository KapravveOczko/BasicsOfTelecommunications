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


    H =

    [ 1 0 0 0 1 1 0 1 0 1 1 0 ]
    [ 0 1 0 0 0 1 1 1 1 0 1 1 ]
    [ 0 0 1 0 1 0 1 1 1 1 0 1 ]
    [ 0 0 0 1 1 1 1 0 1 1 1 1 ]

        */

        public static int[][] G = new int[][] {
        new int[] {1,0,0,0,0,0,0,0,1,1,0,1}, 
        new int[] {0,1,0,0,0,0,0,0,1,0,1,1},
        new int[] {0,0,1,0,0,0,0,0,0,1,1,1},
        new int[] {0,0,0,1,0,0,0,0,1,1,1,0},
        new int[] {0,0,0,0,1,0,0,0,1,1,0,1},
        new int[] {0,0,0,0,0,1,0,0,0,1,0,1},
        new int[] {0,0,0,0,0,0,1,0,1,0,1,0},
        new int[] {0,0,0,0,0,0,0,1,0,1,1,1}
                                           };


        public static int[][] H = new int[][] {
        new int[] {1,0,0,0,1,1,0,1,0,1,1,0},
        new int[] {0,1,0,0,0,1,1,1,1,0,1,1},
        new int[] {0,0,1,0,1,0,1,1,1,1,0,1},
        new int[] {0,0,0,1,1,1,1,0,1,1,1,1}
                                           };


        public void encodeWord(int[] word)
        {
            int position=0;
            int[] output = new int[12];
            for (int i=0; i<12; i++) 
            {output[i] = 0;}

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

    }

   

}
