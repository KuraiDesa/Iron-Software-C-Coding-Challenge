using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Iron_Software_C_Coding_Challenge
{
    public class OldPhoneInterface
    {
        bool activo = true;
        OldPhoneLogica phone = new OldPhoneLogica();


        static void EjecutarPruebasManual(OldPhoneLogica phone)
        {
            var pruebas = new Dictionary<string, string>
            {
                ["33#"] = "E",
                ["227*#"] = "B",
                ["4433555 555666#"] = "HELLO",
                ["8 88777444666*664#"] = "TURING",
                ["999 33 7777#"] = "YES",
                ["22 2*#"] = "B",
                ["4433555 555666*2#"] = "HELLA",
                ["11172777336683377774447777111#"] = "(PARENTESIS("
            };

            Console.WriteLine("Iniciando pruebas manuales:\n");

            foreach (var par in pruebas)
            {
                string entrada = par.Key;
                string esperado = par.Value;
                string resultado = phone.OldPhonePad(entrada);

                if (resultado == esperado)
                {
                    Console.WriteLine($"O Entrada: {entrada} => {resultado}");
                }
                else
                {
                    Console.WriteLine($"X Entrada: {entrada} => {resultado} (esperado: {esperado})");
                }
            }

            Console.WriteLine("\nPruebas finalizadas.\n");
        }

        public void Interfaz()
        {
            while (activo)
            {
                Console.WriteLine("Eliga una opcion \n 1.Iniciar pruebas \n 2.Escribir un mensaje \n 3.Salir");
                string input = Console.ReadLine();
                int numero=0;
                try
                {
                    if (!int.TryParse(input, out numero))
                    {
                        Console.WriteLine("¡Error! Numero invalido \n");
                        continue;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine($"¡Error! {input} No es un número.\n");
                }
                if (numero == 1)
                {
                    EjecutarPruebasManual(phone);
                }
                else if (numero == 2)
                {
                    Console.WriteLine("Escriba su mensaje \n \r\n╔═════╦═════╦═════╗\r\n║  1  ║  2  ║  3  ║\r\n║ &'( ║ABC  ║DEF  ║\r\n╠═════╬═════╬═════╣\r\n║  4  ║  5  ║  6  ║\r\n║GHI  ║JKL  ║MNO  ║\r\n╠═════╬═════╬═════╣\r\n║  7  ║  8  ║  9  ║\r\n║PQRS ║TUV  ║WXYZ ║\r\n╠═════╬═════╬═════╣\r\n║  *  ║  0  ║  #  ║\r\n║Borra║     ║Envia║\r\n╚═════╩═════╩═════╝");
                    string input2 = Console.ReadLine();
                    Console.WriteLine(phone.OldPhoneCheckMsg(input2));
                }else if(numero == 3)
                {
                    Console.WriteLine("Gracias por su tiempo");
                    activo = false;
                }
                else
                {
                    Console.WriteLine("Opcion no valida \n");
                }
            }
        }

    }

}
