using EDApp;
using System;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Utilities.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Encryption Press 1");
        Console.WriteLine("Decryption Press 2");

        Console.WriteLine("Enter Your Choice:");

        int iChoice = Convert.ToInt32(Console.ReadLine());


        switch (iChoice)
        {
            case 1:
                Class1.Encrypt();

                break;

            case 2:

                Class1.Decrypt();

                break;

            default:
                Console.WriteLine("Enter Valid Input");
                Console.WriteLine("Encryption Press 1");
                Console.WriteLine("Decryption Press 2");
                Console.WriteLine("Enter Your Choice:");
                int iChoice1 = Convert.ToInt32(Console.ReadLine());
                if (iChoice == 1)
                    goto case 1;
                else if (iChoice1 == 2)
                    goto case 2;
                else
                    goto default;
    
        }

    }
}