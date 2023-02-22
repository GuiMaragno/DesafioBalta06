using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta06
{
    public static class TextView
    {
        public static string GetOption()
        {
            Console.Write("-> Deseja repetir? (1 para Sim! / 0 para Não!): ");
            return Console.ReadLine();
        }

        public static string GetText()
        {
            Console.Write("Digite o texto a ser criptografado: ");
            return Console.ReadLine();
        }

        public static string GetPublicKey()
        {
            Console.Write("Digite a chave pública que será utilizada para a criptografia: ");
            return Console.ReadLine();
        }

        public static void Result(string text, string publicKey, string criptographyText)
        {
            Console.WriteLine("\nResultado:");
            Console.WriteLine($"\tO texto '{text}' com a chave pública '{publicKey}' fica: {criptographyText}\n");
        }
    }
}
