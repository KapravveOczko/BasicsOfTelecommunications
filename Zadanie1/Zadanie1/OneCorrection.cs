using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class OneCorrection
    {

        //inicializing parameters

        // Hamming's matrix used for one mistakes actions
        // keep in mind that the last 4 digits are for creating parity bits
        public static int[][] oneErrorMatrix = new int[][] {
        new int[] {1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0},
        new int[] {1, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 0},
        new int[] {0, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 0},
        new int[] {0, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 1}
                                                        };

        public static int oeMatrixColumns = 4;
        public static int errorsExpected = -1;


    }
}
