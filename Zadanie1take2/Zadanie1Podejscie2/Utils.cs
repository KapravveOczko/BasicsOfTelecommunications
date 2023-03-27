using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadani1Podejscie2
{
    internal class Utils
    {

        public static string Encode(string message, int hMatrixColumnsNumber, int[][] hMatrix)
        {
            string result = "";
            byte[] bytesArray = Encoding.UTF8.GetBytes(message);
            foreach (byte singleByte in bytesArray)
            {
                string byteToBits = "";
                if (Convert.ToString(singleByte, 2).Length != 8)
                {
                    for (int i = Convert.ToString(singleByte, 2).Length; i < 8; i++)
                        byteToBits += "0";
                    byteToBits += Convert.ToString(singleByte, 2);
                }
                result += byteToBits;
                result += CalculateHE(byteToBits, hMatrixColumnsNumber, hMatrix, 8);
            }
            return result;
        }

        public static string CalculateHE(string message, int hMatrixColumnsNumber, int[][] hMatrix, int encode)
        {
            string result = "";
            for (int i = 0; i < hMatrixColumnsNumber; i++)
            {
                int rowResult = 0;
                for (int j = 0; j < encode; j++)
                {
                    int originalBit = int.Parse(message.Substring(j, 1));
                    int matrixBit = hMatrix[i][j];
                    rowResult += originalBit * matrixBit;
                }
                result += rowResult % 2;
            }
            return result;
        }

        //-----------------------------------------------------------------------------

        //Zwróć uwagę, że przepisując kod, musiałem również przepisać metodę CalculateHE, która jest wykorzystywana w oryginalnej metodzie encode.

        //-----------------------------------------------------------------------------

        /**
         * Zwraca ciąg znaków zawierający wartości kolumny macierzy
         * @param matrix
         * @param column
         * @param numberOfColumns
         * @return
         */
        public static string GetCol(int[][] matrix, int column, int numberOfColumns)
        {
            int[] bitsArray = matrix.Select(row => row[column]).ToArray();
            string result = "";
            for (int i = 0; i < numberOfColumns; i++)
            {
                result += bitsArray[i];
            }
            return result;
        }

        //-----------------------------------------------------------------------------
        //Uwaga: w przepisanym kodzie użyłem metody Select zamiast mapToInt, ponieważ ta ostatnia jest specyficzna dla języka Java i nie jest dostępna w języku C#.
        //-----------------------------------------------------------------------------

        /**
         * Zwraca sumę dwóch kolumn macierzy.
         * @param hMatrix
         * @param column1
         * @param column2
         * @return
         */
        public static string GetColumnSum(int[][] hMatrix, int column1, int column2)
        {
            int[] bitsArray1 = hMatrix.Select(row => row[column1]).ToArray();
            int[] bitsArray2 = hMatrix.Select(row => row[column2]).ToArray();
            string sum = "";
            for (int i = 0; i < 8; i++)
            {
                sum += (bitsArray1[i] + bitsArray2[i] == 2) ? "0" : (bitsArray1[i] + bitsArray2[i]).ToString();
            }
            return sum;
        }

        /**
         * Zmienia bit na przeciwny na określonej pozycji i zwraca pierwsze 8 bitów.
         * @param bitsString łańcuch binarny
         * @param position pozycja do zmiany
         * @return 8 bitów łańcucha binarnego
         */
        public static string CorrectErrorReturn8Bits(string bitsString, int position)
        {
            if (position >= 0 && position < 8)
            {
                return (bitsString[position] == '1') ? bitsString.Substring(0, position) + '0' + bitsString.Substring(position + 1, 7 - position) :
                                                       bitsString.Substring(0, position) + '1' + bitsString.Substring(position + 1, 7 - position);
            }
            else
            {
                return bitsString.Substring(0, 8);
            }
        }

        /**
         * Dekoduje ciąg binarny do tekstu.
         * @param decoded ciąg zawierający ciąg binarny.
         * @return tekst
         */
        public static string DecodeBinaryToString(string decoded)
        {
            byte[] textBytes = new byte[decoded.Length / 8];
            for (int i = 0; i < decoded.Length; i += 8)
            {
                byte b = Convert.ToByte(decoded.Substring(i, 8), 2);
                textBytes[i / 8] = b;
            }
            return Encoding.UTF8.GetString(textBytes);
        }

        public static int BitsToInt(string bitsString)
        {
            int result = 0;
            string reversed = new string(bitsString.Reverse().ToArray());
            for (int i = 0; i < 8; i++)
            {
                string s = reversed.Substring(i, 1);
                if (s == "1")
                {
                    int temp = 1;
                    for (int j = 0; j < i; j++)
                    {
                        temp *= 2;
                    }
                    result += temp;
                }
            }
            return result;
        }

        //-----------------------------------------------------------------------

        //Zauważ, że funkcja Reverse() została użyta do odwrócenia kolejności bitów w łańcuchu bitsString, ponieważ oryginalna funkcja bitsToInt korzystała z odwróconego łańcucha. //Funkcja ToArray() została użyta do utworzenia tablicy z odwróconego łańcucha.

        //-----------------------------------------------------------------------

    }
}
