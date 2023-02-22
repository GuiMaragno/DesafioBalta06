using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option = "1";

            do
            {
                Console.Clear();

                Console.WriteLine("\tDesafio do Balta 06\n");

                string text = TextView.GetText();

                if (text.Length != 8)
                {
                    Console.WriteLine("\n** O texto tem que possuir 8 caracteres! **\n");
                } else
                {
                    string publicKey = TextView.GetPublicKey();

                    if (publicKey.Length != 8)
                    {
                        Console.WriteLine("\n** A chave pública tem que possuir no mínimo 8 caracteres! **\n");
                    } else
                    {
                        string criptographyText = Cryptography.GetTextEncrypted(text, publicKey);

                        TextView.Result(text, publicKey, criptographyText);
                    }
                }

                option = TextView.GetOption();
            } while (option != "0");
        }
    }
}
