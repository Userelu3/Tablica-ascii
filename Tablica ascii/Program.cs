using Tablica_ascii;
Console.WriteLine("Podaj tekst do zaszyfrowania: ");
string text = Console.ReadLine();
string output = Cipher.CaesarCypher(text);

Console.WriteLine("Zaszyfrowany tekst: " + output);