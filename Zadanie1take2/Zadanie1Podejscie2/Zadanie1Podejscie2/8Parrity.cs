using System;
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
    internal class Parrity8
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

        public static int hMatrixColumns = 8;
        public static int firstErrorPosibility = -1;
        public static int secondErrorPosibility = -1;

        /*
---------------------------------------------------------------------------------------------------------------------
         Decode
---------------------------------------------------------------------------------------------------------------------

    1.  Funkcja "Decode" jest funkcją statyczną, która przyjmuje jeden argument typu string o nazwie "input".

    2.  Zmienna "decoded" jest inicjalizowana jako pusty ciąg znaków.

    3.  Pętla "for" iteruje przez długość ciągu "input" z krokiem 16, co oznacza, że w każdej iteracji pętli zostanie zdekodowany 16-bitowy podciąg ciągu "input".

    4.  W każdej iteracji pętli, funkcja wywołuje funkcję "Decode16bits", która przyjmuje jako argument podciąg 16-bitowy ciągu "input".

    5.  Wynik zwracany przez funkcję "Decode16bits" jest dodawany do zmiennej "decoded".

    6.  Po zakończeniu pętli, funkcja zwraca zdekodowany ciąg znaków "decoded".

    7.  Funkcja "Decode16bits" nie jest widoczna w tym fragmencie kodu, ale musi istnieć, aby kod mógł działać poprawnie.

    8.  Funkcja "Decode" może być przydatna w przypadku przetwarzania danych w formacie binarnym, w którym dane są reprezentowane w postaci ciągu bitów.

    9.  Funkcja "Decode" może również służyć do przekształcania ciągu bitów na inny format danych, np. na liczbę całkowitą lub ciąg znaków w zależności od zastosowania.

---------------------------------------------------------------------------------------------------------------------
         */
        public static string Decode(string input)
        {
            string decoded = "";

            for (int i = 0; i < input.Length; i += 16)
            {
                decoded += Decode16bits(input.Substring(i, 16));
            }

            return decoded;
        }

        /*
---------------------------------------------------------------------------------------------------------------------
         Decode16bits
---------------------------------------------------------------------------------------------------------------------

    1.  Funkcja "Decode16bits" jest funkcją statyczną, która przyjmuje jeden argument typu string o nazwie "input".

    2.  Zmienna "HE" jest inicjalizowana za pomocą funkcji "CalculateHamming", która przyjmuje jako argumenty ciąg bitów "input", liczby kolumn macierzy Hamminga "hMatrixColumns" oraz samą macierz Hamminga "hMatrix". Wynik tej funkcji określa, czy wystąpił błąd transmisji w ciągu bitów.

    3.  Zmienne "ePo1" i "ePo2" są inicjalizowane jako -1 i będą zawierać pozycję błędu w ciągu bitów "input", jeśli taki błąd został wykryty.

    4.  Pętla "for" iteruje przez 16 bitów ciągu "input" i szuka pozycji, gdzie wystąpił błąd.

    5.  Pierwszy warunek sprawdza, czy w ciągu "HE" wystąpił jeden błąd, który jest równy jednej z kolumn macierzy Hamminga. Jeśli tak, to zmienna "ePo1" zostanie ustawiona na pozycję błędu i pętla zostanie przerwana.

    6.  Drugi warunek sprawdza, czy w ciągu "HE" wystąpiły dwa błędy, które są sumą dwóch kolumn macierzy Hamminga. Jeśli tak, to zmienne "ePo1" i "ePo2" zostaną ustawione na pozycje błędów i pętla zostanie przerwana.

    7.  Funkcja "CorrectErrorReturnWord" jest wywoływana dla ciągu "input" i pozycji błędu, aby naprawić błąd.

    8.  Wynik zwracany przez funkcję "Decode16bits" to zdekodowany ciąg bitów, który może zawierać jedną lub dwie poprawki błędów.

    9.  Funkcja "Decode16bits" korzysta z funkcji zdefiniowanych w innych miejscach kodu, takich jak "CalculateHamming", "GetCollumns", "SumCollums" i "CorrectErrorReturnWord".

    10. Funkcja "Decode16bits" może być przydatna w przypadku przetwarzania danych, które zostały zakodowane za pomocą kodu Hamminga, a które mogą zawierać błędy transmisji. Funkcja ta pomaga naprawić te błędy i zwraca zdekodowany ciąg bitów.

---------------------------------------------------------------------------------------------------------------------
         */
        public static string Decode16bits(string bitsString)
        {
            string HE = Functions.CalculateHamming(bitsString, hMatrixColumns, hMatrix, 16);

            int ePo1 = -1, ePo2 = -1;

            for (int i = 0; i < 16; i++) //Searching where error occurred
            {
                if (HE.Equals(Functions.GetCollumns(hMatrix, i, hMatrixColumns))) //Search for 1 error (HE column same with one of HMatrix column)
                {
                    ePo1 = i;
                    break;
                }
                for (int j = i + 1; j < 16; j++)
                {
                    if (HE.Equals(Functions.SumCollums(hMatrix, i, j))) //Search for 2 error (HE column same with sum of two HMatrix columns)
                    {
                        ePo1 = i;
                        ePo2 = j;
                        break;
                    }
                }
            }
            string buffor = ePo1 != -1 ? Functions.CorrectErrorReturnWord(bitsString, ePo1) : bitsString.Substring(0, 8); //Change the bit where error occurred
            return ePo2 != -1 ? Functions.CorrectErrorReturnWord(buffor, ePo2) : buffor.Substring(0, 8); //Change the bit where error occurred
        }
    }
}
