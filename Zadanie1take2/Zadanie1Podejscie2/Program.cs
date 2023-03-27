// See https://aka.ms/new-console-template for more information
using Zadani1Podejscie2;

Console.WriteLine("Hello, World!");

// SINGLE CORRECTION

// Encoding
string m = "abecadlo 123";
string encoded = Utils.Encode(m, SingleCorrection.numberOfHMatrixColumns, SingleCorrection.hMatrix);
Console.WriteLine("Encoded: " + encoded);
encoded = encoded[0] == '1' ? '0' + encoded.Substring(1) : '1' + encoded.Substring(1);
Console.WriteLine("Encoded: " + encoded);

// Decoding
string decoded = SingleCorrection.DecodeToBinary(encoded);
string decodedString = Utils.DecodeBinaryToString(decoded);
Console.WriteLine(decodedString);

// DOUBLE CORRECTION

// Encoding
Console.WriteLine("Podwójna korekcja");
string m2 = "abecadlo 123";
string encoded2 = Utils.Encode(m2, DoubleCorrection.numberOfHMatrixColumns, DoubleCorrection.hMatrix);
Console.WriteLine("Encoded:        " + encoded2);
encoded2 = encoded2[0] == '1' ? '0' + encoded2.Substring(1) : '1' + encoded2.Substring(1);
encoded2 = encoded2[2] == '1' ? encoded2.Substring(0, 2) + '0' + encoded2.Substring(3) : encoded2.Substring(0, 2) + '1' + encoded2.Substring(3);
Console.WriteLine("Encoded bledny: " + encoded2);

// Decoding
decoded = DoubleCorrection.Decode(encoded2);
Console.WriteLine("Poprawiony zdekodowany:" + decoded);
decodedString = Utils.DecodeBinaryToString(decoded);
Console.WriteLine(decodedString);

// int parseInt = Convert.ToInt32("011101000110", 2);
// int parseInt2 = Convert.ToInt32("01110100", 2);
// char c = (char)parseInt;
// char c2 = (char)parseInt2;
// Console.WriteLine(c);
// Console.WriteLine(c2);