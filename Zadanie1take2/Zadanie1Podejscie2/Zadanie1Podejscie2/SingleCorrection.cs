using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadani1Podejscie2;

namespace Zadani1Podejscie2
{

    /*
     
    Kod Hamminga (12,8) to kod korekcyjny błędów, który składa się z 12 bitów, z czego 8 bitów są danymi, a pozostałe 4 są bitami kontrolnymi.
    Działanie kodu Hamminga umożliwia wykrycie i korekcję pojedynczych błędów w bloku danych, 
    co czyni go bardziej niezawodnym niż proste kody parzystości.

    Działanie kodu Hamminga (12,8) można opisać w następujących punktach:

    1.  Dzieli się dane wejściowe na bloki po 8 bitów.

    2.  Dla każdego bloku danych, kod Hamminga generuje 4 bity kontrolne, 
        które są umieszczane na 4 ostatnich pozycjach (9-12), kanonicznie bity parzystości umieszczane są na 
        pozycjach będących potęgami liczby "2" czyli: 1, 2, 4 i 8.

    3.  Aby sprawdzić poprawność otrzymanego bloku danych, kod Hamminga wykorzystuje sumę kontrolną bitów, 
        które są przypisane do pozycji kontrolnych. Jeśli suma kontrolna jest nieparzysta lub jeśli którekolwiek
        z bitów danych jest niepoprawny, blok danych jest uznawany za uszkodzony.

    4.  W przypadku wykrycia błędu, kod Hamminga może skorygować jedno z bitów danych, którego wartość jest niepoprawna. 
        W tym celu kod wykorzystuje informacje zawarte w bitach kontrolnych.

   
     
     */
    internal class SingleCorrection
    {

        public static int[][] hMatrix = {
            new int[]{1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0},
            new int[]{1, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 0},
            new int[]{0, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 0},
            new int[]{0, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 1}
        };

        public static int numberOfHMatrixColumns = 4;
        public static int errorPos1 = -1;


        /**
         * Decodes encoded message (12 bits per character) to encoded message (8 bits per character) and corrects it if needed.
         * @param encoded
         * @return
         */
        public static string DecodeToBinary(string encoded)
        {
            string decoded = "";
            for (int i = 0; i < encoded.Length; i += 12)
                decoded += SingleCorrection.DecodeSingleCharacterAndCorrect(encoded.Substring(i, 12));

            return decoded;
        }

        /**
         * Decodes string containing 12 bits and corrects it if needed
         * @param bitsString 12 bits string
         * @return decoded bits string with error corrected (8 bits)
         */
        public static string DecodeSingleCharacterAndCorrect(string bitsString)
        {
            string heMatrix = Utils.CalculateHE(bitsString, numberOfHMatrixColumns, hMatrix, 12);
            errorPos1 = -1;
            for (int i = 0; i < 12; i++)
                if (Utils.GetCol(hMatrix, i, numberOfHMatrixColumns).Equals(heMatrix))  //Diff occurs on the bit where column is the same as HE
                    errorPos1 = i;

            return errorPos1 != -1 ? Utils.CorrectErrorReturn8Bits(bitsString, errorPos1) : bitsString.Substring(0, 8); //Change the bit where error occured
        }

    }
}
