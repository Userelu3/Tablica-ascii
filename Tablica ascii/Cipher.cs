using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tablica_ascii
{
    class Cipher
    {
        public static string CaesarCypher(string text)
        {
            text = text.ToUpper().Replace(" ", "");
            char[] charArray = text.ToCharArray();
            string output = String.Empty;
            foreach (char c in charArray)
            {
                int charValue = (int)c;
                charValue += 3;
                if (charValue > 90)
                {
                    charValue -= 26;
                }
                char result = (char)charValue;
                output += result;
            }
            return output;
        }
        public static string DictionaryCaesar(string text) 
        { 
        Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('A', 'D');
            dict.Add('B', 'E');
            dict.Add('C', 'F');
            dict.Add('D', 'G');
            dict.Add('E', 'H');
            dict.Add('F', 'I');
            dict.Add('G', 'J');
            dict.Add('H', 'K');
            dict.Add('I', 'L');
            dict.Add('J', 'M');
            dict.Add('K', 'N');
            dict.Add('L', 'O');
            dict.Add('M', 'P');
            dict.Add('N', 'Q');
            dict.Add('O', 'R');
            dict.Add('P', 'S');
            dict.Add('Q', 'T');
            dict.Add('R', 'U');
            dict.Add('S', 'V');
            dict.Add('T', 'W');
            dict.Add('U', 'X');
            dict.Add('V', 'Y');
            dict.Add('W', 'Z');
            dict.Add('X', 'A');
            dict.Add('Y', 'B');
            dict.Add('Z', 'C');


            text = text.ToUpper().Replace(" ", "");


            char[] charArray = text.ToCharArray();


            string output = String.Empty;


            foreach (char c in charArray)


            {


                output += dict[c];


            }


            return output;
   
        }   
        public static string GaderypolukiCipher(string text)
        {
           Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('A', 'G');
            dict.Add('G', 'A');
            dict.Add('D', 'E');
            dict.Add('E', 'D');
            dict.Add('R', 'Y');
            dict.Add('Y', 'R');
            dict.Add('P', 'O');
            dict.Add('O', 'P');
            dict.Add('L', 'U');
            dict.Add('U', 'L');
            dict.Add('K', 'I');
            dict.Add('I', 'K');
            dict.Add('B', 'B');
            dict.Add('C', 'C');
            dict.Add('F', 'F');
            dict.Add('H', 'H');
            dict.Add('J', 'J');
            dict.Add('M', 'M');
            dict.Add('N', 'N');
            dict.Add('Q', 'Q');
            dict.Add('S', 'S');
            dict.Add('T', 'T');
            dict.Add('V', 'V');
            dict.Add('W', 'W');
            dict.Add('X', 'X');
            dict.Add('Z', 'Z');

            text = text.ToUpper().Replace(" ", "");


            char[] charArray = text.ToCharArray();


            string output = String.Empty;


            foreach (char c in charArray)


            {


                output += dict[c];


            }


            return output;




        } 
    }  
    
}
