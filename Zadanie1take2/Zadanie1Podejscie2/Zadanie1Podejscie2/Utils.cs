using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadani1Podejscie2
{
    internal class Utils
    {

        /*
         
---------------------------------------------------------------------------------------------------------------------
         ENCODE
---------------------------------------------------------------------------------------------------------------------
         
    1.  Metoda Encode przyjmuje jako parametry wiadomość do zakodowania (message), ilość kolumn macierzy kodującej Hamminga (hMatrixColumnsNumber) oraz samą macierz kodującą Hamminga (hMatrix).
    
    2.  Zmienna result służy do przechowywania zaszyfrowanej wiadomości w postaci ciągu bitów.
    
    3.  Metoda Encoding.UTF8.GetBytes(message) zamienia podaną wiadomość na tablicę bajtów (typ byte[]), co jest niezbędne do przetworzenia jej na postać binarną.
    
    4.  Pętla foreach iteruje po wszystkich bajtach w tablicy bytesArray i przekształca każdy bajt na postać binarną, dodając brakujące zera, jeśli długość binarnej reprezentacji bajtu jest mniejsza niż 8.
    
    5.  Następnie do zaszyfrowanej wiadomości (result) dodawane są kolejno zdekodowane bity i bity kontrolne uzyskane za pomocą metody CalculateHE.
    
    6.  Metoda CalculateHE przyjmuje jako parametry ciąg bitów, ilość kolumn macierzy kodującej, samą macierz kodującą oraz ilość bitów kontrolnych do wyznaczenia. Zwraca ona ciąg bitów kontrolnych o długości podanej jako ostatni argument.
    
        Na koniec metoda Encode zwraca zaszyfrowaną wiadomość w postaci ciągu bitów.

---------------------------------------------------------------------------------------------------------------------


         */

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

        /*
---------------------------------------------------------------------------------------------------------------------
         CalculateHE
---------------------------------------------------------------------------------------------------------------------

    1.  Metoda CalculateHE przyjmuje jako parametry ciąg bitów do zakodowania (message), ilość kolumn macierzy kodującej Hamminga (hMatrixColumnsNumber), samą macierz kodującą Hamminga (hMatrix) oraz ilość bitów kontrolnych do wyznaczenia (encode).
    
    2.  Zmienna result służy do przechowywania bitów kontrolnych wyznaczonych na podstawie przetworzonej wiadomości message.

    3.  Pierwsza pętla for iteruje po kolumnach macierzy kodującej Hamminga.

    4.  Wewnętrzna pętla for iteruje po ilości bitów, które mają być kodowane przez daną kolumnę.

    5.  Zmienne originalBit i matrixBit przechowują wartości bitów dla danej kolumny macierzy kodującej i dla danego bitu w przetwarzanej wiadomości.
    
    6.  Wartość originalBit jest pobierana za pomocą metody Substring i zamieniana na typ int za pomocą metody int.Parse.

    7.  Wartość matrixBit jest pobierana z macierzy kodującej na podstawie numeru kolumny i numeru bitu w przetwarzanej wiadomości.

    8.  Zmienna rowResult przechowuje wynik mnożenia bitów dla danej kolumny macierzy kodującej i danego bitu w przetwarzanej wiadomości.

    9.  Na koniec zmienna result dodaje wynik modulo 2 z wartością rowResult, co pozwala na uzyskanie bitów kontrolnych dla danej kolumny macierzy kodującej.

    10. Metoda CalculateHE zwraca ciąg bitów kontrolnych o długości podanej jako ostatni argument.

---------------------------------------------------------------------------------------------------------------------
        */

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

        /**
         * Zwraca ciąg znaków zawierający wartości kolumny macierzy
         */

        /*
---------------------------------------------------------------------------------------------------------------------
         GetCol
---------------------------------------------------------------------------------------------------------------------

    1.  Metoda GetCol przyjmuje jako parametry dwuwymiarową macierz bitów matrix, numer kolumny, z której chcemy pobrać bity (column) oraz ilość kolumn w macierzy (numberOfColumns).

    2.  Za pomocą metody Select i wyrażenia lambda row => row[column], z dwuwymiarowej macierzy matrix wybierane są bity z kolumny column i przechowywane w tablicy bitsArray.

    3.  Zmienna result służy do przechowywania ciągu bitów z wybranej kolumny.

    4.  Pętla for iteruje po ilości kolumn w macierzy i dodaje kolejne bity z tablicy bitsArray do zmiennej result.

    5.  Metoda GetCol zwraca ciąg bitów o długości numberOfColumns z wybranej kolumny macierzy.

---------------------------------------------------------------------------------------------------------------------
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

        /*
---------------------------------------------------------------------------------------------------------------------
         GetColumnSum
---------------------------------------------------------------------------------------------------------------------        

    1.  Metoda GetColumnSum przyjmuje jako parametry dwuwymiarową macierz bitów hMatrix, numery dwóch kolumn, których bity chcemy dodać (column1 i column2).

    2.  Za pomocą metody Select i wyrażeń lambda row => row[column1] oraz row => row[column2], z dwuwymiarowej macierzy hMatrix wybierane są bity z kolumn column1 i column2 i przechowywane odpowiednio w tablicach bitsArray1 i bitsArray2.

    3.  Zmienna sum służy do przechowywania sumy bitów z dwóch wybranych kolumn.

    4.  Pętla for iteruje po długości jednej z kolumn (zakładając, że kolumny są tej samej długości) i dla każdego bitu oblicza sumę bitów z bitsArray1 i bitsArray2.

    5.  Jeśli suma bitów wynosi 2, oznacza to, że oba bity są równe 1 i należy zwrócić bit 0 (ponieważ w kodzie Hamminga wykorzystujemy arytmetykę modulo 2). W przeciwnym przypadku zwracana jest suma bitów.

    6.  Metoda GetColumnSum zwraca ciąg bitów będący sumą bitów z dwóch wybranych kolumn macierzy hMatrix.

---------------------------------------------------------------------------------------------------------------------

         */
        /**
         * Zwraca sumę dwóch kolumn macierzy.
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



        /*
---------------------------------------------------------------------------------------------------------------------
         CorrectErrorReturn8Bits
---------------------------------------------------------------------------------------------------------------------   

    1.  Metoda CorrectErrorReturn8Bits przyjmuje jako parametry ciąg bitów bitsString i pozycję bitu, którego wartość chcemy zmienić (position).

    2.  Warunek if sprawdza, czy pozycja bitu jest prawidłowa (w zakresie od 0 do 7, bo kod Hamminga (16,8) używa 8-bitowych bloków danych).

    3.  W zależności od wartości bitu na pozycji position (czy wynosi 0 czy 1), na tej pozycji zostanie zamieniony bit na przeciwny. Do tego celu wykorzystywane jest wyrażenie warunkowe - jeśli bit na pozycji position wynosi 1, to zostanie zwrócony ciąg bitów, w którym na pozycji position znajduje się 0, a w przeciwnym wypadku - 1.

    4.  Jeśli pozycja position nie jest prawidłowa, to zwracany jest ciąg bitów bez zmian.

    5.  Metoda CorrectErrorReturn8Bits zwraca ciąg bitów bitsString, w którym na pozycji position został zmieniony bit na przeciwny lub (jeśli pozycja position była nieprawidłowa) ciąg bitów bitsString bez zmian.

---------------------------------------------------------------------------------------------------------------------
         */

        /**
         * Zmienia bit na przeciwny na określonej pozycji i zwraca pierwsze 8 bitów.
         *   bitsString = zawiera łańcuch binarny
         *   position = pozycja błędu ( do zmiany )
         *   
         *   zwraca 8 bitów łańcucha binarnego
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

        /*
---------------------------------------------------------------------------------------------------------------------
         DecodeBinaryToString
---------------------------------------------------------------------------------------------------------------------   

Funkcja DecodeBinaryToString jest odpowiedzialna za konwersję ciągu binarnego na tekst w formacie UTF-8. Poniżej znajdują się komentarze do poszczególnych linii kodu:

    1.  byte[] textBytes = new byte[decoded.Length / 8]; - tworzy tablicę bajtów o rozmiarze równym długości ciągu binarnego podzielonej przez 8, ponieważ każdy znak w kodowaniu UTF-8 zajmuje 8 bitów.

    2.  for (int i = 0; i < decoded.Length; i += 8) - iteruje po każdych kolejnych 8 bitach w ciągu binarnym.

    3.  byte b = Convert.ToByte(decoded.Substring(i, 8), 2); - konwertuje ciąg 8 bitów na pojedynczy bajt, używając metody ToByte z klasy Convert.

    4.  textBytes[i / 8] = b; - przypisuje otrzymany bajt do odpowiedniej pozycji w tablicy bajtów.

    5.  return Encoding.UTF8.GetString(textBytes); - konwertuje tablicę bajtów na ciąg tekstowy w formacie UTF-8, używając metody GetString z klasy Encoding. Zwraca ostatecznie zdekodowany tekst.

---------------------------------------------------------------------------------------------------------------------
         */

        /**
         * Dekoduje ciąg binarny do tekstu.
         *  decoded = ciąg zawierający ciąg binarny.
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


    }
}
