using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_Software_C_Coding_Challenge
{
    public class OldPhoneLogica
    {
        string[] teclado = new string[]
        {
            "", //Comodidad
            "&'(",
            "ABC",
            "DEF",
            "GHI",
            "JKL",
            "MNO",
            "PQRS",
            "TUV",
            "WXYZ",
            " "
        };
        public string OldPhoneCheckMsg(string textN)
        {
            if (textN.Contains("#"))
            {
                return OldPhonePad(textN);
            }
            return OldPhonePad(textN+"#");
        }
        public string OldPhonePad(string textN)
        {
            char a = textN[0];
            char a1;
            int c = 0;
            string res = "";
            for(int i = 0; i < textN.Length; i++)
            {
                a1 = textN[i];
                bool v = a1!='#' && a1!=' ' && a1!='*';
                if (a1 == '#')
                {
                    res += ToCharC(c, a);
                }
                if (a1==a && v )
                {
                    c++;
                }else if(v)
                {
                    res += ToCharC(c, a);
                    a=a1;
                    c=1;
                }
                if (a1==' ')
                {
                    res += ToCharC(c, a);
                    c = 0;
                    a = ' ';
                }               
                if (a1 == '*')
                {
                    if (res.Length > 0)
                        res = res.Substring(0, res.Length);
                    c = 0;
                }
                if (a1 == '0')
                {
                    res += " ";
                    c = 0;
                    a = ' ';
                }

            }
            return res;
        }

        public string ToCharC(int c, char a1)
        {
            int i = a1 - '0';
            if (c <= 0 || i < 0 || i >= teclado.Length)
                return "";

            string letras = teclado[i];
            if (string.IsNullOrEmpty(letras))
                return "";

            return letras[(c - 1) % letras.Length].ToString();
        }
    }
}
