using System;

namespace InterpretadorDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string texto =  "     __  __      __  __ __   __  __  __ \n" +
            //                "  |  __| __||__||__ |__   | |__||__||  |\n" +
            //                "  | |__  __|   | __||__|  | |__| __||__|\n";

            string texto = "     __  __      __  __  __ \n" +
                           "  |  __| __||__||__||__||  |\n" +
                           "  | |__  __|   ||__| __||__|\n";


            System.IO.StringReader leitorTexto = new System.IO.StringReader(texto);

            string primeiraLinha = leitorTexto.ReadLine();

            string segundaLinha = leitorTexto.ReadLine();

            string terceiraLinha = leitorTexto.ReadLine();

            char[] linha1 = primeiraLinha.ToCharArray();

            char[] linha2 = segundaLinha.ToCharArray();

            char[] linha3 = terceiraLinha.ToCharArray();

            int convertNumero = 0;

            string strLinha1 = "";
            string strLinha2 = "";
            string strLinha3 = "";

            int contador = 0;

            for (int i = 0; i < linha3.Length; i++)
            {
                strLinha1 += linha1[i];
                strLinha2 += linha2[i];
                strLinha3 += linha3[i];

                if (strLinha1 == "    " && strLinha2 == "  | " && strLinha3 == "  | ")
                {
                    convertNumero = 1;
                }

                if (strLinha1 == " __ " && strLinha2 == " __|" && strLinha3 == "|__ ")
                {
                    convertNumero = 2;
                }

                if (strLinha1 == " __ " && strLinha2 == " __|" && strLinha3 == " __|")
                {
                    convertNumero = 3;
                }

                if (strLinha1 == "    " && strLinha2 == "|__|" && strLinha3 == "   |")
                {
                    convertNumero = 4;
                }

                if (strLinha1 == " __ " && strLinha2 == "|__ " && strLinha3 == " __|")
                {
                    convertNumero = 5;
                }

                if (strLinha1 == " __ " && strLinha2 == "|__ " && strLinha3 == "|__|")
                {
                    convertNumero = 6;
                }

                if (strLinha1 == " __ " && strLinha2 == "  |" && strLinha3 == "  |")
                {
                    convertNumero = 7;
                }

                if (strLinha1 == " __ " && strLinha2 == "|__|" && strLinha3 == "|__|")
                {
                    convertNumero = 8;
                }

                if (strLinha1 == " __ " && strLinha2 == "|__|" && strLinha3 == " __|")
                {
                    convertNumero = 9;
                }

                if (strLinha1 == " __ " && strLinha2 == "|  |" && strLinha3 == "|__|")
                {
                    convertNumero = 0;
                }

                contador += 1;

                if (contador == 4)
                {
                    strLinha1 = "";
                    strLinha2 = "";
                    strLinha3 = "";

                    
                    contador = 0;
                    Console.Write(convertNumero);
                }
            }
            Console.ReadLine();
        }
    }
}
