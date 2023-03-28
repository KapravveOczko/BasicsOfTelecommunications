using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadani1Podejscie2;

namespace Zadani1Podejscie2
{
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
