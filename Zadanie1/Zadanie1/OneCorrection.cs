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
    }
}
