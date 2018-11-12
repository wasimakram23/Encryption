using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Same DES encryption with PBEmd5";
            Console.WriteLine("Original Text: " + text);
            DemoEncryption crypto = new DemoEncryption();
            text = crypto.EncryptUsernamePassword(text);
            Console.WriteLine("Encrypted Text: " + text);
            text = crypto.DecryptUsernamePassword(text);
            Console.WriteLine("Decrypted Text: " + text);

        }
    }
}
