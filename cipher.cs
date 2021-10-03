using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace WpfApp1
{
    public class cipher
    {
        public static char OnClick(string text)
        {
            char input = text [1];
            return input;
        }
        
        public static string Cesar(string text)
        {
            
            byte[] ASCIIvalues = Encoding.ASCII.GetBytes(text);
            var NewText= new List<char>();
            foreach(var value in ASCIIvalues)
            {
                int NewVal = value + 1;
                char c = (char) NewVal;
                NewText.Add(c);
            }
            string NewString = string.Join("", NewText.ToArray());
            return NewString;
        }

        public static string Binary(string text)
        {
            StringBuilder Binaire = new StringBuilder();

            foreach (char carca in text)
            {
                Binaire.Append(Convert.ToString(carca, 2).PadLeft(8, '0'));
            }
            return Binaire.ToString();
        }
        
        public static string VigenèreCipher(string text, string key)
        {
            string first_key = "azertyuiopqsdfghjklmwxcvbn";
            text=text.ToLower();
            var NewText= new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                int ValLettre = first_key.IndexOf(text[i]);
                int ValInKey = first_key.IndexOf(key[i]);
                int ValFinale = (ValLettre + ValInKey) % 26;
                NewText.Add(first_key[ValFinale]);
            }
            string NewString = string.Join("", NewText.ToArray());
            return NewString;
        }
    }
}