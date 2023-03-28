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
    internal class Parrity4
    {

        public static int[][] hMatrix = {
            new int[]{1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0},
            new int[]{1, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 0},
            new int[]{0, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 0},
            new int[]{0, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 1}
        };

        public static int hMatrixColumns = 4;
        public static int errorPossible = -1;

        /**
---------------------------------------------------------------------------------------------------------------------
         DecodeWord
---------------------------------------------------------------------------------------------------------------------

    1.  Funkcja DecodeWord dekoduje ciąg bitów, który został zakodowany za pomocą kodu Hamminga.

    2.  Zmienna bitsString jest wejściowym ciągiem bitów, który ma zostać zdekodowany.

    3.  Funkcja CalculateHamming oblicza ciąg Hamminga dla wejściowego ciągu bitów, używając macierzy Hamminga zdefiniowanej w innej części kodu.

    4.  Zmienna heMatrix przechowuje wynik obliczenia ciągu Hamminga dla wejściowego ciągu bitów.

    5.  Zmienna errorPossible jest używana do przechowywania informacji o możliwym błędzie w wejściowym ciągu bitów. Domyślnie jest ustawiana na -1, co oznacza, że nie ma błędów.

    6.  Pętla for przechodzi przez każdą kolumnę macierzy Hamminga i porównuje ją z ciągiem Hamminga wejściowego ciągu bitów.

    7.  Jeśli porównanie jest prawdziwe, to zmienna errorPossible jest ustawiana na indeks kolumny.

    8.  Zwracany ciąg bitów ma długość 8 i reprezentuje zdekodowane dane.

    9.  Funkcja CorrectErrorReturnWord koryguje bit, w którym wystąpił błąd, a jeśli błędu nie ma, funkcja zwraca pierwsze 8 bitów wejściowego ciągu bitów.

---------------------------------------------------------------------------------------------------------------------
         */
        public static string DecodeWord(string bitsString)
        {
            string heMatrix = Functions.CalculateHamming(bitsString, hMatrixColumns, hMatrix, 12);
            errorPossible = -1;
            for (int i = 0; i < 12; i++)
            {
                if (Functions.GetCollumns(hMatrix, i, hMatrixColumns).Equals(heMatrix))  //Diff occurs on the bit where column is the same as HE
                {
                    errorPossible = i;
                }
            }
            return errorPossible != -1 ? Functions.CorrectErrorReturnWord(bitsString, errorPossible) : bitsString.Substring(0, 8); //Change the bit where error occured
        }

        /**

---------------------------------------------------------------------------------------------------------------------
         DecodeToBinary
---------------------------------------------------------------------------------------------------------------------

    1.  Metoda DecodeToBinary dekoduje ciąg zakodowany w formacie Hamminga o długości wielokrotności 12.

    2.  Dekodowanie odbywa się poprzez podział zakodowanego ciągu na 12-bitowe słowa, które następnie przekazywane są do metody DecodeWord z klasy Parity4 w celu wykonania dekodowania Hamminga.

    3.  Każde 12-bitowe słowo zostaje zdekodowane i dołączone do ciągu zdekodowanych danych decoded.

    4.  Zdekodowany ciąg jest zwracany jako wynik działania metody.

---------------------------------------------------------------------------------------------------------------------
         */
        public static string DecodeToBinary(string encoded)
        {
            string decoded = "";

            for (int i = 0; i < encoded.Length; i += 12)
            {
                decoded += Parrity4.DecodeWord(encoded.Substring(i, 12));
            }

            return decoded;
        }


    }
}
