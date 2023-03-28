﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadani1Podejscie2;

namespace Zadani1Podejscie2
{

    /*
Kod Hamminga (16,8) może zostać zmodyfikowany tak, aby umożliwić wykrycie i korekcję dwóch błędów. 
Działanie takiego kodu Hamminga (16,8) można opisać w następujących punktach:

    1. Dzieli się dane wejściowe na bloki po 8 bitów.

    2. Dla każdego bloku danych, kod Hamminga generuje 8 bitów kontrolnych, które są umieszczane na 8 ostatnich pozycjach 
    kanonicznie bity parzystości umieszczane są na 
        pozycjach będących potęgami liczby "2" czyli: 1, 2, 4, 8, 16, 32, 64 i 128.

    3. Na pozycjach kontrolnych umieszcza się wartości, które informują o poprawności poszczególnych bitów danych. 
    Wartości te są wyznaczane na podstawie sumy kontrolnej bitów, które mają wpływ na daną pozycję kontrolną.

    4. Aby sprawdzić poprawność otrzymanego bloku danych, kod Hamminga wykorzystuje sumę kontrolną bitów, które są przypisane do pozycji kontrolnych. 
    Jeśli suma kontrolna jest nieparzysta lub jeśli jednocześnie wystąpiły dwa błędy w bloku danych, blok danych jest uznawany za uszkodzony.

    5. W przypadku wykrycia błędu, kod Hamminga wykorzystuje informacje zawarte w bitach kontrolnych, aby określić pozycje błędnych bitów.

    6.  Następnie, kod Hamminga dokonuje korekcji błędów, odwracając wartości błędnych bitów.

Jeśli wystąpiły dwa błędy, a kod nie jest w stanie ich skorygować, blok danych jest uznawany za uszkodzony.
Działanie kodu Hamminga (16,8) z możliwością korekcji dwóch błędów umożliwia jeszcze większą niezawodność 
transmisji danych i minimalizuje ryzyko błędów w komunikacji między urządzeniami.
     */
    internal class DoubleCorrection
    {

        public static int[][] hMatrix = new int[][] {
    new int[] {0, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0},
    new int[] {1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0},
    new int[] {1, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0},
    new int[] {0, 1, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0},
    new int[] {1, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    new int[] {0, 1, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0},
    new int[] {1, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
    new int[] {0, 1, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1}
};

        public static int numberOfHMatrixColumns = 8;
        public static int errorPos1 = -1;
        public static int errorPos2 = -1;

        /**
         * Decodes encoded message (16 bits per character) to encoded message (8 bits per character) and corrects up to 2 mistakes in it.
         * @param bitsString
         * @return decoded string (8 bits per character)
         */
        public static string Decode(string bitsString)
        {
            string decoded = "";
            for (int i = 0; i < bitsString.Length; i += 16)
                decoded += Decode16bits(bitsString.Substring(i, 16));

            return decoded;
        }

        /**
         * Decode 16 bits string
         * @param bitsString 16 bits string
         * @return decoded bits string with error corrected (8 bit)
         */
        public static string Decode16bits(string bitsString)
        {
            string HE = Utils.CalculateHE(bitsString, numberOfHMatrixColumns, hMatrix, 16);
            int errorPos1 = -1;
            int errorPos2 = -1;
            for (int i = 0; i < 16; i++) //Searching where error occurred
            {
                if (HE.Equals(Utils.GetCol(hMatrix, i, numberOfHMatrixColumns))) //Search for 1 error (HE column same with one of HMatrix column)
                {
                    errorPos1 = i;
                    break;
                }
                for (int j = i + 1; j < 16; j++)
                {
                    if (HE.Equals(Utils.GetColumnSum(hMatrix, i, j))) //Search for 2 error (HE column same with sum of two HMatrix columns)
                    {
                        errorPos1 = i;
                        errorPos2 = j;
                        break;
                    }
                }
            }
            string tmp = errorPos1 != -1 ? Utils.CorrectErrorReturn8Bits(bitsString, errorPos1) : bitsString.Substring(0, 8); //Change the bit where error occurred
            return errorPos2 != -1 ? Utils.CorrectErrorReturn8Bits(tmp, errorPos2) : tmp.Substring(0, 8); //Change the bit where error occurred
        }
    }
}